using Tarsier.WinEnvVariable.Editor.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.UI;

namespace Tarsier.WinEnvVariable.Editor.Controllers {
    public class Archives {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "archives";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Archives(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName;
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Name", ColType.Text));
            table.AddColumn(new SQLiteColumn("Value", ColType.Text));
            table.AddColumn(new SQLiteColumn("Count", ColType.Integer));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            table.AddColumn(new SQLiteColumn("Comment", ColType.Text));
            table.AddColumn(new SQLiteColumn("LastDateModified", ColType.Text));
            sqlite.CreateTable(table);
        }
        public bool ClearWorkspaces() {
            try {
                if(sqlite.IsTableExist(defaultTable)) {
                    sqlite.DropTable(defaultTable);
                    return true;
                }
            } catch {
            }
            return false;
        }
        public DataTable GetDataTable(string filter) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            return sqlite.GetDataTable(defaultTable);
        }

        public List<Archive> GetProfiles() {
            List<Archive> profs = new List<Archive>();
            DataTable dt = GetDataTable(string.Empty);
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    Archive pro = new Archive() {
                        ID = dr["ID"].ToSafeInteger(),
                        Name = dr["Name"].ToSafeString(),
                        Count = dr["Count"].ToSafeInteger(),
                        Comment = dr["Comment"].ToSafeString(),
                        LastDateModified = dr["LastDateModified"].ToSafeString()
                    };
                    profs.Add(pro);
                }
            }
            return profs;
        }
        public void Add(Archive pro) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = pro.Name.RemoveNonAlphaNumeric().ToLower();
             string dateUploaded = string.IsNullOrEmpty(pro.LastDateModified) ? DateTime.Now.ToShortDateString() : pro.LastDateModified;
            data.Add("Name", pro.Name);
            data.Add("Count", pro.Count);
            data.Add("Code", code);
            data.Add("Comment", pro.Comment);
            data.Add("LastDateUnbind", dateUploaded);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }
        public string GetCode(string name) {
            if(string.IsNullOrEmpty(name)) {
                return string.Empty;
            }
            return sqlite.GetColumnValue(defaultTable, "Code", string.Format("Name ='{0}'", name));
        }
        public Archive GetProfile(string name) {
            if(string.IsNullOrEmpty(name)) {
                throw new ArgumentNullException("name");
            }
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_WHERE_LIMIT1, defaultTable, string.Format("Name ='{0}'", name)));
            if(dt != null) {
                if(dt.Rows.Count > 0) {
                    foreach(DataRow dr in dt.Rows) {
                        return new Archive() {
                            ID = dr["ID"].ToSafeInteger(),
                            Name = dr["Name"].ToSafeString(),
                            Count = dr["Count"].ToSafeInteger(),
                            Comment = dr["Comment"].ToSafeString(),
                            LastDateModified = dr["LastDateModified"].ToSafeString()
                        };
                    }
                }
            }
            return null;
        }
        public void Initialize(ListBox list) {
            if(list != null) {
                list.Items.Clear();
                List<Archive> profs = GetProfiles();
                if(profs.Count > 0) {
                    foreach(Archive p in profs) {
                        list.Items.Add(p.Name);
                    }
                }
            }
        }
        public void Initialize(MessageListBox list) {
            if(list != null) {
                list.Items.Clear();
                List<Archive> profs = GetProfiles();
                if(profs.Count > 0) {
                    foreach(Archive p in profs) {
                        list.Items.Add(new ParseMessageEventArgs(ParseMessageType.Archive, p.Name, p.Comment, "archive" + p.ID, p.LastDateModified));
                    }
                } else {
                    list.Items.Add(new ParseMessageEventArgs(ParseMessageType.Info, "No archives found!", "Saved current environment variables to create archive.", "0", string.Empty));
                }
                list.Invalidate();
            }
        }
        
    }
}