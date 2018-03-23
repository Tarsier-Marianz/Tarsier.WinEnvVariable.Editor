namespace Tarsier.Config {
    public class SQLiteTable {
        public string TableName = "";
        public SQLiteColumnList Columns = new SQLiteColumnList();

        public SQLiteTable() { }

        public SQLiteTable(string name) {
            TableName = name;
        }

        public void AddColumn(SQLiteColumn item) {
            Columns.Add(item);
        }
        public string GetCurrentTable {
            get { return this.TableName; }
        }

    }
}