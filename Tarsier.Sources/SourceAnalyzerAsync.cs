using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using Tarsier.Sources.Enumeration;
using Tarsier.Sources.Events;

namespace Tarsier.Sources {
    public class SourceAnalyzerAsync {
        private SourceControlAnalyzer _controlAnalyzer;
        private BackgroundWorker _worker;
        private AnalyzeResult _result = AnalyzeResult.Success;
        private Exception _error = null;
        private string _directory = string.Empty;
        private int _totalFiles = 0;
        private int _entryIndex = 0;
        private bool _scanSubFolder = true;

        public int TotalFiles {
            get {
                return _totalFiles;
            }
        }
        public bool ScanSubFolder {
            get { return _scanSubFolder; }
            set { _scanSubFolder = value; }
        }

        public event EventHandler<AnalyzeProgress> Progress;
        public event EventHandler<FileEntryChanged> FileEntryAdded;
        public event EventHandler<AnalyzeCompleted> Completed;
        public SourceAnalyzerAsync() {
            _controlAnalyzer = new SourceControlAnalyzer();
            _worker = new BackgroundWorker();
            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += _worker_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            
        }

        public void AnalyzeFiles(string directory, bool scanSubFolder) {
            _directory = directory;
            _scanSubFolder = scanSubFolder;
            if(string.IsNullOrEmpty(_directory)) {
                throw new ArgumentNullException(_directory);
            }
            if(!Directory.Exists(_directory)) {
                throw new FileNotFoundException();
            }

            _worker.RunWorkerAsync();
        }

        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if(e.Cancelled) {
                _result = AnalyzeResult.Cancel;
            } else {
                if(e.Error != null) {
                    _result = AnalyzeResult.Error;
                }else {
                    _result = AnalyzeResult.Success;
                }
            }
        }

        private void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            FileInfo info = e.UserState as FileInfo;
            if(info != null) {
                if(Progress != null) {
                    AnalyzeProgress ap = new AnalyzeProgress(e.ProgressPercentage, info);
                    Progress(this, ap);
                    // _synchronizationContext.Post((o) => Progress(this, ap), null);
                }
                FileEntry entry = _controlAnalyzer.ValidateSource(info);
                if(entry != null) {
                    if(FileEntryAdded != null) {
                        FileEntryChanged fec = new FileEntryChanged(_entryIndex, entry);
                        FileEntryAdded(this, fec);
                        // _synchronizationContext.Post((o) => FileEntryAdded(this, fec), null);
                    }
                }
            }
        }
       
        private void _worker_DoWork(object sender, DoWorkEventArgs e) {
            
            string[] _files;
            if(_scanSubFolder) {
                _files = Directory.GetFiles(_directory, "*.*", SearchOption.AllDirectories);
            } else {
                _files = Directory.GetFiles(_directory, "*.*");
            }
            _totalFiles = _files.Length;
            if(_files.Length > 0) {
                int progress = 0;
                foreach(string file in _files) {
                    FileInfo info = new FileInfo(file);
                    if(_worker != null && _worker.CancellationPending) {
                        e.Cancel = true;
                        break;
                    }
                    _worker.ReportProgress(progress, info);
                    progress++;
                }
            }
        }
    }
}