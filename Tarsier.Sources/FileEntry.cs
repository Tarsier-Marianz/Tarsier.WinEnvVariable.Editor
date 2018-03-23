using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Tarsier.Sources.Enumeration;

namespace Tarsier.Sources {
   public class FileEntry {
        public string Name { get; set; }
        public FileInfo Info { get; set; }
        public FileType Type { get; set; }
    }
}
