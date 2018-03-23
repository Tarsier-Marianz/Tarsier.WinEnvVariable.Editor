using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tarsier.Sources.Events {
   public class UnbindProgressEvents : EventArgs {
        private readonly bool success;
        private readonly FileEntry fileInfo;

        public UnbindProgressEvents(bool success, FileEntry fileInfo) {
            this.success = success;
            this.fileInfo = fileInfo;
        }

      
        public bool Success {
            get { return success; }
        }
        
        public FileEntry File {
            get { return fileInfo; }
        }
    }
}
