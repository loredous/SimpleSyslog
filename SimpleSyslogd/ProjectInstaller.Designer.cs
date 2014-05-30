﻿//Copyright Jeremy Banker 2014
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
namespace SimpleSyslog
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SimpleSyslogInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.SimpleSyslog = new System.ServiceProcess.ServiceInstaller();
            // 
            // SimpleSyslogInstaller
            // 
            this.SimpleSyslogInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.SimpleSyslogInstaller.Password = null;
            this.SimpleSyslogInstaller.Username = null;
            // 
            // SimpleSyslog
            // 
            this.SimpleSyslog.DisplayName = "Simple Syslog Service";
            this.SimpleSyslog.ServiceName = "SimpleSyslog";
            this.SimpleSyslog.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.SimpleSyslogInstaller,
            this.SimpleSyslog});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller SimpleSyslogInstaller;
        private System.ServiceProcess.ServiceInstaller SimpleSyslog;
    }
}