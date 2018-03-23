using Tarsier.WinEnvVariable.Editor.Constants;
using Tarsier.WinEnvVariable.Editor.Controllers;
using Tarsier.WinEnvVariable.Editor.Enums;
using Tarsier.WinEnvVariable.Editor.Forms;
using Tarsier.WinEnvVariable.Editor.Helpers;
using Tarsier.WinEnvVariable.Editor.Models;
using Tarsier.WinEnvVariable.Editor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tarsier.Extensions;
using Tarsier.Regedit;
using Tarsier.UI;
using Tarsier.UI.Icons;
using Tarsier.Sources;
using Tarsier.Sources.Enumeration;
using Tarsier.Sources.Events;
using System.Collections;
using System.Security.Principal;

namespace Tarsier.WinEnvVariable.Editor {
    public partial class MainWindow : Form {
        private EnvironmentVariables _envVariables;
        private IconListManager _iconListManager;
        private EnvironmentStorage _envStorage;
        private Archives _archives;
        private Logs _logs;
        private Archive _selectedArchive = null;
        private AddFile _loadFile = AddFile.FILES;
        private string _computerName = string.Empty;
        private string _archiveTable = string.Empty;
        private string _archiveName = string.Empty;
        private string _intialDirectory = string.Empty;
        private bool _isLoading = false;

        private List<EnvVariable> _listEnvVars;
        public MainWindow() {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = true;
            Text = new AppInfo().AssemblyTitle;
        }

        #region -Private Methods -

        private void InitSettings() {
            FileHelper.CheckAssociation();
            _iconListManager = new IconListManager(imageList16, IconReader.IconSize.Small);
            _intialDirectory = RegConfig.Get<string>("InitialDirectory");

            toolStripUploader.Visible = hideToolbarToolStripMenuItem.Checked = RegConfig.Get<bool>("Toolbar");
            statusStripUploader.Visible = hideStatusbarToolStripMenuItem.Checked = RegConfig.Get<bool>("Statusbar");
            splitContainer2.Panel2Collapsed = !(logsToolStripMenuItem.Checked = RegConfig.Get<bool>("Logs&Details"));
            splitContainer1.Panel1Collapsed = !(profileExplorerToolStripMenuItem.Checked = RegConfig.Get<bool>("ProfileExplorer"));
        }
        private void InitWorkspace() {
            _archives = new Archives(Database.ARCHIVES);
            _envStorage = new EnvironmentStorage(Database.ENVIRONMENTS);
            _logs = new Logs(Database.ENVIRONMENTS);
            _archives.Initialize(archivesListBox);
            _logs.Initialize(logsListBox);
        }
        private void InitEnvironmentVariables() {
            if(!bgWorker.IsBusy) {
                _listEnvVars = new List<EnvVariable>();
                _envStorage.Reset();
                listViewEnvVars.Items.Clear();
                _isLoading =
                progressBar.Visible = true;
                lblStatus.Text = "Initializing...";
                bgWorker.RunWorkerAsync();
            }
        }

