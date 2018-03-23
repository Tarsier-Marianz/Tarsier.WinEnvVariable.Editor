using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Tarsier.Sources {
    public class AsyncSourceAnalyzer : BackgroundWorker {
        private SourceControlAnalyzer _controlAnalyzer;
        private Exception _error = null;
        private string _directory = string.Empty;
        private int _totalFiles = 0;
        private int _entryIndex = 0;
        private bool _scanSubFolder = true;
        public AsyncSourceAnalyzer() {
            _controlAnalyzer = new SourceControlAnalyzer();
            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;
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
            this.RunWorkerAsync();
        }
        protected override void OnDoWork(DoWorkEventArgs e) {
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
                    if(this != null && this.CancellationPending) {
                        e.Cancel = true;
                        break;
                    }
                    this.ReportProgress(progress, info);
                    progress++;
                }
            }
        }
    }
}
