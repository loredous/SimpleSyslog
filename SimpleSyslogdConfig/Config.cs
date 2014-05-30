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
using System.Net;

namespace SimpleSyslogConfig
{
    [Serializable]
    public class Config
    {
        public int Port = 514;
        public string IP = IPAddress.Any.ToString();
        public string LogDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\SimpleSyslog\\";
        public bool DebugEnabled = false;
        public bool TCPEnabled = false;
        public bool UDPEnabled = true;
        public string LogStoreDir = "C:\\SyslogLogs\\";
        public List<SourceConfig> Sources = new List<SourceConfig>();
        public string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\SimpleSyslog\\config.xml";
    }

    [Serializable]
    public class SourceConfig
    {
        public List<string> Sources = new List<string>();
        public string LogDir = "";
        public string Name = "";
        public string LogName = "log.txt";
        public int RotateSize = 50000000;
        public int RotateDays = 7;
        public int MaxFiles = 10;
    }
}
