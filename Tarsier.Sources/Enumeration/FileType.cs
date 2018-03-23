using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.Sources.Enumeration {
    public enum FileType {
        Unknown = -1,
        Solution = 0,
        CsProj = 1,
        VbProj = 2,
        VsSource = 3
    }
}