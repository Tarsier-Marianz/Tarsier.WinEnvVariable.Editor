namespace Tarsier.WinEnvVariable.Editor {
    partial class ConfigServerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigServerForm));
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.chkTruncatePath = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkAppDataTempFolder = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkNewProfile = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkEnableIncludeFile = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAutoUnbind = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoSaveProfile = new System.Windows.Forms.CheckBox();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Controls.Add(this.tabPage1);
            this.tabControlConfig.ImageList = this.imageListTab;
            this.tabControlConfig.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControlConfig.Location = new System.Drawing.Point(8, 12);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(384, 353);
            this.tabControlConfig.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.chkTruncatePath);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.chkAppDataTempFolder);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.chkNewProfile);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.chkEnableIncludeFile);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.chkAutoUnbind);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkAutoSaveProfile);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(38, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Truncate all directory display";
            // 
            // chkTruncatePath
            // 
            this.chkTruncatePath.AutoSize = true;
            this.chkTruncatePath.Checked = true;
            this.chkTruncatePath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTruncatePath.Location = new System.Drawing.Point(19, 269);
            this.chkTruncatePath.Name = "chkTruncatePath";
            this.chkTruncatePath.Size = new System.Drawing.Size(94, 17);
            this.chkTruncatePath.TabIndex = 11;
            this.chkTruncatePath.Tag = "TruncatePath";
            this.chkTruncatePath.Text = "Truncate Path";
            this.chkTruncatePath.UseVisualStyleBackColor = true;
            this.chkTruncatePath.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(38, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Temporary folder will be created into Application Data.";
            // 
            // chkAppDataTempFolder
            // 
            this.chkAppDataTempFolder.AutoSize = true;
            this.chkAppDataTempFolder.Checked = true;
            this.chkAppDataTempFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppDataTempFolder.Location = new System.Drawing.Point(19, 223);
            this.chkAppDataTempFolder.Name = "chkAppDataTempFolder";
            this.chkAppDataTempFolder.Size = new System.Drawing.Size(152, 17);
            this.chkAppDataTempFolder.TabIndex = 10;
            this.chkAppDataTempFolder.Tag = "AppDataTempFolder";
            this.chkAppDataTempFolder.Text = "%AppData% Temp Folder";
            this.chkAppDataTempFolder.UseVisualStyleBackColor = true;
            this.chkAppDataTempFolder.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(38, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Execute New Profile automatically after finished saving uploaded files.";
            // 
            // chkNewProfile
            // 
            this.chkNewProfile.AutoSize = true;
            this.chkNewProfile.Checked = true;
            this.chkNewProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewProfile.Location = new System.Drawing.Point(19, 167);
            this.chkNewProfile.Name = "chkNewProfile";
            this.chkNewProfile.Size = new System.Drawing.Size(122, 17);
            this.chkNewProfile.TabIndex = 9;
            this.chkNewProfile.Tag = "ExecuteNewProfile";
            this.chkNewProfile.Text = "Execute New Profile";
            this.chkNewProfile.UseVisualStyleBackColor = true;
            this.chkNewProfile.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(38, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(322, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Automatically delete all included files during unbinding.";
            // 
            // chkEnableIncludeFile
            // 
            this.chkEnableIncludeFile.AutoSize = true;
            this.chkEnableIncludeFile.Checked = true;
            this.chkEnableIncludeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableIncludeFile.Location = new System.Drawing.Point(19, 111);
            this.chkEnableIncludeFile.Name = "chkEnableIncludeFile";
            this.chkEnableIncludeFile.Size = new System.Drawing.Size(126, 17);
            this.chkEnableIncludeFile.TabIndex = 8;
            this.chkEnableIncludeFile.Tag = "EnableIncludeFile";
            this.chkEnableIncludeFile.Text = "Enable Included Files";
            this.chkEnableIncludeFile.UseVisualStyleBackColor = true;
            this.chkEnableIncludeFile.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(38, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Automatically unbind all valid source control found while scanning files.";
            // 
            // chkAutoUnbind
            // 
            this.chkAutoUnbind.AutoSize = true;
            this.chkAutoUnbind.Location = new System.Drawing.Point(19, 60);
            this.chkAutoUnbind.Name = "chkAutoUnbind";
            this.chkAutoUnbind.Size = new System.Drawing.Size(85, 17);
            this.chkAutoUnbind.TabIndex = 7;
            this.chkAutoUnbind.Tag = "AutoUnbind";
            this.chkAutoUnbind.Text = "Auto Unbind";
            this.chkAutoUnbind.UseVisualStyleBackColor = true;
            this.chkAutoUnbind.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automatically create and save workspace after scanning files.";
            // 
            // chkAutoSaveProfile
            // 
            this.chkAutoSaveProfile.AutoSize = true;
            this.chkAutoSaveProfile.Location = new System.Drawing.Point(19, 16);
            this.chkAutoSaveProfile.Name = "chkAutoSaveProfile";
            this.chkAutoSaveProfile.Size = new System.Drawing.Size(134, 17);
            this.chkAutoSaveProfile.TabIndex = 6;
            this.chkAutoSaveProfile.Tag = "AutoSaveProfile";
            this.chkAutoSaveProfile.Text = "Automatic Save Profile";
            this.chkAutoSaveProfile.UseVisualStyleBackColor = true;
            this.chkAutoSaveProfile.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "folder-network-horizontal-open.png");
            this.imageListTab.Images.SetKeyName(1, "gear.png");
            this.imageListTab.Images.SetKeyName(2, "application-share.png");
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(236, 371);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(317, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConfigServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControlConfig);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigServerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.ConfigServerForm_Load);
            this.tabControlConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAutoSaveProfile;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAutoUnbind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkEnableIncludeFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkNewProfile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkAppDataTempFolder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkTruncatePath;
        private System.Windows.Forms.ImageList imageListTab;
    }
}