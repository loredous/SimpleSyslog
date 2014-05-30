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
namespace SimpleSyslog
{
    partial class SimpleSyslog
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
            this.EvtProvider = new System.Diagnostics.EventLog();
            this.ConfigWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.EvtProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigWatcher)).BeginInit();
            // 
            // EvtProvider
            // 
            this.EvtProvider.Log = "Application";
            this.EvtProvider.Source = "SimpleSyslog";
            // 
            // ConfigWatcher
            // 
            this.ConfigWatcher.EnableRaisingEvents = true;
            this.ConfigWatcher.Filter = "conf.xml";
            this.ConfigWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.ConfigWatcher.Changed += new System.IO.FileSystemEventHandler(this.ConfigWatcher_Changed);
            // 
            // SimpleSyslog
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.EvtProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigWatcher)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog EvtProvider;
        private System.IO.FileSystemWatcher ConfigWatcher;
    }
}
