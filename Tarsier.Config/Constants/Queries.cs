using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.Config {
    public class Queries {
        public const string SELECT_TABLE = "SELECT * FROM {0}";
        public const string SELECT_TABLE_WHERE = "SELECT * FROM {0} WHERE {1} ";
        public const string SELECT_TABLE_ASC = "SELECT * FROM {0} ORDER BY {1} ASC";
        public const string SELECT_TABLE_DESC = "SELECT * FROM {0} ORDER BY {1} DESC";
        public const string SELECT_TABLE_WHERE_LIMIT1 = "SELECT * FROM {0} WHERE {1} ORDER BY id DESC, ID LIMIT 1";
        public const string SELECT_EXCEL = "Select * from [{0}$]";
    }
}