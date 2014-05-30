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
    partial class SourceEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogfileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxAge = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMaxSize = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numMaxFiles = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Name:";
            // 
            // txtSourceName
            // 
            this.txtSourceName.Location = new System.Drawing.Point(122, 10);
            this.txtSourceName.Name = "txtSourceName";
            this.txtSourceName.Size = new System.Drawing.Size(150, 20);
            this.txtSourceName.TabIndex = 1;
            this.txtSourceName.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Log File Name:";
            // 
            // txtLogfileName
            // 
            this.txtLogfileName.Location = new System.Drawing.Point(122, 36);
            this.txtLogfileName.Name = "txtLogfileName";
            this.txtLogfileName.Size = new System.Drawing.Size(150, 20);
            this.txtLogfileName.TabIndex = 1;
            this.txtLogfileName.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source IPs (One per line)";
            // 
            // txtIPs
            // 
            this.txtIPs.Location = new System.Drawing.Point(419, 10);
            this.txtIPs.Multiline = true;
            this.txtIPs.Name = "txtIPs";
            this.txtIPs.Size = new System.Drawing.Size(144, 95);
            this.txtIPs.TabIndex = 1;
            this.txtIPs.Validating += new System.ComponentModel.CancelEventHandler(this.txtIPs_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max Log Age (Days):";
            // 
            // numMaxAge
            // 
            this.numMaxAge.Location = new System.Drawing.Point(122, 62);
            this.numMaxAge.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxAge.Name = "numMaxAge";
            this.numMaxAge.Size = new System.Drawing.Size(100, 20);
            this.numMaxAge.TabIndex = 2;
            this.numMaxAge.ValueChanged += new System.EventHandler(this.ControlChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Log Size (MB):";
            // 
            // numMaxSize
            // 
            this.numMaxSize.Location = new System.Drawing.Point(122, 88);
            this.numMaxSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxSize.Name = "numMaxSize";
            this.numMaxSize.Size = new System.Drawing.Size(100, 20);
            this.numMaxSize.TabIndex = 2;
            this.numMaxSize.ValueChanged += new System.EventHandler(this.ControlChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max # of Files:";
            // 
            // numMaxFiles
            // 
            this.numMaxFiles.Location = new System.Drawing.Point(122, 114);
            this.numMaxFiles.Name = "numMaxFiles";
            this.numMaxFiles.Size = new System.Drawing.Size(100, 20);
            this.numMaxFiles.TabIndex = 2;
            this.numMaxFiles.ValueChanged += new System.EventHandler(this.ControlChanged);
            // 
            // SourceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 150);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numMaxFiles);
            this.Controls.Add(this.numMaxSize);
            this.Controls.Add(this.numMaxAge);
            this.Controls.Add(this.txtIPs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogfileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSourceName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SourceEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Source";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SourceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogfileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMaxSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaxFiles;
    }
}