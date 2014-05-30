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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleSyslogConfig;
using System.Net;

namespace SimpleSyslogGUI
{
    public partial class SourceControl : UserControl
    {
        private SourceConfig _Source;
        private SourceControlCaller _MainForm;

        public SourceControl(SourceConfig Source, SourceControlCaller MainForm)
        {
            _Source = Source;
            _MainForm = MainForm;
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblLogName.Text = _Source.LogName;
            lblName.Text = _Source.Name;
            lblRotateSize.Text = (_Source.RotateSize / 1048576).ToString() + "MB";
            lblRotateTime.Text = _Source.RotateDays.ToString() + " Days";
            lblSourceIPs.Text = string.Join(", ", _Source.Sources.ToArray());
            lblMaxFiles.Text = _Source.MaxFiles.ToString();
        }

        public interface SourceControlCaller
        {
            void EditSourceConfig(SourceConfig Source, SourceControl Sender);
            void DelteSourceConfig(SourceConfig Source, SourceControl Sender);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _MainForm.EditSourceConfig(_Source, this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _MainForm.DelteSourceConfig(_Source, this);
        }


    }
}
