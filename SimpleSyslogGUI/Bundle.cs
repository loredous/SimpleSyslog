
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
using System.Windows.Forms;
using SimpleSyslogConfig;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace SimpleSyslogGUI
{
    public partial class Bundle : Form
    {
        private Config _Conf;

        public Bundle(Config Conf)
        {
            _Conf = Conf;
            InitializeComponent();
        }

        private void Bundle_Load(object sender, EventArgs e)
        {
            chkSources.Items.Clear();
            foreach (SourceConfig src in _Conf.Sources)
            {
                chkSources.Items.Add(src.Name,false);
            }
            chkSources.Items.Add("SimpleSyslog Logs", true);
            txtOutFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SyslogBundle-" + DateTime.Now.ToString("MMddyyyy-HHmmss") + ".zip";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult res = dlgSaveBundle.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtOutFile.Text = dlgSaveBundle.FileName;
            }
            else
            {
                dlgSaveBundle.FileName = "";
            }
        }

        private void btnMakezip_Click(object sender, EventArgs e)
        {
            List<SourceConfig> toBundle = new List<SourceConfig>();
            bool syslogs = false;
            foreach (string item in chkSources.CheckedItems)
            {
                toBundle.Add(_Conf.Sources.Find(src => src.Name == item));
            }
            toBundle.RemoveAll(src => src == null);
            if (chkSources.CheckedItems.Contains("SimpleSyslog Logs"))
            {
                syslogs = true;
            }
            if (File.Exists(txtOutFile.Text))
            {
                File.Delete(txtOutFile.Text);
            }
            ZipFile zip = ZipFile.Create(txtOutFile.Text);
            zip.BeginUpdate();
            foreach (SourceConfig conf in toBundle)
            {
                string[] files = Directory.GetFiles(_Conf.LogStoreDir + conf.Name);
                foreach (string file in files)
                {
                    zip.Add(file);
                }
            }
            if (syslogs)
            {
                zip.Add(_Conf.ConfigPath);
                string[] logfiles = Directory.GetFiles(_Conf.LogDir, "Syslogd-*", SearchOption.TopDirectoryOnly);
                foreach (string file in logfiles)
                {
                    zip.Add(file);
                }
                
            }
            zip.CommitUpdate();
            zip.Close();
            MessageBox.Show("Bundle created at " + txtOutFile.Text, "Bundle Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
