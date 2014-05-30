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
namespace SimpleSyslogGUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bundleLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.chkUDP = new System.Windows.Forms.CheckBox();
            this.chkTCP = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLogDir = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.LogFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SourceMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSourceControls = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblServiceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addASourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SourceMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sourcesToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigurationToolStripMenuItem,
            this.reloadConfigurationToolStripMenuItem,
            this.exportConfigurationToolStripMenuItem,
            this.importConfigurationToolStripMenuItem,
            this.bundleLogsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // reloadConfigurationToolStripMenuItem
            // 
            this.reloadConfigurationToolStripMenuItem.Name = "reloadConfigurationToolStripMenuItem";
            this.reloadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reloadConfigurationToolStripMenuItem.Text = "Reload Configuration";
            this.reloadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.reloadConfigurationToolStripMenuItem_Click);
            // 
            // exportConfigurationToolStripMenuItem
            // 
            this.exportConfigurationToolStripMenuItem.Name = "exportConfigurationToolStripMenuItem";
            this.exportConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportConfigurationToolStripMenuItem.Text = "Export Configuration";
            this.exportConfigurationToolStripMenuItem.Click += new System.EventHandler(this.exportConfigurationToolStripMenuItem_Click);
            // 
            // importConfigurationToolStripMenuItem
            // 
            this.importConfigurationToolStripMenuItem.Name = "importConfigurationToolStripMenuItem";
            this.importConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importConfigurationToolStripMenuItem.Text = "Import Configuration";
            this.importConfigurationToolStripMenuItem.Click += new System.EventHandler(this.importConfigurationToolStripMenuItem_Click);
            // 
            // bundleLogsToolStripMenuItem
            // 
            this.bundleLogsToolStripMenuItem.Name = "bundleLogsToolStripMenuItem";
            this.bundleLogsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.bundleLogsToolStripMenuItem.Text = "Bundle Logs";
            this.bundleLogsToolStripMenuItem.Click += new System.EventHandler(this.bundleLogsToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServiceToolStripMenuItem,
            this.stopServiceToolStripMenuItem,
            this.restartServiceToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // startServiceToolStripMenuItem
            // 
            this.startServiceToolStripMenuItem.Name = "startServiceToolStripMenuItem";
            this.startServiceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.startServiceToolStripMenuItem.Text = "Start Service";
            this.startServiceToolStripMenuItem.Click += new System.EventHandler(this.startServiceToolStripMenuItem_Click);
            // 
            // stopServiceToolStripMenuItem
            // 
            this.stopServiceToolStripMenuItem.Name = "stopServiceToolStripMenuItem";
            this.stopServiceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.stopServiceToolStripMenuItem.Text = "Stop Service";
            this.stopServiceToolStripMenuItem.Click += new System.EventHandler(this.stopServiceToolStripMenuItem_Click);
            // 
            // restartServiceToolStripMenuItem
            // 
            this.restartServiceToolStripMenuItem.Name = "restartServiceToolStripMenuItem";
            this.restartServiceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.restartServiceToolStripMenuItem.Text = "Restart Service";
            this.restartServiceToolStripMenuItem.Click += new System.EventHandler(this.restartServiceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.openLogToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openLogToolStripMenuItem
            // 
            this.openLogToolStripMenuItem.Name = "openLogToolStripMenuItem";
            this.openLogToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openLogToolStripMenuItem.Text = "Open Log";
            this.openLogToolStripMenuItem.Click += new System.EventHandler(this.openLogToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.chkUDP);
            this.groupBox1.Controls.Add(this.chkTCP);
            this.groupBox1.Controls.Add(this.chkDebug);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtLogDir);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Settings";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(125, 24);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(100, 20);
            this.numPort.TabIndex = 2;
            this.numPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // chkUDP
            // 
            this.chkUDP.AutoSize = true;
            this.chkUDP.Location = new System.Drawing.Point(326, 25);
            this.chkUDP.Name = "chkUDP";
            this.chkUDP.Size = new System.Drawing.Size(91, 17);
            this.chkUDP.TabIndex = 4;
            this.chkUDP.Text = "UDP Enabled";
            this.chkUDP.UseVisualStyleBackColor = true;
            this.chkUDP.CheckedChanged += new System.EventHandler(this.ConfigChanged);
            this.chkUDP.TextChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // chkTCP
            // 
            this.chkTCP.AutoSize = true;
            this.chkTCP.Location = new System.Drawing.Point(231, 25);
            this.chkTCP.Name = "chkTCP";
            this.chkTCP.Size = new System.Drawing.Size(89, 17);
            this.chkTCP.TabIndex = 4;
            this.chkTCP.Text = "TCP Enabled";
            this.chkTCP.UseVisualStyleBackColor = true;
            this.chkTCP.CheckedChanged += new System.EventHandler(this.ConfigChanged);
            this.chkTCP.TextChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(231, 50);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(120, 17);
            this.chkDebug.TabIndex = 4;
            this.chkDebug.Text = "Debugging Enabled";
            this.chkDebug.UseVisualStyleBackColor = true;
            this.chkDebug.CheckedChanged += new System.EventHandler(this.ConfigChanged);
            this.chkDebug.TextChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogDir
            // 
            this.txtLogDir.Location = new System.Drawing.Point(125, 74);
            this.txtLogDir.Name = "txtLogDir";
            this.txtLogDir.Size = new System.Drawing.Size(230, 20);
            this.txtLogDir.TabIndex = 1;
            this.txtLogDir.TextChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // txtIP
            // 
            this.txtIP.ForeColor = System.Drawing.Color.Green;
            this.txtIP.Location = new System.Drawing.Point(125, 48);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Validating += new System.ComponentModel.CancelEventHandler(this.txtIP_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log Storage Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Listening IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // ExportConfigDialog
            // 
            this.ExportConfigDialog.DefaultExt = "xml";
            this.ExportConfigDialog.FileName = "syslogConfig.xml";
            this.ExportConfigDialog.Filter = "\"XML Files|*.xml\"";
            this.ExportConfigDialog.InitialDirectory = "%Desktop%";
            this.ExportConfigDialog.Title = "Export XML Configuration";
            // 
            // ImportConfigDialog
            // 
            this.ImportConfigDialog.DefaultExt = "xml";
            this.ImportConfigDialog.FileName = "syslogConfig.xml";
            this.ImportConfigDialog.Filter = "\"XML Files|*.xml|All files|*.*\"";
            this.ImportConfigDialog.InitialDirectory = "%desktop%";
            this.ImportConfigDialog.Title = "Import XML Configuration";
            // 
            // LogFolderBrowserDialog
            // 
            this.LogFolderBrowserDialog.Description = "Select log folder";
            // 
            // groupBox2
            // 
            this.groupBox2.ContextMenuStrip = this.SourceMenuStrip;
            this.groupBox2.Controls.Add(this.pnlSourceControls);
            this.groupBox2.Location = new System.Drawing.Point(13, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 390);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Syslog Sources";
            // 
            // SourceMenuStrip
            // 
            this.SourceMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.SourceMenuStrip.Name = "SourceMenuStrip";
            this.SourceMenuStrip.Size = new System.Drawing.Size(136, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem1.Text = "Add Source";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pnlSourceControls
            // 
            this.pnlSourceControls.ColumnCount = 1;
            this.pnlSourceControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSourceControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSourceControls.Location = new System.Drawing.Point(3, 16);
            this.pnlSourceControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSourceControls.Name = "pnlSourceControls";
            this.pnlSourceControls.RowCount = 14;
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSourceControls.Size = new System.Drawing.Size(430, 371);
            this.pnlSourceControls.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServiceStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // sourcesToolStripMenuItem
            // 
            this.sourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addASourceToolStripMenuItem});
            this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sourcesToolStripMenuItem.Text = "Sources";
            // 
            // addASourceToolStripMenuItem
            // 
            this.addASourceToolStripMenuItem.Name = "addASourceToolStripMenuItem";
            this.addASourceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addASourceToolStripMenuItem.Text = "Add a Source";
            this.addASourceToolStripMenuItem.Click += new System.EventHandler(this.addASourceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Configure Simple Syslog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.SourceMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLogDir;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUDP;
        private System.Windows.Forms.CheckBox chkTCP;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog ExportConfigDialog;
        private System.Windows.Forms.OpenFileDialog ImportConfigDialog;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.FolderBrowserDialog LogFolderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip SourceMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel pnlSourceControls;
        private System.Windows.Forms.ToolStripMenuItem bundleLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartServiceToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServiceStatus;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addASourceToolStripMenuItem;
    }
}

