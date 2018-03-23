using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Extensions;
using Tarsier.Config;
using System.Data;
using Tarsier.WinEnvVariable.Editor.Models;
using System.Drawing;

namespace Tarsier.WinEnvVariable.Editor.Controllers {
    public class RidSources {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "ridfiles";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public RidSources(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }
        public void SetProfile(string profileName) {
            defaultTable = profileName.RemoveNonAlphaNumeric().ToLower();
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName.RemoveNonAlphaNumeric().ToLower();
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Name", ColType.Text));
            table.AddColumn(new SQLiteColumn("Type", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            sqlite.CreateTable(table);
        }

        public bool ClearCommands() {
            try {
                if(sqlite.IsTableExist(defaultTable)) {
                    sqlite.DropTable(defaultTable);
                    return true;
                }
            } catch {
            }
            return false;

        }
        public DataTable GetDataTable(bool orderDesc) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            if(orderDesc) {
                return sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));
            }
            return sqlite.GetDataTable(defaultTable);
        }
        
        public void Add(RidSource rid) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = (defaultTable + rid.Name + rid.Type).RemoveNonAlphaNumeric().ToLower();

            data.Add("Name", rid.Name);
            data.Add("Type", rid.Type);
            data.Add("Code", code);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }

        public void Delete(string code) {
            sqlite.Delete(defaultTable, string.Format("Code ='{0}'", code));
        }

        public List<RidSource> GetSources() {
            DataTable dt =sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));
            List<RidSource> srcs = new List<RidSource>();
            if(dt!=null) {
                foreach(DataRow dr in dt.Rows) {
                    RidSource cmd = new RidSource() {
                        ID = dr["ID"].ToSafeInteger(),
                        Name = dr["Name"].ToSafeString(),
                        Type = dr["Type"].ToSafeString(),
                        Code = dr["Code"].ToSafeString()
                    };
                    srcs.Add(cmd);
                }
            }
            return srcs;
        }

        public void Initialize(ListView list) {
            List<RidSource> sources = GetSources();
            if(sources.Count > 0) {
                list.Items.Clear();
                foreach(RidSource s in sources) {
                    int i = s.Type.Equals("Extension") ? 7 : 8;
                    ListViewItem item = new ListViewItem(s.Name, i);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(s.Type);
                    item.SubItems[1].ForeColor = Color.Gray;
                    if(list.InvokeRequired) {
                        list.Invoke((MethodInvoker)delegate () {
                            list.Items.Add(item);
                        });
                    } else {
                        list.Items.Add(item);
                    }
                }
            }
        }
    }
}
