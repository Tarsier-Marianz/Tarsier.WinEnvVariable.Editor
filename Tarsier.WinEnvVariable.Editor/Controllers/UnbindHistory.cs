using Tarsier.WinEnvVariable.Editor.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.UI;
using Tarsier.Sources;
using Newtonsoft.Json.Linq;

namespace Tarsier.WinEnvVariable.Editor.Controllers {
    public class UnbindHistory {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "history";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public UnbindHistory(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName;
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("SourceCount", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            table.AddColumn(new SQLiteColumn("SourceType", ColType.Text));
            table.AddColumn(new SQLiteColumn("Details", ColType.Text));
            sqlite.CreateTable(table);
        }

        public DataTable GetDataTable(bool orderDesc) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            if(orderDesc) {
                return sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable,"ID"));
            }
            return sqlite.GetDataTable(defaultTable);
        }
        public bool ClearHistory(string table) {
            try {
                if(sqlite.IsTableExist(table)) {
                    sqlite.DropTable(table);
                    return true;
                }
            } catch {
            }
            return false;
        }
        public bool ClearHistory() {
           return ClearHistory(defaultTable);
        }
        public List<History> GetHistories() {
            List<History> profs = new List<History>();
            DataTable dt = GetDataTable(true);
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    History pro = new History() {
                        ID = dr["ID"].ToSafeInteger(),
                        SourceCount = dr["SourceCount"].ToSafeInteger(),
                        Code = dr["Code"].ToSafeString(),
                        SourceType = dr["SourceType"].ToSafeString(),
                        Details = dr["Details"].ToSafeString()
                    };
                    profs.Add(pro);
                }
            }
            return profs;
        }
        public void Add(History h) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            
            string details = string.IsNullOrEmpty(h.Details) ? DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt") : h.Details;
            string code=(h.SourceType + DateTime.Now.ToString("yyyyMMdd")).RemoveNonAlphaNumeric().ToLower();
            data.Add("SourceCount", h.SourceCount);
            data.Add("Code", code);
            data.Add("SourceType", h.SourceType);
            data.Add("Details", details);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }
        public void Add(SourceSummary summa) {
            if(summa != null) {
                JObject json = JObject.FromObject(summa);
                foreach(JProperty property in json.Properties()) {
                    History h = new History() {
                        SourceType = property.Name,
                        SourceCount = property.Value.ToSafeInteger(),
                        Details = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")
                    };
                    Add(h);
                }
            }
        }
      
        public void Initialize(ListView list, string table) {
            defaultTable = table.RemoveNonAlphaNumeric().ToLower();
            if(string.IsNullOrEmpty(defaultTable)) {
                return;
            }
            if(!sqlite.IsTableExist(defaultTable)) {
                CreateTable(defaultTable);
            }
            List<History> histories = GetHistories();
            if(histories.Count > 0) {
                foreach(History h in histories) {
                    ListViewItem item = new ListViewItem(h.SourceType, GeImageKey(h.SourceType.ToLower()));
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(h.SourceCount.ToSafeString());
                    item.SubItems.Add(h.Details);
                    item.SubItems[1].ForeColor = Color.DarkGreen;
                    item.SubItems[2].ForeColor = Color.Gray;
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

        private string GeImageKey(string source) {
            return string.Format("vs-{0}.png", source);
        }
    }
}
