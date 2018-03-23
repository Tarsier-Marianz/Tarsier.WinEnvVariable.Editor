namespace Tarsier.WinEnvVariable.Editor {
    partial class MainWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStripUploader = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.newArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArchiveEnv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ridFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideStatusbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripUploader = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripUploader = new System.Windows.Forms.ToolStrip();
            this.btnSetEnv = new System.Windows.Forms.ToolStripButton();
            this.btnUnbind = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshProfile = new System.Windows.Forms.ToolStripButton();
            this.btnArchiveEnv = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddFile = new System.Windows.Forms.ToolStripButton();
            this.btnAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.lblInfoVersion = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.archivesListBox = new Tarsier.UI.MessageListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProfileTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEnvironment = new System.Windows.Forms.TabPage();
            this.listViewEnvVars = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnHeaderSourceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourceCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListInfo = new System.Windows.Forms.ImageList(this.components);
            this.panelFilesTop = new System.Windows.Forms.Panel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblProfileCaption = new System.Windows.Forms.Label();
            this.tabControlDetails = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.pBoxVersionCompare = new System.Windows.Forms.PictureBox();
            this.lblArchiveModified = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArchiveDescription = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblArchiveCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArchiveName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageEnv = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteEnv = new System.Windows.Forms.Button();
            this.btnUpdateEnv = new System.Windows.Forms.Button();
            this.txtEnvName = new System.Windows.Forms.TextBox();
            this.txtEnvValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddEnvFolder = new System.Windows.Forms.Button();
            this.btnAddEnvFile = new System.Windows.Forms.Button();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.logsListBox = new Tarsier.UI.MessageListBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.tipUploader = new System.Windows.Forms.ToolTip(this.components);
            this.bgWorkerUnbind = new System.ComponentModel.BackgroundWorker();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.menuStripUploader.SuspendLayout();
            this.statusStripUploader.SuspendLayout();
            this.toolStripUploader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelProfileTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEnvironment.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.panelFilesTop.SuspendLayout();
            this.tabControlDetails.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVersionCompare)).BeginInit();
            this.tabPageEnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripUploader
            // 
            this.menuStripUploader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripUploader.Location = new System.Drawing.Point(0, 0);
            this.menuStripUploader.Name = "menuStripUploader";
            this.menuStripUploader.Size = new System.Drawing.Size(839, 24);
            this.menuStripUploader.TabIndex = 2;
            this.menuStripUploader.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.newArchiveToolStripMenuItem,
            this.menuItemArchiveEnv,
            this.toolStripSeparator12,
            this.clearLogsToolStripMenuItem,
            this.optionsToolStripMenuItem1,
            this.toolStripSeparator9,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // newArchiveToolStripMenuItem
            // 
            this.newArchiveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newArchiveToolStripMenuItem.Image")));
            this.newArchiveToolStripMenuItem.Name = "newArchiveToolStripMenuItem";
            this.newArchiveToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.newArchiveToolStripMenuItem.Text = "New Environment Archive";
            // 
            // menuItemArchiveEnv
            // 
            this.menuItemArchiveEnv.Image = ((System.Drawing.Image)(resources.GetObject("menuItemArchiveEnv.Image")));
            this.menuItemArchiveEnv.Name = "menuItemArchiveEnv";
            this.menuItemArchiveEnv.Size = new System.Drawing.Size(212, 22);
            this.menuItemArchiveEnv.Tag = "SAVE";
            this.menuItemArchiveEnv.Text = "Archive Environment";
            this.menuItemArchiveEnv.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(209, 6);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearLogsToolStripMenuItem.Image")));
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.clearLogsToolStripMenuItem.Tag = "CLEAR_LOGS";
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem1.Image")));
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.optionsToolStripMenuItem1.Tag = "OPTIONS";
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(209, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Tag = "EXIT";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newValueToolStripMenuItem,
            this.ridFilesToolStripMenuItem,
            this.menuItemAddFile,
            this.menuItemAddFolder});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.actionToolStripMenuItem.Text = "Environment";
            // 
            // newValueToolStripMenuItem
            // 
            this.newValueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newValueToolStripMenuItem.Image")));
            this.newValueToolStripMenuItem.Name = "newValueToolStripMenuItem";
            this.newValueToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.newValueToolStripMenuItem.Tag = "CREATE_ENV";
            this.newValueToolStripMenuItem.Text = "Create New...";
            this.newValueToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // ridFilesToolStripMenuItem
            // 
            this.ridFilesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ridFilesToolStripMenuItem.Enabled = false;
            this.ridFilesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ridFilesToolStripMenuItem.Name = "ridFilesToolStripMenuItem";
            this.ridFilesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ridFilesToolStripMenuItem.Text = "Update Environment Value";
            // 
            // menuItemAddFile
            // 
            this.menuItemAddFile.Image = ((System.Drawing.Image)(resources.GetObject("menuItemAddFile.Image")));
            this.menuItemAddFile.Name = "menuItemAddFile";
            this.menuItemAddFile.Size = new System.Drawing.Size(224, 22);
            this.menuItemAddFile.Tag = "ADD_FILE";
            this.menuItemAddFile.Text = "Value from File...";
            this.menuItemAddFile.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // menuItemAddFolder
            // 
            this.menuItemAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("menuItemAddFolder.Image")));
            this.menuItemAddFolder.Name = "menuItemAddFolder";
            this.menuItemAddFolder.Size = new System.Drawing.Size(224, 22);
            this.menuItemAddFolder.Tag = "ADD_FOLDER";
            this.menuItemAddFolder.Text = "Value from Folder";
            this.menuItemAddFolder.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileExplorerToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.toolStripSeparator2,
            this.hideToolbarToolStripMenuItem,
            this.hideStatusbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // profileExplorerToolStripMenuItem
            // 
            this.profileExplorerToolStripMenuItem.CheckOnClick = true;
            this.profileExplorerToolStripMenuItem.Name = "profileExplorerToolStripMenuItem";
            this.profileExplorerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.profileExplorerToolStripMenuItem.Tag = "PROFILE_EXPLORER";
            this.profileExplorerToolStripMenuItem.Text = "Profile Explorer";
            this.profileExplorerToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Checked = true;
            this.logsToolStripMenuItem.CheckOnClick = true;
            this.logsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logsToolStripMenuItem.Tag = "LOGS";
            this.logsToolStripMenuItem.Text = "Profile Details && Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // hideToolbarToolStripMenuItem
            // 
            this.hideToolbarToolStripMenuItem.Checked = true;
            this.hideToolbarToolStripMenuItem.CheckOnClick = true;
            this.hideToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideToolbarToolStripMenuItem.Name = "hideToolbarToolStripMenuItem";
            this.hideToolbarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hideToolbarToolStripMenuItem.Tag = "TOOLBAR";
            this.hideToolbarToolStripMenuItem.Text = "Toolbar";
            this.hideToolbarToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // hideStatusbarToolStripMenuItem
            // 
            this.hideStatusbarToolStripMenuItem.Checked = true;
            this.hideStatusbarToolStripMenuItem.CheckOnClick = true;
            this.hideStatusbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideStatusbarToolStripMenuItem.Name = "hideStatusbarToolStripMenuItem";
            this.hideStatusbarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hideStatusbarToolStripMenuItem.Tag = "STATUSBAR";
            this.hideStatusbarToolStripMenuItem.Text = "Statusbar";
            this.hideStatusbarToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Tag = "HELP";
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Tag = "ABOUT";
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // statusStripUploader
            // 
            this.statusStripUploader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar,
            this.lblStatusFile});
            this.statusStripUploader.Location = new System.Drawing.Point(0, 484);
            this.statusStripUploader.Name = "statusStripUploader";
            this.statusStripUploader.Size = new System.Drawing.Size(839, 22);
            this.statusStripUploader.TabIndex = 3;
            this.statusStripUploader.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // lblStatusFile
            // 
            this.lblStatusFile.Name = "lblStatusFile";
            this.lblStatusFile.Size = new System.Drawing.Size(118, 17);
            this.lblStatusFile.Text = "toolStripStatusLabel2";
            // 
            // toolStripUploader
            // 
            this.toolStripUploader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetEnv,
            this.btnUnbind,
            this.btnRefreshProfile,
            this.btnArchiveEnv,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.btnAddFile,
            this.btnAddFolder,
            this.toolStripLabel1,
            this.toolStripSeparator8,
            this.btnOptions,
            this.btnHelp,
            this.btnExit,
            this.lblInfoVersion});
            this.toolStripUploader.Location = new System.Drawing.Point(0, 24);
            this.toolStripUploader.Name = "toolStripUploader";
            this.toolStripUploader.Size = new System.Drawing.Size(839, 25);
            this.toolStripUploader.TabIndex = 4;
            this.toolStripUploader.Text = "toolStrip1";
            // 
            // btnSetEnv
            // 
            this.btnSetEnv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetEnv.Image = ((System.Drawing.Image)(resources.GetObject("btnSetEnv.Image")));
            this.btnSetEnv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetEnv.Name = "btnSetEnv";
            this.btnSetEnv.Size = new System.Drawing.Size(23, 22);
            this.btnSetEnv.Text = "Set all environment variable from selected archive";
            // 
            // btnUnbind
            // 
            this.btnUnbind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnbind.Image = ((System.Drawing.Image)(resources.GetObject("btnUnbind.Image")));
            this.btnUnbind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnbind.Name = "btnUnbind";
            this.btnUnbind.Size = new System.Drawing.Size(23, 22);
            this.btnUnbind.Tag = "UNBIND";
            this.btnUnbind.Text = "Unbind";
            this.btnUnbind.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnRefreshProfile
            // 
            this.btnRefreshProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshProfile.Image")));
            this.btnRefreshProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshProfile.Name = "btnRefreshProfile";
            this.btnRefreshProfile.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshProfile.Tag = "REFRESH";
            this.btnRefreshProfile.Text = "Reload Workspace";
            this.btnRefreshProfile.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnArchiveEnv
            // 
            this.btnArchiveEnv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnArchiveEnv.Image = ((System.Drawing.Image)(resources.GetObject("btnArchiveEnv.Image")));
            this.btnArchiveEnv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArchiveEnv.Name = "btnArchiveEnv";
            this.btnArchiveEnv.Size = new System.Drawing.Size(23, 22);
            this.btnArchiveEnv.Tag = "SAVE";
            this.btnArchiveEnv.Text = "Archive Environment";
            this.btnArchiveEnv.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddFile
            // 
            this.btnAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFile.Image")));
            this.btnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(23, 22);
            this.btnAddFile.Tag = "ADD_FILE";
            this.btnAddFile.Text = "Environment value from selected file";
            this.btnAddFile.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFolder.Image")));
            this.btnAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(23, 22);
            this.btnAddFolder.Tag = "ADD_FOLDER";
            this.btnAddFolder.Text = "Environment value from selected folder";
            this.btnAddFolder.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel1.Text = "    ";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 22);
            this.btnOptions.Tag = "OPTIONS";
            this.btnOptions.Text = "Options";
            this.btnOptions.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Tag = "HELP";
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Tag = "EXIT";
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // lblInfoVersion
            // 
            this.lblInfoVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblInfoVersion.Enabled = false;
            this.lblInfoVersion.Name = "lblInfoVersion";
            this.lblInfoVersion.Size = new System.Drawing.Size(13, 22);
            this.lblInfoVersion.Text = "v";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panelProfileTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(839, 435);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.archivesListBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 408);
            this.panel1.TabIndex = 3;
            // 
            // archivesListBox
            // 
            this.archivesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archivesListBox.AutoScroll = true;
            this.archivesListBox.AutoScrollMinSize = new System.Drawing.Size(141, 0);
            this.archivesListBox.BackColor = System.Drawing.Color.White;
            this.archivesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.archivesListBox.DateFont = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesListBox.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(246)))));
            this.archivesListBox.HeaderColor = System.Drawing.Color.Black;
            this.archivesListBox.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.archivesListBox.Location = new System.Drawing.Point(3, 0);
            this.archivesListBox.Name = "archivesListBox";
            this.archivesListBox.SelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.archivesListBox.SelectedIndex = -1;
            this.archivesListBox.SelectedItem = null;
            this.archivesListBox.SelectedTextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.archivesListBox.SeparatorColor = System.Drawing.Color.WhiteSmoke;
            this.archivesListBox.Size = new System.Drawing.Size(171, 387);
            this.archivesListBox.TabIndex = 4;
            this.archivesListBox.DoubleClick += new System.EventHandler(this.profileListBox_DoubleClick);
            this.archivesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.profileListBox_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 24);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Double click archive item to open.";
            // 
            // panelProfileTop
            // 
            this.panelProfileTop.Controls.Add(this.label1);
            this.panelProfileTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileTop.Location = new System.Drawing.Point(0, 0);
            this.panelProfileTop.Name = "panelProfileTop";
            this.panelProfileTop.Size = new System.Drawing.Size(176, 27);
            this.panelProfileTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Environment Archives";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1.Controls.Add(this.panelFilesTop);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlDetails);
            this.splitContainer2.Size = new System.Drawing.Size(659, 435);
            this.splitContainer2.SplitterDistance = 227;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEnvironment);
            this.tabControl1.Controls.Add(this.tabPageBackup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageListInfo;
            this.tabControl1.ItemSize = new System.Drawing.Size(55, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 200);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageEnvironment
            // 
            this.tabPageEnvironment.Controls.Add(this.listViewEnvVars);
            this.tabPageEnvironment.ImageIndex = 14;
            this.tabPageEnvironment.Location = new System.Drawing.Point(4, 28);
            this.tabPageEnvironment.Name = "tabPageEnvironment";
            this.tabPageEnvironment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnvironment.Size = new System.Drawing.Size(651, 168);
            this.tabPageEnvironment.TabIndex = 0;
            this.tabPageEnvironment.Text = "Environment";
            this.tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // listViewEnvVars
            // 
            this.listViewEnvVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colName,
            this.colValue});
            this.listViewEnvVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEnvVars.FullRowSelect = true;
            this.listViewEnvVars.GridLines = true;
            this.listViewEnvVars.Location = new System.Drawing.Point(3, 3);
            this.listViewEnvVars.Name = "listViewEnvVars";
            this.listViewEnvVars.Size = new System.Drawing.Size(645, 162);
            this.listViewEnvVars.TabIndex = 0;
            this.listViewEnvVars.UseCompatibleStateImageBehavior = false;
            this.listViewEnvVars.View = System.Windows.Forms.View.Details;
            this.listViewEnvVars.SelectedIndexChanged += new System.EventHandler(this.listViewEnvVars_SelectedIndexChanged);
            // 
            // colIndex
            // 
            this.colIndex.Text = "#";
            this.colIndex.Width = 30;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 244;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 340;
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.listViewHistory);
            this.tabPageBackup.ImageIndex = 16;
            this.tabPageBackup.Location = new System.Drawing.Point(4, 28);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(651, 168);
            this.tabPageBackup.TabIndex = 1;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSourceType,
            this.columnHeaderSourceCount,
            this.columnHeaderDetails});
            this.listViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.Location = new System.Drawing.Point(3, 3);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(645, 162);
            this.listViewHistory.TabIndex = 1;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSourceType
            // 
            this.columnHeaderSourceType.Text = "Source Type";
            this.columnHeaderSourceType.Width = 176;
            // 
            // columnHeaderSourceCount
            // 
            this.columnHeaderSourceCount.Text = "Source Count";
            this.columnHeaderSourceCount.Width = 80;
            // 
            // columnHeaderDetails
            // 
            this.columnHeaderDetails.Text = "Details";
            this.columnHeaderDetails.Width = 230;
            // 
            // imageListInfo
            // 
            this.imageListInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListInfo.ImageStream")));
            this.imageListInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListInfo.Images.SetKeyName(0, "exclamation-red.png");
            this.imageListInfo.Images.SetKeyName(1, "exclamation-circle.png");
            this.imageListInfo.Images.SetKeyName(2, "tick-circle.png");
            this.imageListInfo.Images.SetKeyName(3, "blue-folder-broken.png");
            this.imageListInfo.Images.SetKeyName(4, "history.png");
            this.imageListInfo.Images.SetKeyName(5, "bug--minus.png");
            this.imageListInfo.Images.SetKeyName(6, "flag--exclamation.png");
            this.imageListInfo.Images.SetKeyName(7, "application-x-addon.png");
            this.imageListInfo.Images.SetKeyName(8, "env-computer.png");
            this.imageListInfo.Images.SetKeyName(9, "env-save.png");
            this.imageListInfo.Images.SetKeyName(10, "env-save-as.png");
            this.imageListInfo.Images.SetKeyName(11, "folder_brick.png");
            this.imageListInfo.Images.SetKeyName(12, "preferences-other.png");
            this.imageListInfo.Images.SetKeyName(13, "preferences-system-network.png");
            this.imageListInfo.Images.SetKeyName(14, "preferences-desktop-remote-desktop.png");
            this.imageListInfo.Images.SetKeyName(15, "preferences-desktop-wallpaper.png");
            this.imageListInfo.Images.SetKeyName(16, "system-file-manager.png");
            // 
            // panelFilesTop
            // 
            this.panelFilesTop.Controls.Add(this.labelSearch);
            this.panelFilesTop.Controls.Add(this.btnSearch);
            this.panelFilesTop.Controls.Add(this.txtSearch);
            this.panelFilesTop.Controls.Add(this.lblProfileCaption);
            this.panelFilesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilesTop.Location = new System.Drawing.Point(0, 0);
            this.panelFilesTop.Name = "panelFilesTop";
            this.panelFilesTop.Size = new System.Drawing.Size(659, 27);
            this.panelFilesTop.TabIndex = 3;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.ForeColor = System.Drawing.Color.Silver;
            this.labelSearch.Location = new System.Drawing.Point(363, 5);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(624, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Tag = "FIND";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(411, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 21);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblProfileCaption
            // 
            this.lblProfileCaption.AutoSize = true;
            this.lblProfileCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCaption.Location = new System.Drawing.Point(3, 6);
            this.lblProfileCaption.Name = "lblProfileCaption";
            this.lblProfileCaption.Size = new System.Drawing.Size(13, 13);
            this.lblProfileCaption.TabIndex = 1;
            this.lblProfileCaption.Text = "?";
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageProfile);
            this.tabControlDetails.Controls.Add(this.tabPageEnv);
            this.tabControlDetails.Controls.Add(this.tabPageLogs);
            this.tabControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetails.ImageList = this.imageListInfo;
            this.tabControlDetails.Location = new System.Drawing.Point(0, 0);
            this.tabControlDetails.Name = "tabControlDetails";
            this.tabControlDetails.SelectedIndex = 0;
            this.tabControlDetails.Size = new System.Drawing.Size(659, 204);
            this.tabControlDetails.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.pBoxVersionCompare);
            this.tabPageProfile.Controls.Add(this.lblArchiveModified);
            this.tabPageProfile.Controls.Add(this.label8);
            this.tabPageProfile.Controls.Add(this.lblArchiveDescription);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.lblArchiveCount);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.lblArchiveName);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.ImageIndex = 12;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 23);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(651, 177);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Archive Details";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // pBoxVersionCompare
            // 
            this.pBoxVersionCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxVersionCompare.Image = global::Tarsier.WinEnvVariable.Editor.Properties.Resources.folder_ok;
            this.pBoxVersionCompare.Location = new System.Drawing.Point(657, 8);
            this.pBoxVersionCompare.Name = "pBoxVersionCompare";
            this.pBoxVersionCompare.Size = new System.Drawing.Size(16, 16);
            this.pBoxVersionCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxVersionCompare.TabIndex = 10;
            this.pBoxVersionCompare.TabStop = false;
            // 
            // lblArchiveModified
            // 
            this.lblArchiveModified.AutoSize = true;
            this.lblArchiveModified.Location = new System.Drawing.Point(90, 57);
            this.lblArchiveModified.Name = "lblArchiveModified";
            this.lblArchiveModified.Size = new System.Drawing.Size(11, 13);
            this.lblArchiveModified.TabIndex = 9;
            this.lblArchiveModified.Tag = "CLEAR";
            this.lblArchiveModified.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modified:";
            // 
            // lblArchiveDescription
            // 
            this.lblArchiveDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArchiveDescription.AutoEllipsis = true;
            this.lblArchiveDescription.Location = new System.Drawing.Point(93, 81);
            this.lblArchiveDescription.Name = "lblArchiveDescription";
            this.lblArchiveDescription.Size = new System.Drawing.Size(546, 68);
            this.lblArchiveDescription.TabIndex = 7;
            this.lblArchiveDescription.Tag = "CLEAR";
            this.lblArchiveDescription.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description:";
            // 
            // lblArchiveCount
            // 
            this.lblArchiveCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArchiveCount.Location = new System.Drawing.Point(90, 33);
            this.lblArchiveCount.Name = "lblArchiveCount";
            this.lblArchiveCount.Size = new System.Drawing.Size(430, 16);
            this.lblArchiveCount.TabIndex = 3;
            this.lblArchiveCount.Tag = "CLEAR";
            this.lblArchiveCount.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Count:";
            // 
            // lblArchiveName
            // 
            this.lblArchiveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArchiveName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArchiveName.Location = new System.Drawing.Point(88, 9);
            this.lblArchiveName.Name = "lblArchiveName";
            this.lblArchiveName.Size = new System.Drawing.Size(538, 16);
            this.lblArchiveName.TabIndex = 1;
            this.lblArchiveName.Tag = "CLEAR";
            this.lblArchiveName.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Archive Name:";
            // 
            // tabPageEnv
            // 
            this.tabPageEnv.Controls.Add(this.label10);
            this.tabPageEnv.Controls.Add(this.label9);
            this.tabPageEnv.Controls.Add(this.btnDeleteEnv);
            this.tabPageEnv.Controls.Add(this.btnUpdateEnv);
            this.tabPageEnv.Controls.Add(this.txtEnvName);
            this.tabPageEnv.Controls.Add(this.txtEnvValue);
            this.tabPageEnv.Controls.Add(this.label6);
            this.tabPageEnv.Controls.Add(this.label4);
            this.tabPageEnv.Controls.Add(this.pictureBox2);
            this.tabPageEnv.Controls.Add(this.pictureBox1);
            this.tabPageEnv.Controls.Add(this.btnAddEnvFolder);
            this.tabPageEnv.Controls.Add(this.btnAddEnvFile);
            this.tabPageEnv.ImageIndex = 15;
            this.tabPageEnv.Location = new System.Drawing.Point(4, 23);
            this.tabPageEnv.Name = "tabPageEnv";
            this.tabPageEnv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnv.Size = new System.Drawing.Size(651, 177);
            this.tabPageEnv.TabIndex = 2;
            this.tabPageEnv.Text = "Environment Details";
            this.tabPageEnv.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(255, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "If you know what you are doing, the you can execute anything in this section.";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(246)))));
            this.label9.Location = new System.Drawing.Point(93, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(548, 46);
            this.label9.TabIndex = 10;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // btnDeleteEnv
            // 
            this.btnDeleteEnv.Location = new System.Drawing.Point(152, 82);
            this.btnDeleteEnv.Name = "btnDeleteEnv";
            this.btnDeleteEnv.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEnv.TabIndex = 6;
            this.btnDeleteEnv.Tag = "ENV_DELETE";
            this.btnDeleteEnv.Text = "Delete";
            this.btnDeleteEnv.UseVisualStyleBackColor = true;
            this.btnDeleteEnv.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnUpdateEnv
            // 
            this.btnUpdateEnv.Location = new System.Drawing.Point(71, 82);
            this.btnUpdateEnv.Name = "btnUpdateEnv";
            this.btnUpdateEnv.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEnv.TabIndex = 5;
            this.btnUpdateEnv.Tag = "ENV_UPDATE";
            this.btnUpdateEnv.Text = "Update";
            this.btnUpdateEnv.UseVisualStyleBackColor = true;
            this.btnUpdateEnv.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // txtEnvName
            // 
            this.txtEnvName.Location = new System.Drawing.Point(71, 12);
            this.txtEnvName.Name = "txtEnvName";
            this.txtEnvName.ReadOnly = true;
            this.txtEnvName.Size = new System.Drawing.Size(382, 21);
            this.txtEnvName.TabIndex = 4;
            // 
            // txtEnvValue
            // 
            this.txtEnvValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnvValue.Location = new System.Drawing.Point(71, 45);
            this.txtEnvValue.Name = "txtEnvValue";
            this.txtEnvValue.Size = new System.Drawing.Size(512, 21);
            this.txtEnvValue.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(17, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddEnvFolder
            // 
            this.btnAddEnvFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEnvFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEnvFolder.Image")));
            this.btnAddEnvFolder.Location = new System.Drawing.Point(615, 43);
            this.btnAddEnvFolder.Name = "btnAddEnvFolder";
            this.btnAddEnvFolder.Size = new System.Drawing.Size(26, 24);
            this.btnAddEnvFolder.TabIndex = 8;
            this.btnAddEnvFolder.Tag = "ADD_FOLDER";
            this.btnAddEnvFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEnvFolder.UseVisualStyleBackColor = true;
            this.btnAddEnvFolder.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnAddEnvFile
            // 
            this.btnAddEnvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEnvFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEnvFile.Image")));
            this.btnAddEnvFile.Location = new System.Drawing.Point(589, 43);
            this.btnAddEnvFile.Name = "btnAddEnvFile";
            this.btnAddEnvFile.Size = new System.Drawing.Size(26, 24);
            this.btnAddEnvFile.TabIndex = 7;
            this.btnAddEnvFile.Tag = "ADD_FILE";
            this.btnAddEnvFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEnvFile.UseVisualStyleBackColor = true;
            this.btnAddEnvFile.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.logsListBox);
            this.tabPageLogs.ImageIndex = 5;
            this.tabPageLogs.Location = new System.Drawing.Point(4, 23);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(651, 177);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // logsListBox
            // 
            this.logsListBox.AutoScroll = true;
            this.logsListBox.AutoScrollMinSize = new System.Drawing.Size(643, 0);
            this.logsListBox.BackColor = System.Drawing.Color.White;
            this.logsListBox.DateFont = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsListBox.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsListBox.HeaderColor = System.Drawing.Color.Black;
            this.logsListBox.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.logsListBox.Location = new System.Drawing.Point(3, 3);
            this.logsListBox.Name = "logsListBox";
            this.logsListBox.SelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.logsListBox.SelectedIndex = -1;
            this.logsListBox.SelectedItem = null;
            this.logsListBox.SelectedTextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logsListBox.SeparatorColor = System.Drawing.Color.WhiteSmoke;
            this.logsListBox.Size = new System.Drawing.Size(645, 171);
            this.logsListBox.TabIndex = 5;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Interval = 500;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // tipUploader
            // 
            this.tipUploader.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // bgWorkerUnbind
            // 
            this.bgWorkerUnbind.WorkerReportsProgress = true;
            this.bgWorkerUnbind.WorkerSupportsCancellation = true;
            // 
            // imageList16
            // 
            this.imageList16.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList16.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 506);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripUploader);
            this.Controls.Add(this.statusStripUploader);
            this.Controls.Add(this.menuStripUploader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripUploader;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarsier VS Source Control Unbinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStripUploader.ResumeLayout(false);
            this.menuStripUploader.PerformLayout();
            this.statusStripUploader.ResumeLayout(false);
            this.statusStripUploader.PerformLayout();
            this.toolStripUploader.ResumeLayout(false);
            this.toolStripUploader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelProfileTop.ResumeLayout(false);
            this.panelProfileTop.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnvironment.ResumeLayout(false);
            this.tabPageBackup.ResumeLayout(false);
            this.panelFilesTop.ResumeLayout(false);
            this.panelFilesTop.PerformLayout();
            this.tabControlDetails.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVersionCompare)).EndInit();
            this.tabPageEnv.ResumeLayout(false);
            this.tabPageEnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUploader;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripUploader;
        private System.Windows.Forms.ToolStripMenuItem hideToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideStatusbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripUploader;
        private System.Windows.Forms.ToolStripButton btnAddFile;
        private System.Windows.Forms.ToolStripButton btnAddFolder;
        private System.Windows.Forms.ToolStripButton btnUnbind;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listViewEnvVars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProfileTop;
        private System.Windows.Forms.Panel panelFilesTop;
        private System.Windows.Forms.Label lblProfileCaption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDetails;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFile;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Label lblArchiveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Tarsier.UI.MessageListBox archivesListBox;
        private System.Windows.Forms.Timer tmrCheck;
        private Tarsier.UI.MessageListBox logsListBox;
        private System.Windows.Forms.Label lblArchiveDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArchiveCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageListInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label lblArchiveModified;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem profileExplorerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBoxVersionCompare;
        private System.Windows.Forms.ToolStripButton btnRefreshProfile;
        private System.Windows.Forms.ToolTip tipUploader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEnvironment;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceType;
        private System.Windows.Forms.ColumnHeader columnHeaderDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceCount;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.ComponentModel.BackgroundWorker bgWorkerUnbind;
        private System.Windows.Forms.ToolStripButton btnArchiveEnv;
        private System.Windows.Forms.ToolStripMenuItem menuItemArchiveEnv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripLabel lblInfoVersion;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.TabPage tabPageEnv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnvName;
        private System.Windows.Forms.TextBox txtEnvValue;
        private System.Windows.Forms.Button btnDeleteEnv;
        private System.Windows.Forms.Button btnUpdateEnv;
        private System.Windows.Forms.Button btnAddEnvFolder;
        private System.Windows.Forms.Button btnAddEnvFile;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ToolStripMenuItem newArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ridFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddFolder;
        private System.Windows.Forms.ToolStripMenuItem newValueToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ToolStripButton btnSetEnv;
    }
}

