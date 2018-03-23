using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor.Models {
    public class History {
        public int ID { get; set; }
        public int SourceCount { get; set; }
        public string SourceType { get; set; }
        public string Details { get; set; }
        public string Code { get; set; }
    }
}