        private void Action(string tag) {
            switch(tag) {
                case "NEW_PROF":
                    //NewProfile();
                    break;
                case "CREATE_ENV":
                    using(NewEnvForm env = new NewEnvForm()) {
                        if(env.ShowDialog().Equals(DialogResult.OK)) {
                            // Check if exist name

                            if(_envVariables.SetEnvironmentVariable(env.EnvName, env.EnvValue)) {
                                using(RestartForm r = new RestartForm(env.EnvName, tag)) {
                                    if(r.ShowDialog().Equals(DialogResult.OK)) {
                                        Application.Restart();
                                    }else {
                                        InitEnvironmentVariables();
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "ENV_UPDATE":
                    DialogResult resu = MessageBox.Show(string.Format("Are you sure you want to update {0} in environment variable?", txtEnvName.Text), "Update Environment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(resu.Equals(DialogResult.Yes)) {

                        if(_envVariables.SetEnvironmentVariable(txtEnvName.Text, txtEnvValue.Text)) {
                            using(RestartForm r = new RestartForm(txtEnvName.Text, tag)) {
                                if(r.ShowDialog().Equals(DialogResult.OK)) {
                                    InitEnvironmentVariables();
                                }
                            }
                        }
                    }
                    break;
                case "ENV_DELETE":
                    DialogResult resd = MessageBox.Show(string.Format("Are you sure you want to delete {0} in environment variable?", txtEnvName.Text), "Delete Environment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(resd.Equals(DialogResult.Yes)) {
                        if(_envVariables.DeleteEnvironmentVariable(txtEnvName.Text)) {
                            using(RestartForm r = new RestartForm(txtEnvName.Text, tag)) {
                                if(r.ShowDialog().Equals(DialogResult.OK)) {
                                    InitEnvironmentVariables();
                                }
                            }
                        }
                    }
                    break;
                case "FIND":
                    break;
                case "SAVE":
                    if(_isLoading) { return; }
                    using(NewArchive na = new NewArchive()) {
                        if(na.ShowDialog().Equals(DialogResult.OK)) {

                        }
                    }
                        break;
                case "ADD_FILE":
                    AddFiles(AddFile.FILES);
                    break;
                case "ADD_FOLDER":
                    AddFiles(AddFile.FOLDER);
                    break;
                case "REFRESH":
                    InitWorkspace();
                    break;
                case "SERVER_CONFIG":
                case "OPTIONS":
                    using(ConfigServerForm config = new ConfigServerForm(tag.Equals("SERVER_CONFIG") ? 1 : 0)) {
                        if(config.ShowDialog().Equals(DialogResult.OK)) {
                            InitSettings();
                        }
                    }
                    break;
                case "EXIT":
                    Close();
                    break;
                case "ABOUT":
                    using(AboutForm about = new AboutForm()) {
                        about.ShowDialog();
                    }
                    break;
                case "HELP":
                    using(HelpForm help = new HelpForm()) {
                        help.ShowDialog();
                    }
                    break;
                case "TOOLBAR":
                    RegConfig.Set<bool>("Toolbar", hideToolbarToolStripMenuItem.Checked);
                    toolStripUploader.Visible = hideToolbarToolStripMenuItem.Checked;
                    break;
                case "STATUSBAR":
                    RegConfig.Set<bool>("Statusbar", hideStatusbarToolStripMenuItem.Checked);
                    statusStripUploader.Visible = hideStatusbarToolStripMenuItem.Checked;
                    break;
                case "PROFILE_DETAILS":
                    break;
                case "PROFILE_EXPLORER":
                    RegConfig.Set<bool>("ProfileExplorer", profileExplorerToolStripMenuItem.Checked);
                    splitContainer1.Panel1Collapsed = !profileExplorerToolStripMenuItem.Checked;
                    break;
                case "LOGS":
                    RegConfig.Set<bool>("Logs&Details", logsToolStripMenuItem.Checked);
                    splitContainer2.Panel2Collapsed = !logsToolStripMenuItem.Checked;
                    break;
                case "CLEAR_WORKSPACE":
                    if(_archives != null) {
                        if(MessageBox.Show("Workspace will be deleted permanently!\nAre you sure you want to clear all workspace?", "Clear Workspace", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {

                            List<Archive> ws = _archives.GetProfiles();
                            if(ws.Count > 0) {
                                foreach(Archive w in ws) {

                                }
                            }
                            _archives.ClearWorkspaces();
                            InitWorkspace();
                        }
                    }
                    break;
                case "CLEAR_LOGS":
                    if(_logs != null) {
                        if(MessageBox.Show("Logs will be deleted permanently!\nAre you sure you want to clear all logs?", "Clear Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {
                            _logs.ClearAllLog();
                            _logs.Initialize(logsListBox);
                        }
                    }
                    break;
                case "CLEAR_HISTORY":
                    if(_selectedArchive != null) {
                        if(MessageBox.Show("History will be deleted permanently!\nAre you sure you want to clear all history?", "Clear History", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {

                        }
                    }
                    break;
                case "SOURCE_EXT":
                case "SOURCE_FOLDER":

                    break;
                default:
                    break;
            }
        }

        private void NewProfile() {
            lblProfileCaption.Text = string.Empty;
            tabPageEnvironment.Text = "Environment\\" + Environment.UserName;
            tabPageBackup.Text = "Summary";
            lblStatus.Text = "Ready...";
            lblStatusFile.Text = string.Empty;
            progressBar.Visible = false;
            pBoxVersionCompare.Image = null;
            listViewEnvVars.Items.Clear();
            listViewHistory.Items.Clear();
            _selectedArchive = null;
            Elements.ClearProfileDetails(tabPageProfile);
        }
        private void SaveProfile() {
            if(listViewEnvVars.Items.Count > 0) {
                if(_selectedArchive == null) {
                    _selectedArchive = new Archive() {
                        Name = _archiveName,
                        Count = listViewEnvVars.Items.Count,
                        Comment = string.Empty
                    };
                }
                _archiveTable = _selectedArchive.Code;
                _archives.Add(_selectedArchive);
            }
        }
        private void AddFiles(AddFile file) {
            _loadFile = file;
            if(file == AddFile.FILES) {
                using(OpenFileDialog opd = new OpenFileDialog()) {
                    opd.Filter = Dialogs.GetFilters(Filters.ALL);
                    if(opd.ShowDialog().Equals(DialogResult.OK)) {
                        txtEnvValue.Text = opd.FileName;
                    }
                }
            } else {
                using(FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                    fbd.Description = Titles.FOLDER_BROWSER;
                    fbd.SelectedPath = _intialDirectory;
                    if(fbd.ShowDialog().Equals(DialogResult.OK)) {
                        txtEnvValue.Text = fbd.SelectedPath;
                    }
                }
            }
        }

        private void UpdateProgress(int value, bool maximum) {
            if(progressBar.GetCurrentParent().InvokeRequired) {
                progressBar.GetCurrentParent().Invoke((MethodInvoker)delegate () {
                    if(maximum) {
                        progressBar.Maximum = value;
                    } else {
                        progressBar.Value = value;
                    }
                });
            } else {
                if(maximum) {
                    progressBar.Maximum = value;
                } else {
                    progressBar.Value = value;
                }
            }
        }


        #endregion -Private Methods -

        #region - Control Events -
        private void UploadForm_Load(object sender, EventArgs e) {
            _envVariables = new EnvironmentVariables();
            NewProfile();
            InitSettings();
            InitWorkspace();
            InitEnvironmentVariables();
        }

        private void Buttons_Click(object sender, EventArgs e) {
            ToolStripButton tsbtn = sender as ToolStripButton;
            if(tsbtn != null) {
                if(tsbtn.Tag != null) {
                    Action(tsbtn.Tag.ToString());
                }
            } else {
                Button btn = sender as Button;
                if(btn != null) {
                    if(btn.Tag != null) {
                        Action(btn.Tag.ToString());
                    }
                }
            }
        }

        private void MenuItems_Click(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if(menu != null) {
                if(menu.Tag != null) {
                    Action(menu.Tag.ToString());
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            int index = 1;
            UpdateProgress(Environment.GetEnvironmentVariables().Count, true);
            foreach(DictionaryEntry de in Environment.GetEnvironmentVariables()) {
                EnvVariable env = new EnvVariable() { Name = de.Key.ToSafeString(), Value = de.Value.ToSafeString() };
                _listEnvVars.Add(env);
                _envStorage.Add(env);
                if(de.Key.ToSafeString().Equals("COMPUTERNAME")) {
                    _computerName = de.Value.ToSafeString();
                }
                bgWorker.ReportProgress(index, env);
                index++;
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if(e.ProgressPercentage <= progressBar.Maximum) {
                progressBar.Value = e.ProgressPercentage;
            }

            if(e.UserState != null) {
                EnvVariable env = e.UserState as EnvVariable;
                if(env != null) {
                    ListViewItem item = new ListViewItem(e.ProgressPercentage.ToSafeString(), 0);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(env.Name);
                    item.SubItems.Add(env.Value);
                    item.SubItems[0].ForeColor = Color.Gray;
                    item.SubItems[1].ForeColor = WinDesign.MainColor;
                    if(listViewEnvVars.InvokeRequired) {
                        listViewEnvVars.Invoke((MethodInvoker)delegate () {
                            listViewEnvVars.Items.Add(item);
                        });
                    } else {
                        listViewEnvVars.Items.Add(item);
                    }
                }
            }
            lblArchiveCount.Text = listViewEnvVars.Items.Count.ToSafeString();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            listViewEnvVars.Invalidate();
            tabPageEnvironment.Text = "Environment\\" + _computerName;
            lblArchiveName.Text = _computerName;
            lblProfileCaption.Text = _computerName;

            // _envStorage.SetTemporaryEnvironment(_listEnvVars);
            //SaveProfile();
            //InitWorkspace();

            //SetProfileDetails();
            lblStatus.Text = "Finished...";
            progressBar.Value = 0;
            progressBar.Visible = false;
            _isLoading = false;
            ToolBarMenusVisibility(true);
        }
        #endregion - Control Events -

        private void profileListBox_DoubleClick(object sender, EventArgs e) {
            if(archivesListBox.SelectedItemIndices.Count > 0) {
                ClearEnvDetails();
                if(archivesListBox.SelectedIndex < 0 || archivesListBox.SelectedItem == null) {
                    return;
                }
                if(!_isLoading) {
                    tabControlDetails.SelectedIndex = 0;
                    ParseMessageEventArgs item = archivesListBox.SelectedItem as ParseMessageEventArgs;
                    if(item != null) {
                        if(item.LineHeader.Contains("No archive")) { return; }

                        NewProfile();
                        _selectedArchive = _archives.GetProfile(item.LineHeader);
                        if(_selectedArchive != null) {
                            _archiveTable = _selectedArchive.Code;
                        }
                    } else {
                        _selectedArchive = null;
                    }
                }
            }
        }

        private void ToolBarMenusVisibility(bool state) {
            btnAddFile.Enabled = btnAddFolder.Enabled = btnUnbind.Enabled = menuItemAddFile.Enabled =
                menuItemAddFolder.Enabled = state;
        }
        private void tmrCheck_Tick(object sender, EventArgs e) {
            //ToolBarMenusVisibility(!_isLoading);
            btnArchiveEnv.Enabled = menuItemArchiveEnv.Enabled = (!_isLoading && listViewEnvVars.Items.Count > 0);
            btnAddEnvFile.Enabled = btnAddEnvFolder.Enabled =
                btnAddFile.Enabled = btnAddFolder.Enabled =
                menuItemAddFile.Enabled = menuItemAddFolder.Enabled =
                (txtEnvName.Text.Trim().Length > 0);
            menuItemAddFile.Enabled = menuItemAddFolder.Enabled = btnDeleteEnv.Enabled=  (txtEnvName.Text.Trim().Length > 0);
            btnUpdateEnv.Enabled = (txtEnvName.Text.Trim().Length > 0 && txtEnvValue.Text.Trim().Length > 0);
            btnSetEnv.Enabled = (_selectedArchive != null);
        }

        private void SetProfileDetails() {
            lblProfileCaption.Text = _selectedArchive.Name;
        }

        private void profileListBox_MouseDoubleClick(object sender, MouseEventArgs e) {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if(bgWorker.IsBusy) {
                bgWorker.CancelAsync();
                bgWorker.ProgressChanged -= new ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
                bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            }
            if(bgWorkerUnbind.IsBusy) {
                bgWorkerUnbind.CancelAsync();
                bgWorkerUnbind.ProgressChanged -= new ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
                bgWorkerUnbind.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            }
        }

        private void listViewEnvVars_SelectedIndexChanged(object sender, EventArgs e) {
            if(_isLoading) { return; }
            if(listViewEnvVars.SelectedItems.Count > 0) {
                ClearEnvDetails();
                tabControlDetails.SelectedIndex = 1;
                string id = listViewEnvVars.SelectedItems[0].SubItems[0].Text;
                string name = listViewEnvVars.SelectedItems[0].SubItems[1].Text;
                string value = listViewEnvVars.SelectedItems[0].SubItems[2].Text;
                txtEnvName.Text = name;
                txtEnvValue.Text = value;
            }
        }
        private void ClearEnvDetails() {
            txtEnvName.Text =
            txtEnvValue.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            labelSearch.Visible =
                txtSearch.Visible =
                btnSearch.Visible = (this.Width >= 500);
        }
        
    }
}