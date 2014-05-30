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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleSyslogConfig;
using System.Xml.Serialization;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace SimpleSyslogGUI
{
    public partial class Form1 : Form, SourceControl.SourceControlCaller
    {
        private Config _Conf = new Config();
        private bool SavedSinceChange = true;
        System.Windows.Forms.Timer srvUpdateTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Conf = GetConfiguration(_Conf.ConfigPath);
            UpdateGUI();
            GetServiceStatus();
            srvUpdateTimer.Interval = 5000;
            srvUpdateTimer.Tick += new EventHandler(srvUpdateTimer_Tick);
            srvUpdateTimer.Start();
        }

        void srvUpdateTimer_Tick(object sender, EventArgs e)
        {
            GetServiceStatus();
        }

        private void UpdateGUI()
        {
            numPort.Value = _Conf.Port;
            txtIP.Text = _Conf.IP.ToString();
            txtLogDir.Text = _Conf.LogStoreDir;
            chkDebug.Checked = _Conf.DebugEnabled;
            chkTCP.Checked = _Conf.TCPEnabled;
            chkUDP.Checked = _Conf.UDPEnabled;
            pnlSourceControls.Controls.Clear();
            foreach (SourceConfig cnf in _Conf.Sources)
            {
                pnlSourceControls.Controls.Add(new SourceControl(cnf,this));
            }
            SavedSinceChange = true;
        }

        private Config GetConfiguration(string filename)
        {
            Config conf = new Config();
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                try
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Config));
                    
                    conf = (Config)deserializer.Deserialize(reader);
                    SavedSinceChange = true;
                    return conf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Problem reading configuration{0}{1}{0}{2}", Environment.NewLine, ex.Message, ex.StackTrace), "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return null;
                }
                finally
                {
                    reader.Close();
                }
            }
            else
            {
                return new Config();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void reloadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Conf = GetConfiguration(_Conf.ConfigPath);
            UpdateGUI();
        }

        private void exportConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = ExportConfigDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                SaveConfig(ExportConfigDialog.FileName);
            }
        }

        private void SaveConfig(string filename)
        {
            if(!Directory.Exists(Path.GetDirectoryName(filename)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            StreamWriter writer = new StreamWriter(filename, false);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));

                serializer.Serialize(writer, _Conf);
                SavedSinceChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Problem writing configuration{0}{1}{0}{2}", Environment.NewLine, ex.Message, ex.StackTrace), "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer.Close();
            }
        }

        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig(_Conf.ConfigPath);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SavedSinceChange)
            {
                DialogResult res = MessageBox.Show("Configuration has changed since last save. Do you wish to save the configuration now?", "Save Configuration?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        SaveConfig(_Conf.ConfigPath);
                        break;
                }
            }
        }

        private void importConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = ImportConfigDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                GetConfiguration(ImportConfigDialog.FileName);
            }
        }

        private void ConfigChanged(object sender, EventArgs e)
        {
            SavedSinceChange = false;
            switch (((Control)sender).Name)
            {
                case "numPort":
                    _Conf.Port = Convert.ToInt32(numPort.Value);
                    break;
                case "txtLogDir":
                    _Conf.LogStoreDir = txtLogDir.Text.ToString();
                    break;
                case "chkTCP":
                    _Conf.TCPEnabled = chkTCP.Checked;
                    break;
                case "chkUDP":
                    _Conf.UDPEnabled = chkUDP.Checked;
                    break;
                case "chkDebug":
                    _Conf.DebugEnabled = chkDebug.Checked;
                    break;
            }
        }

        private void txtIP_Validating(object sender, CancelEventArgs e)
        {
                    IPAddress tmp;
                    if (IPAddress.TryParse(txtIP.Text, out tmp))
                    {
                        _Conf.IP = tmp.ToString();
                        txtIP.Text = tmp.ToString();
                        txtIP.ForeColor = Color.Green;
                    }
                    else
                    {
                        txtIP.ForeColor = Color.Red;
                        txtIP.Select();
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogFolderBrowserDialog.SelectedPath = txtLogDir.Text;
            DialogResult res = LogFolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtLogDir.Text = LogFolderBrowserDialog.SelectedPath;
            }
        }

        private void GetServiceStatus()
        {
            ServiceController service = new ServiceController("SimpleSyslog");
            lblServiceStatus.Text = service.Status.ToString();
            if (service.Status == ServiceControllerStatus.Running)
            {
                lblServiceStatus.ForeColor = Color.Green;
                startServiceToolStripMenuItem.Enabled = false;
                stopServiceToolStripMenuItem.Enabled = true;
                restartServiceToolStripMenuItem.Enabled = true;
            }
            else
            {
                lblServiceStatus.ForeColor = Color.Red;
                startServiceToolStripMenuItem.Enabled = true;
                stopServiceToolStripMenuItem.Enabled = false;
                restartServiceToolStripMenuItem.Enabled = false;
            }
        }

        public void EditSourceConfig(SourceConfig Source, SourceControl Sender)
        {
            SourceEdit edit = new SourceEdit(Source);
            edit.ShowDialog();
            if (edit.DialogResult == SourceEdit.Result.Save)
            {
                _Conf.Sources.Remove(Source);
                _Conf.Sources.Add(edit.CurrentSource);
                UpdateGUI();
                SavedSinceChange = false;
            }
        }

        public void DelteSourceConfig(SourceConfig Source, SourceControl Sender)
        {
            DialogResult res = MessageBox.Show(string.Format("Are you sure you want to remove source \"{0}\"?", Source.Name), "Confirm Source Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                pnlSourceControls.Controls.Remove(Sender);
                _Conf.Sources.Remove(Source);
                SavedSinceChange = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SourceEdit edit = new SourceEdit(new SourceConfig());
            edit.ShowDialog();
            if (edit.DialogResult == SourceEdit.Result.Save)
            {
                _Conf.Sources.Add(edit.CurrentSource);
                UpdateGUI();
                SavedSinceChange = false;
            }
        }

        private void bundleLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bundle bnd = new Bundle(_Conf);
            bnd.ShowDialog();
        }

        private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(_Conf.LogDir + "Syslogd-" + DateTime.Now.ToString("MMyyyy") + ".txt");
        }

        private void startServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SavedSinceChange)
            {
                DialogResult res = MessageBox.Show("Configuration has changed since last save. Do you wish to save the configuration now?", "Save Configuration?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (res)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        SaveConfig(_Conf.ConfigPath);
                        break;
                }
            }
            ServiceController service = new ServiceController("SimpleSyslog");
            service.Start();
            this.Cursor = Cursors.WaitCursor;
            service.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 30));
            this.Cursor = Cursors.Default;
            GetServiceStatus();
            
        }

        private void stopServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("SimpleSyslog");
            service.Stop();
            this.Cursor = Cursors.WaitCursor;
            service.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0,0,30));
            this.Cursor = Cursors.Default;
            GetServiceStatus();
            
        }

        private void restartServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("SimpleSyslog");
            service.Stop();
            this.Cursor = Cursors.WaitCursor;
            service.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 30));
            GetServiceStatus();
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 30));
            this.Cursor = Cursors.Default;
            GetServiceStatus();
        }

        private void addASourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SourceEdit edit = new SourceEdit(new SourceConfig());
            edit.ShowDialog();
            if (edit.DialogResult == SourceEdit.Result.Save)
            {
                _Conf.Sources.Add(edit.CurrentSource);
                UpdateGUI();
                SavedSinceChange = false;
            }
        }
    }
}
