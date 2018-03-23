using Tarsier.WinEnvVariable.Editor.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tarsier.Config;
using Tarsier.UI;

namespace Tarsier.WinEnvVariable.Editor.Controllers {
    public class Logs {
        private SQLiteHelper sqliteHelper;
        private SQLiteTable table;
        private string defaultTable = "logs";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Logs(string filename) {
            sqliteHelper = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName;
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("Details", ColType.DateTime));
            table.AddColumn(new SQLiteColumn("Description", ColType.Text));
            table.AddColumn(new SQLiteColumn("Type", ColType.Integer));
            table.AddColumn(new SQLiteColumn("Category", ColType.Text));
            table.AddColumn(new SQLiteColumn("Method", ColType.Text));
            sqliteHelper.CreateTable(table);
        }
        public bool ClearLogs() {
            try {
                if(sqliteHelper.IsTableExist(defaultTable)) {
                    sqliteHelper.DropTable(defaultTable);
                    return true;
                }
            } catch {
            }
            return false;

        }
        public void Add(string description, string category, string method, ParseMessageType type) {
            Dictionary<string, object> valueList = new Dictionary<string, object>();
            valueList.Add("Details", DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss"));
            valueList.Add("Description", description);
            valueList.Add("Method", method);
            valueList.Add("Category", category);
            valueList.Add("Type", type);
            sqliteHelper.Insert(table.GetCurrentTable, valueList);
            if(ListBox != null) {
                Initialize(ListBox);
            }

        }
        public DataTable GetDataTable(string filter) {
            if(String.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            if(!String.IsNullOrEmpty(filter)) {
                string sql = string.Format(Queries.SELECT_TABLE_WHERE, defaultTable, string.Format("Category='{0}'", filter));
                return sqliteHelper.Select(sql);
            }
            return sqliteHelper.GetDataTable(defaultTable);
        }

        public List<Log> GetLogs(string filter) {
            List<Log> logs = new List<Log>();
            DataTable dt = GetDataTable(filter);
            if(dt != null) {
                foreach(DataRow dr in dt.Rows) {
                    Log log = new Log() {
                        Description = dr["Description"].ToString(),
                        Category = dr["Category"].ToString(),
                        Method = dr["Method"].ToString(),
                        Details = dr["Details"].ToString(),
                        Type = Convert.ToInt32(dr["Type"])
                    };
                    logs.Add(log);
                }
            }
            return logs;
        }

        public void ClearAllLog() {
            sqliteHelper.DropTable(defaultTable);
            CreateTable(defaultTable);
        }

        public MessageListBox ListBox { get; set; }

        public void Initialize(MessageListBox list) {
            ListBox = list;
            if(list != null) {
                list.Items.Clear();
                List<Log> logs = GetLogs(string.Empty);
                if(logs.Count > 0) {
                    int i = 0;
                    foreach(Log p in logs) {
                        list.Items.Add(new ParseMessageEventArgs((ParseMessageType)p.Type, p.Method, p.Description, "logs" + i, string.Empty));
                        i++;
                    }
                }
                list.Invalidate();
            }
        }
    }
}