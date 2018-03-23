using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tarsier.Sources.Enumeration;
using Tarsier.Sources.Events;

namespace Tarsier.Sources {
    public class SourceAnalyzer : IDisposable {
        private Object thisLock = new Object(); //Locking object.
        private ThreadStart _threadStart;
        private Thread _thread;
        private SynchronizationContext _synchronizationContext;
        private AutoResetEvent _autoEvent;

        private SourceControlAnalyzer _controlAnalyzer;
        private List<FileEntry> _fileEntries;
        private string _directory = string.Empty;
        private int _totalFiles = 0;
        private bool _scanSubFolder = true;
        private bool _disposed;

        public event EventHandler<AnalyzeProgress> Progress;
        public event EventHandler<FileEntryChanged> FileEntryAdded;
        public event EventHandler<AnalyzeCompleted> Completed;

        public int TotalFiles {
            get {
                return _totalFiles;
            }
        }

        public bool ScanSubFolder {
            get { return _scanSubFolder; }
            set { _scanSubFolder = value; }
        }
        public SourceAnalyzer()
             : base() {
            _autoEvent = new AutoResetEvent(false);
            _directory = string.Empty;
        }
        public SourceAnalyzer(string directory) {
            _directory = directory;
            _autoEvent = new AutoResetEvent(false);
        }

        public void AnalyzeFiles(string directory, bool scanSubFolder) {
            _directory = directory;
            _scanSubFolder = scanSubFolder;
            _controlAnalyzer = new SourceControlAnalyzer();
            _fileEntries = new List<FileEntry>();
            _synchronizationContext = WindowsFormsSynchronizationContext.Current;
            _threadStart = new ThreadStart(ScanFiles);
            _thread = new Thread(_threadStart);
            _thread.Start();
        }

        private void ScanFiles() {
            lock(thisLock) {
                _autoEvent.Reset();
                AnalyzeResult result = AnalyzeResult.Success;
                Exception error = null;
                try {
                    if(string.IsNullOrEmpty(_directory)) {
                        throw new ArgumentNullException(_directory);
                    }
                    if(!Directory.Exists(_directory)) {
                        throw new FileNotFoundException();
                    }
                    string[] _files;
                    if(_scanSubFolder) {
                        _files = Directory.GetFiles(_directory, "*.*", SearchOption.AllDirectories);
                    } else {
                        _files = Directory.GetFiles(_directory, "*.*");
                    }
                    _totalFiles = _files.Length;
                    if(_files.Length > 0) {
                        int progress = 0;
                        int entryIndex = 0;
                        foreach(string file in _files) {
                            FileInfo info = new FileInfo(file);
                            if(_autoEvent.WaitOne(0, false)) {
                                result = AnalyzeResult.Cancel;
                                break;

                            } else {
                                if(Progress != null) {
                                    AnalyzeProgress ap = new AnalyzeProgress(progress, info);
                                    Progress(this, ap);
                                   // _synchronizationContext.Post((o) => Progress(this, ap), null);
                                }
                                FileEntry entry = _controlAnalyzer.ValidateSource(info);
                                if(entry != null) {
                                    if(FileEntryAdded != null) {
                                        FileEntryChanged fec = new FileEntryChanged(entryIndex, entry);
                                        FileEntryAdded(this, fec);
                                       // _synchronizationContext.Post((o) => FileEntryAdded(this, fec), null);
                                    }
                                }
                            }
                            progress++;
                        }
                    }
                } catch(Exception ex) {
                    result = AnalyzeResult.Error;
                    error = ex;
                } finally {

                }
                if(Completed != null) {
                    AnalyzeCompleted ac = new AnalyzeCompleted(result, error);
                    Completed(this, ac);
                }
            }
        }
        public void Abort() {
            _autoEvent.Set();
        }


        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing) {
            if(!_disposed) {
                if(disposing) {
                    _autoEvent.Close();
                }
            }
            _disposed = true;
        }
    }
}