﻿namespace Tarsier.WinEnvVariable.Editor.Forms {
    partial class NewEnvForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEnvForm));
            this.labelMsg = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEnvFolder = new System.Windows.Forms.Button();
            this.btnAddEnvFile = new System.Windows.Forms.Button();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(12, 19);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(38, 13);
            this.labelMsg.TabIndex = 0;
            this.labelMsg.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 21);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(272, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(353, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(246)))));
            this.lblInfo.Location = new System.Drawing.Point(80, 77);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(294, 40);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "You can simply input some value or browse a file and folder. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(58, 45);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(316, 21);
            this.txtValue.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Value:";
            // 
            // btnAddEnvFolder
            // 
            this.btnAddEnvFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEnvFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEnvFolder.Image")));
            this.btnAddEnvFolder.Location = new System.Drawing.Point(402, 44);
            this.btnAddEnvFolder.Name = "btnAddEnvFolder";
            this.btnAddEnvFolder.Size = new System.Drawing.Size(26, 24);
            this.btnAddEnvFolder.TabIndex = 10;
            this.btnAddEnvFolder.Tag = "FOLDER";
            this.btnAddEnvFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEnvFolder.UseVisualStyleBackColor = true;
            this.btnAddEnvFolder.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnAddEnvFile
            // 
            this.btnAddEnvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEnvFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEnvFile.Image")));
            this.btnAddEnvFile.Location = new System.Drawing.Point(376, 44);
            this.btnAddEnvFile.Name = "btnAddEnvFile";
            this.btnAddEnvFile.Size = new System.Drawing.Size(26, 24);
            this.btnAddEnvFile.TabIndex = 9;
            this.btnAddEnvFile.Tag = "FILE";
            this.btnAddEnvFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEnvFile.UseVisualStyleBackColor = true;
            this.btnAddEnvFile.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Interval = 500;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // NewEnvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 158);
            this.Controls.Add(this.btnAddEnvFolder);
            this.Controls.Add(this.btnAddEnvFile);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelMsg);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEnvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Environment Variable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEnvFolder;
        private System.Windows.Forms.Button btnAddEnvFile;
        private System.Windows.Forms.Timer tmrCheck;
    }
}