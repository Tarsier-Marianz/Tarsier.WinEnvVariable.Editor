using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tarsier.Sources.Events {
   public class FileEntryChanged : EventArgs {
        private readonly int index;
        private readonly FileEntry entry;

        public FileEntryChanged(int index, FileEntry entry) {
            this.index = index;
            this.entry = entry;
        }


        public int Index {
            get { return index; }
        }

        public FileEntry Entry {
            get { return entry; }
        }
    }
}
