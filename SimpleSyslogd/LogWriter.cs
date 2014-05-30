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
using System.Linq;
using System.Text;
using System.IO.Pipes;
using SimpleSyslogConfig;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace SimpleSyslog
{
    public class LogWriter
    {
        private Config _Conf = new Config();
        private List<PipeMessage> MessageBus;
        private bool running = true;
        Logger Log;

        public LogWriter(ref List<PipeMessage> Bus, ref Config conf)
        {
            _Conf = conf;
            MessageBus = Bus;
            Log = new Logger(_Conf);
        }

        public void StopWriter()
        {
            running = false;
            Log.WriteLine("Stopping Log Writer");
        }

        public void LoadNewConfig(Config conf)
        {
            Log.WriteLine("Loading new configuration...");
            _Conf = conf;
        }

        public void StartWriter()
        {
            running = true;
            PipeMessage Msg = new PipeMessage();
            Log.WriteLine("Starting Log Writer");
                while (running)
                {
                    try
                    {
                        lock (MessageBus)
                        {
                            if (MessageBus.Count > 0)
                            {
                                Msg = MessageBus[0];
                                if (Msg != null)
                                {
                                    ProcessMessage(Msg);
                                    Log.WriteDebugLine(string.Format("Processed message {0} from {1}", Msg.Message.Substring(0, 20), Msg.Source.ToString()));
                                }
                                MessageBus.RemoveAt(0);
                            }
                        }
                    }
                    catch (System.Threading.ThreadAbortException)
                    {
                        running = false;
                    }
                    catch (Exception ex)
                    {
                        Log.WriteLine("Read Error: " + ex.Message + " - " + ex.StackTrace);
                    }
                }
                while (MessageBus.Count > 0)
                {
                    Msg = MessageBus[0];
                    if (Msg != null)
                    {
                        ProcessMessage(Msg);
                    }
                    MessageBus.Remove(Msg);
                }
            
            
        }

        private void ProcessMessage(PipeMessage Msg)
        {
            SourceConfig tmp;
            byte[] buffer;
            Msg.Message = Msg.Message.Trim();
            if ((tmp = _Conf.Sources.Find(src => src.Sources.Contains(Msg.Source.ToString()))) != null)
            {
                if (tmp.LogDir == "")
                {
                    tmp.LogDir = _Conf.LogStoreDir + tmp.Name + "\\";
                }
                if (!Directory.Exists(tmp.LogDir))
                {
                    Directory.CreateDirectory(tmp.LogDir);
                }
                if (Directory.GetFiles(tmp.LogDir).Length >= tmp.MaxFiles)
                {
                    DateTime mod = DateTime.Now;
                    DateTime dOldest = DateTime.Now;
                    string sOldest = "";
                    foreach (string file in Directory.GetFiles(tmp.LogDir))
                    {
                        mod = File.GetCreationTime(file);
                        if (mod < dOldest)
                        {
                            dOldest = mod;
                            sOldest = file;
                        }
                    }
                    try
                    {
                        File.Delete(sOldest);
                    }
                    catch (Exception ex)
                    {
                        Log.WriteLine(string.Format("Exception deleting file: {0} {1}Stack:{1}{2}", ex.Message, Environment.NewLine, ex.StackTrace));
                    }
                }
                FileStream fStream = File.Open(tmp.LogDir + tmp.LogName, FileMode.Append);
                //Msg.Message += Environment.NewLine;
                if (((fStream.Length > tmp.RotateSize) && !(tmp.RotateSize == 0)) || (((DateTime.Now - File.GetCreationTime(tmp.LogDir + tmp.LogName)).Days > tmp.RotateDays) && !(tmp.RotateDays == 0)))
                {
                    fStream.Close();
                    File.Copy(tmp.LogDir + tmp.LogName, tmp.LogDir + DateTime.Now.ToString("MMddyyyy-HHmmss") + "-" + tmp.LogName);
                    fStream = File.Open(tmp.LogDir + tmp.LogName, FileMode.Truncate);
                }
                string tMsg = Msg.Message.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
                tMsg += Environment.NewLine;
                buffer = GetBytes(tMsg);
                fStream.Write(buffer, 0, buffer.Length);
                fStream.Close();
            }
            else { Log.WriteLine(string.Format("Source {0} not found",Msg.Source.ToString()));}
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

    }
}
