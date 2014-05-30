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
using SimpleSyslogConfig;
using System.Timers;

namespace SimpleSyslog
{
    public class StatusWriter
    {
        private Config _Conf;
        private Logger Log;
        private List<PipeMessage> MessageBus;
        Timer StatusTimer = new Timer(60000);

        public StatusWriter(ref List<PipeMessage> bus, Config conf)
        {
            _Conf = conf;
            MessageBus = bus;
            Log = new Logger(_Conf);
            StatusTimer.Elapsed += new ElapsedEventHandler(StatusTimer_Elapsed);
        }

        void StatusTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Log.WriteLine(string.Format("Queue Size: {0}", MessageBus.Count.ToString()));
        }

        public void StartWriter()
        {
            StatusTimer.Start();
        }

        public void StopWriter()
        {
            StatusTimer.Stop();
        }
    }
}
