//Copyright Jeremy Banker 2014
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO.Pipes;
using System.Threading;
using SimpleSyslogConfig;
using System.Xml.Serialization;
using System.IO;

namespace SimpleSyslog
{
    public partial class SimpleSyslog : ServiceBase
    {
        Thread UDPNetReader;
        Thread TCPNetReader;
        Thread LogWrite;
        NetReciever Reciever;
        LogWriter Writer;
        StatusWriter Status;
        List<PipeMessage> MessageBus = new List<PipeMessage>();
        private Config conf = new Config();
        

        public SimpleSyslog()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                conf = GetConfiguration();
                ConfigWatcher.Path = Path.GetDirectoryName(conf.ConfigPath);
                ConfigWatcher.Filter = Path.GetFileName(conf.ConfigPath);
                Reciever = new NetReciever(ref MessageBus, conf);
                if (conf.UDPEnabled)
                {
                    UDPNetReader = new Thread(() => Reciever.StartUDPReciever());
                    UDPNetReader.Name = "Network Reader";
                    UDPNetReader.IsBackground = true;
                    UDPNetReader.Start();
                }
                if (conf.TCPEnabled)
                {
                    TCPNetReader = new Thread(() => Reciever.StartTCPReciever());
                    TCPNetReader.Name = "TCP Network Reader";
                    TCPNetReader.IsBackground = true;
                    TCPNetReader.Start();
                }
                Writer = new LogWriter(ref MessageBus, ref conf);
                LogWrite = new Thread(() => Writer.StartWriter());
                LogWrite.Name = "Log Writer";
                LogWrite.IsBackground = true;
                LogWrite.Start();
                Status = new StatusWriter(ref MessageBus, conf);
                Status.StartWriter();
                EvtProvider.WriteEntry("SimpleSyslog started", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                EvtProvider.WriteEntry("Error: " + ex.Message, EventLogEntryType.Error);
                throw ex;
            }
        }

        protected override void OnStop()
        {
            if (Reciever != null)
            {
                Reciever.StopReciever();
            }
            if (UDPNetReader != null)
            {
                UDPNetReader.Join();
            }
            if (TCPNetReader!= null)
            {
                TCPNetReader.Join();
            }
            if (Writer != null)
            {
                Writer.StopWriter();
            }
            if (LogWrite != null)
            {
                LogWrite.Join();
            }
        }

        private Config GetConfiguration()
        {
            Config conf = new Config();
            EvtProvider.WriteEntry("Loading Config from " + conf.ConfigPath, EventLogEntryType.Information);
            if (File.Exists(conf.ConfigPath))
            {
                bool loaded = false;
                int tries = 20;
                while (!loaded && tries > 0)
                {
                    try
                    {
                        XmlSerializer deserializer = new XmlSerializer(typeof(Config));
                        StreamReader reader = new StreamReader(conf.ConfigPath);
                        conf = (Config)deserializer.Deserialize(reader);
                        reader.Close();
                        loaded = true;
                        return conf;
                    }
                    catch (System.IO.IOException)
                    {
                        System.Threading.Thread.Sleep(500);
                        tries--;
                    }
                    catch (Exception ex)
                    {
                        EvtProvider.WriteEntry("Problem reading configuration!", EventLogEntryType.Error);
                        throw new System.IO.InvalidDataException("Problem reading configuration!");
                    }
                }
            }
            EvtProvider.WriteEntry("Configuration file does not exist!", EventLogEntryType.Error);
            throw new System.IO.InvalidDataException("Configuration File does not exist!");
        }

        private void ConfigWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            EvtProvider.WriteEntry("Config Changed, reloading...", EventLogEntryType.Information);
            conf = GetConfiguration();
            Writer.LoadNewConfig(conf);
        }
    }
}
