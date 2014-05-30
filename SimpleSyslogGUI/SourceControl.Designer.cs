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
    partial class SourceControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogName = new System.Windows.Forms.Label();
            this.lblRotateSize = new System.Windows.Forms.Label();
            this.lblRotateTime = new System.Windows.Forms.Label();
            this.lblMaxFiles = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSourceIPs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Log Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rotate at Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rotate Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Files:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(347, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(347, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "                   ";
            // 
            // lblLogName
            // 
            this.lblLogName.AutoSize = true;
            this.lblLogName.Location = new System.Drawing.Point(85, 13);
            this.lblLogName.Name = "lblLogName";
            this.lblLogName.Size = new System.Drawing.Size(64, 13);
            this.lblLogName.TabIndex = 2;
            this.lblLogName.Text = "                   ";
            // 
            // lblRotateSize
            // 
            this.lblRotateSize.AutoSize = true;
            this.lblRotateSize.Location = new System.Drawing.Point(85, 26);
            this.lblRotateSize.Name = "lblRotateSize";
            this.lblRotateSize.Size = new System.Drawing.Size(64, 13);
            this.lblRotateSize.TabIndex = 2;
            this.lblRotateSize.Text = "                   ";
            // 
            // lblRotateTime
            // 
            this.lblRotateTime.AutoSize = true;
            this.lblRotateTime.Location = new System.Drawing.Point(85, 39);
            this.lblRotateTime.Name = "lblRotateTime";
            this.lblRotateTime.Size = new System.Drawing.Size(64, 13);
            this.lblRotateTime.TabIndex = 2;
            this.lblRotateTime.Text = "                   ";
            // 
            // lblMaxFiles
            // 
            this.lblMaxFiles.AutoSize = true;
            this.lblMaxFiles.Location = new System.Drawing.Point(85, 52);
            this.lblMaxFiles.Name = "lblMaxFiles";
            this.lblMaxFiles.Size = new System.Drawing.Size(64, 13);
            this.lblMaxFiles.TabIndex = 2;
            this.lblMaxFiles.Text = "                   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Source IPs:";
            // 
            // lblSourceIPs
            // 
            this.lblSourceIPs.AutoSize = true;
            this.lblSourceIPs.Location = new System.Drawing.Point(85, 65);
            this.lblSourceIPs.Name = "lblSourceIPs";
            this.lblSourceIPs.Size = new System.Drawing.Size(64, 13);
            this.lblSourceIPs.TabIndex = 2;
            this.lblSourceIPs.Text = "                   ";
            // 
            // SourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSourceIPs);
            this.Controls.Add(this.lblMaxFiles);
            this.Controls.Add(this.lblRotateTime);
            this.Controls.Add(this.lblRotateSize);
            this.Controls.Add(this.lblLogName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SourceControl";
            this.Size = new System.Drawing.Size(425, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLogName;
        private System.Windows.Forms.Label lblRotateSize;
        private System.Windows.Forms.Label lblRotateTime;
        private System.Windows.Forms.Label lblMaxFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSourceIPs;

    }
}
