using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor.Models {
    public class Log {
        public string Description { get; set; }
        public string Category { get; set; }
        public string Method { get; set; }
        public string Details { get; set; }
        public int Type { get; set; }
    }
}
