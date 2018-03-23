using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tarsier.Sources.Events {
   public class AnalyzeProgress: EventArgs {
        private readonly int progressPercentage;
        private readonly FileInfo fileInfo;

        public AnalyzeProgress(int progressPercentage, FileInfo fileInfo) {
            this.progressPercentage = progressPercentage;
            this.fileInfo = fileInfo;
        }

      
        public int ProgressPercentage {
            get { return progressPercentage; }
        }
        
        public FileInfo File {
            get { return fileInfo; }
        }
    }
}
