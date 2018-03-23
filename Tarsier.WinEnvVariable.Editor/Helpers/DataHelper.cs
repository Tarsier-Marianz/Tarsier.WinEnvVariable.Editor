using System;
using System.Data;
using System.Windows.Forms;
using Tarsier.Extensions;

namespace Tarsier.WinEnvVariable.Editor.Helpers {
    public class DataHelper {

        public static void ShowData(ListView lv, DataTable table, bool withIcon) {
            try {
                int[] widths = new int[] { 40, 120, 80, 60, 200 };
                lv.BeginUpdate();
                lv.Clear();
                for(int i = 0; i <= table.Columns.Count - 1; i++) {
                    string columnname = table.Columns[i].ColumnName;
                    int imgIndex = (columnname.Equals("Status")) ? 9 : 100;
                    lv.Columns.Add(i + columnname.RemoveNonAlphaNumeric(), columnname, widths[i], HorizontalAlignment.Left, imgIndex);
                }
                int rowIndex = 0;
                int columnIndex = 2;
                foreach(DataRow dataRow in table.Rows) {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = dataRow[0].ToString();
                    string status = dataRow[columnIndex].ToString();
                    for(int i = 1; i <= table.Columns.Count - 1; i++) {
                        if(dataRow.RowState != DataRowState.Deleted) {
                            lvItem.SubItems.Add(dataRow[i].ToString());
                        }
                    }
                    if(withIcon) {
                        if(status.Equals("REGISTERED")) {
                            lvItem.ImageIndex = 6;
                        } else if(status.Equals("UNREGISTERED")) {
                            lvItem.ImageIndex = 7;
                        } else if(status.Equals("ERROR")) {
                            lvItem.ImageIndex = 8;
                        } else {
                            lvItem.ImageIndex = 9;
                        }
                    }
                    lv.BeginUpdate();
                    lv.Items.Add(lvItem);
                    lv.EndUpdate();
                }
                lv.EndUpdate();
            } catch(Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}