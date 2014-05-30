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
using System.IO;

namespace SimpleSyslogConfig
{
    class Logger
    {
        private Config _Conf;

        public Logger(Config Conf)
        {
            _Conf = Conf;
        }

        public void WriteLine(string Message)
        {
            bool written = false;
            string LogDir = _Conf.LogDir;
            if (!LogDir.EndsWith("\\"))
            {
                LogDir += "\\";
            }
            while (!written)
            {
                try
                {
                    FileStream log = File.Open(_Conf.LogDir + "Syslogd-" + DateTime.Now.ToString("MMyyyy") + ".txt", FileMode.Append);
                    Message += Environment.NewLine;
                    Message = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + "| INFO |" + Message;
                    byte[] buffer = GetBytes(Message);
                    log.Write(buffer, 0, buffer.Length);
                    written = true;
                    log.Close();
                }
                catch (System.IO.IOException)
                {
                }
            }
        }

        public void WriteDebugLine(string Message)
        {
            if (_Conf.DebugEnabled)
            {
                string LogDir = _Conf.LogDir;
                if (!LogDir.EndsWith("\\"))
                {
                    LogDir += "\\";
                }
                FileStream log = File.Open(_Conf.LogDir + "Syslogd-" + DateTime.Now.ToString("MMyyyy") + ".txt", FileMode.Append);
                Message += Environment.NewLine;
                Message = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + "| DEBUG |" + Message;
                byte[] buffer = GetBytes(Message);
                log.Write(buffer, 0, buffer.Length);
                log.Close();
            }
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
