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
using System.Text;
using System.Net;
using System.Net.Sockets;
using SimpleSyslogConfig;
using System.Threading;

namespace SimpleSyslog
{
    public class NetReciever
    {
        private Config _Conf;
        List<PipeMessage> MessageBus;
        private bool running = true;
        private Logger Log;
        ManualResetEvent TCPwaiter = new ManualResetEvent(false);
        ManualResetEvent UDPwaiter = new ManualResetEvent(false);

        public NetReciever(ref List<PipeMessage> Bus, Config conf)
        {
            MessageBus = Bus;
            _Conf = conf;
            Log = new Logger(conf);
        }

        public void StopReciever()
        {
            running = false;
            TCPwaiter.Reset();
            TCPwaiter.Set();
            UDPwaiter.Reset();
            UDPwaiter.Set();
            Log.WriteLine("Stoping Network Listener on " + _Conf.IP.ToString() + ":" + _Conf.Port.ToString());
        }

        public void StartTCPReciever()
        {
            running = true;
            IPEndPoint ListenIP = new IPEndPoint(IPAddress.Parse(_Conf.IP), _Conf.Port);
            IPEndPoint Src = new IPEndPoint(IPAddress.Any, 0);
            Socket TCPSyslogListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Log.WriteLine("Starting TCP Network Listener on " + _Conf.IP.ToString() + ":" + _Conf.Port.ToString());
            TCPSyslogListener.Bind(ListenIP);
            TCPSyslogListener.Listen(20);
            while (running)
            {
                try
                {
                    TCPwaiter.Reset();
                    TCPSyslogListener.BeginAccept(new AsyncCallback(this.ProcessTCPMessage), TCPSyslogListener);
                    TCPwaiter.WaitOne();
                }
                catch (System.Threading.ThreadAbortException)
                {
                    Log.WriteLine("Stoping TCP Network Listener on " + _Conf.IP.ToString() + ":" + _Conf.Port.ToString());
                    running = false;
                }
                catch (Exception ex)
                {
                    Log.WriteLine("Net Error: " + ex.Message + Environment.NewLine + "Stack Trace:" + Environment.NewLine + ex.StackTrace);
                }
            }
            TCPSyslogListener.Close();
        }

        public void ProcessTCPMessage(IAsyncResult ar)
        {
            try
            {
                TCPwaiter.Set();
                byte[] bReceive = new byte[4096];
                string sReceive;
                PipeMessage Msg = new PipeMessage();
                Socket client = ((Socket)ar.AsyncState).EndAccept(ar);
                if (client != null)
                {
                    client.Receive(bReceive);
                    sReceive = Encoding.ASCII.GetString(bReceive);
                    string cleanLine = "";
                    foreach (string line in sReceive.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        cleanLine = line.TrimEnd('\0');
                        Msg.Message = cleanLine;
                        Msg.Source = ((IPEndPoint)client.RemoteEndPoint).Address;
                        Log.WriteDebugLine(string.Format("Added message '{1}' from {0} to bus", Msg.Source, Msg.Message.Substring(0, 20)));
                        lock (MessageBus)
                        {
                            MessageBus.Add(Msg);
                        }
                    }
                    client.Close();
                }

            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                Log.WriteLine(string.Format("Error Processing TCP Message: {0}{1}Stack:{2}", ex.Message, Environment.NewLine, ex.StackTrace));
            }
        }

        public void StartUDPReciever()
        {
            running = true;
            IPEndPoint ListenIP = new IPEndPoint(IPAddress.Parse(_Conf.IP), _Conf.Port);
            UdpClient SyslogListener = new UdpClient(ListenIP);
            SyslogListener.Client.ReceiveBufferSize = 4096;
            //byte[] bReceive;
            //string sReceive;
            
            PipeMessage Msg = new PipeMessage();
            Log.WriteLine("Starting UDP Network Listener on " + _Conf.IP.ToString() + ":" + _Conf.Port.ToString());
            while (running)
            {
                try
                {
                    UDPwaiter.Reset();
                    SyslogListener.BeginReceive(new AsyncCallback(this.ProcessUDPMessage),SyslogListener);
                    UDPwaiter.WaitOne();
                    //bReceive = SyslogListener.Receive(ref Src);
                    ///* Convert incoming data from bytes to ASCII */
                    //sReceive = Encoding.ASCII.GetString(bReceive);
                    //Msg.Message = sReceive;
                    //Msg.Source = Src.Address;
                    //Log.WriteDebugLine(string.Format("Added message '{1}' from {0} to bus", Msg.Source, Msg.Message.Substring(0, 20)));
                    //MessageBus.Add(Msg);
                }
                catch (System.Threading.ThreadAbortException)
                {
                    Log.WriteLine("Stoping UDP Network Listener on " + _Conf.IP.ToString() + ":" + _Conf.Port.ToString());
                    running = false;
                }
                catch (System.Net.Sockets.SocketException)
                {
                }
                catch (Exception ex)
                {
                    Log.WriteLine("Net Error: " + ex.Message + Environment.NewLine + "Stack Trace:" + Environment.NewLine + ex.StackTrace);
                }

            }
            SyslogListener.Close();
        }

        public void ProcessUDPMessage(IAsyncResult ar)
        {
            try{
            UDPwaiter.Set();
            byte[] bReceive = new byte[4096];
            string sReceive;
            IPEndPoint Src = new IPEndPoint(IPAddress.Any, 0);
            PipeMessage Msg = new PipeMessage();
            bReceive = ((UdpClient)ar.AsyncState).EndReceive(ar,ref Src);
            /* Convert incoming data from bytes to ASCII */
            sReceive = Encoding.ASCII.GetString(bReceive);
            Msg.Message = sReceive;
            Msg.Source = Src.Address;
            Log.WriteDebugLine(string.Format("Added message '{1}' from {0} to bus", Msg.Source, Msg.Message.Substring(0, 20)));
            MessageBus.Add(Msg);
            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                Log.WriteLine(string.Format("Error Processing TCP Message: {0}{1}Stack:{2}", ex.Message, Environment.NewLine, ex.StackTrace));
            }
            

        }
    }
}
