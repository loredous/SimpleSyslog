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
using System.Net;

namespace SimpleSyslogGUI
{
    public partial class SourceEdit : Form
    {
        public SourceConfig CurrentSource;
        public Result DialogResult;

        public SourceEdit(SourceConfig Source)
        {
            CurrentSource = Source;
            InitializeComponent();
        }

        private void SourceEdit_Load(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void UpdateGui()
        {
            txtLogfileName.Text = CurrentSource.LogName;
            txtSourceName.Text = CurrentSource.Name;
            txtIPs.Text = String.Join(Environment.NewLine, CurrentSource.Sources.ToArray());
            numMaxAge.Value = CurrentSource.RotateDays;
            numMaxSize.Value = (int)(CurrentSource.RotateSize / 1048576);
            numMaxFiles.Value = CurrentSource.MaxFiles;
        }

        public enum Result
        {
            Save,
            Cancel
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = Result.Save;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = Result.Cancel;
            this.Close();
        }

        private void ControlChanged(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "txtSourceName":
                    CurrentSource.Name = txtSourceName.Text;
                    break;
                case "txtLogfileName":
                    CurrentSource.LogName = txtLogfileName.Text;
                    break;
                case "numMaxAge":
                    CurrentSource.RotateDays = (int)numMaxAge.Value;
                    break;
                case "numMaxSize":
                    CurrentSource.RotateSize = (int)(numMaxSize.Value * 1048576);
                    break;
                case "numMaxFiles":
                    CurrentSource.MaxFiles = (int)numMaxFiles.Value;
                    break;
            }
        }

        private void txtIPs_Validating(object sender, CancelEventArgs e)
        {
            IPAddress tmp;
            bool valid = true;
            foreach (string ip in txtIPs.Text.Split(new string[] {Environment.NewLine},StringSplitOptions.RemoveEmptyEntries))
            {
                if (!IPAddress.TryParse(ip, out tmp))
                {
                    valid = false;
                }
            }
            if (valid)
            {
                CurrentSource.Sources.Clear();
                CurrentSource.Sources.AddRange(txtIPs.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                txtIPs.ForeColor = Color.Green;
            }
            else
            {
                txtIPs.ForeColor = Color.Red;
                txtIPs.Select();
            }
        }
    }
}
