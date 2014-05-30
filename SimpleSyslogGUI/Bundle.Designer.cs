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
    partial class Bundle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bundle));
            this.chkSources = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnMakezip = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgSaveBundle = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // chkSources
            // 
            this.chkSources.CheckOnClick = true;
            this.chkSources.FormattingEnabled = true;
            this.chkSources.Location = new System.Drawing.Point(12, 25);
            this.chkSources.Name = "chkSources";
            this.chkSources.Size = new System.Drawing.Size(341, 334);
            this.chkSources.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Include logs from";
            // 
            // txtOutFile
            // 
            this.txtOutFile.Location = new System.Drawing.Point(76, 365);
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(196, 20);
            this.txtOutFile.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(278, 364);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnMakezip
            // 
            this.btnMakezip.Location = new System.Drawing.Point(104, 391);
            this.btnMakezip.Name = "btnMakezip";
            this.btnMakezip.Size = new System.Drawing.Size(75, 23);
            this.btnMakezip.TabIndex = 6;
            this.btnMakezip.Text = "Bundle";
            this.btnMakezip.UseVisualStyleBackColor = true;
            this.btnMakezip.Click += new System.EventHandler(this.btnMakezip_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dlgSaveBundle
            // 
            this.dlgSaveBundle.DefaultExt = "zip";
            this.dlgSaveBundle.Filter = "All Files|*.*";
            this.dlgSaveBundle.Title = "Save Log Bundle";
            // 
            // Bundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 421);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakezip);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSources);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bundle";
            this.Text = "Create Log Bundle";
            this.Load += new System.EventHandler(this.Bundle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkSources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnMakezip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog dlgSaveBundle;
    }
}