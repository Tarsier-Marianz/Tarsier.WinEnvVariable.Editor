using Tarsier.WinEnvVariable.Editor.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.UI;
using System.Drawing;
using Tarsier.WinEnvVariable.Editor.Constants;

namespace Tarsier.WinEnvVariable.Editor.Controllers {
    public class EnvironmentStorage {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "environments";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public EnvironmentStorage(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void Reset() {
            ClearEnvironments();
            CreateTable(defaultTable);
        }
        public void CreateTable(string tableName) {
            defaultTable = tableName;
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Name", ColType.Text));
            table.AddColumn(new SQLiteColumn("Value", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            sqlite.CreateTable(table);
        }
        public bool ClearEnvironments() {
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

        public List<EnvVariable> GetEnvironments() {
            List<EnvVariable> envs = new List<EnvVariable>();
            DataTable dt = GetDataTable(string.Empty);
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    EnvVariable env = new EnvVariable() {
                        ID = dr["ID"].ToSafeInteger(),
                        Name = dr["Name"].ToSafeString(),
                        Value = dr["Value"].ToSafeString(),
                        Code = dr["Code"].ToSafeString(),
                    };
                    envs.Add(env);
                }
            }
            return envs;
        }
        public void Add(EnvVariable env) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = env.Name.RemoveNonAlphaNumeric().ToLower();

            data.Add("Name", env.Name);
            data.Add("Value", env.Value);
            data.Add("Code", code);
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

        public EnvVariable GetProfile(string name) {
            if(string.IsNullOrEmpty(name)) {
                throw new ArgumentNullException("name");
            }
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_WHERE_LIMIT1, defaultTable, string.Format("Name ='{0}'", name)));
            if(dt != null) {
                if(dt.Rows.Count > 0) {
                    foreach(DataRow dr in dt.Rows) {
                        return new EnvVariable() {
                            ID = dr["ID"].ToSafeInteger(),
                            Name = dr["Name"].ToSafeString(),
                            Value = dr["Value"].ToSafeString(),
                            Code = dr["Code"].ToSafeString(),
                        };
                    }
                }
            }
            return null;
        }

        public void SetTemporaryEnvironment(List<EnvVariable> envs) {
            if(envs.Count > 0) {
                Reset();
                foreach(EnvVariable e in envs) {
                    Add(e);
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
            List<EnvVariable> envs = GetEnvironments();
            if(envs.Count > 0) {
                foreach(EnvVariable e in envs) {
                    ListViewItem item = new ListViewItem(e.ID.ToSafeString(),0);
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(e.Name);
                    item.SubItems.Add(e.Value);
                    item.SubItems[1].ForeColor = WinDesign.MainColor;
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

    }
}