using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor.Models {
    public class Archive {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public string LastDateModified { get; set; }
        public string Code { get; set; }
    }
}