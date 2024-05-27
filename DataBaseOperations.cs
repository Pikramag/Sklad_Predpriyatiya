using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Sklad_Predpriyatiya
{
    internal class DataBaseOperations
    {
        private string _ConnectionString;
        private string _RegexPattern = "[^0-9]";

        public DataBaseOperations(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public string GetConnectionString()
        {
            return _ConnectionString;
        }

        public DataTable LoadTable(string sqlQuery)
        {
            DataTable table = null;
            using (SQLiteConnection sqlConnection = new SQLiteConnection(_ConnectionString))
            {
                sqlConnection.Open();
                SQLiteCommand command = new SQLiteCommand(sqlQuery, sqlConnection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                sqlConnection.Close();
            }
            return table;
        }

        public void ExecuteOperation(string _SqlQuery)
        {
            using (SQLiteConnection sqlConnection = new SQLiteConnection(_ConnectionString))
            {
                sqlConnection.Open();
                SQLiteCommand command = new SQLiteCommand(_SqlQuery, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public string GenerateDeleteRequest(string TableName, DataGridView _DataGridView)
        {
            string _Result = $"DELETE FROM {TableName} WHERE ";
            foreach (DataGridViewRow row in _DataGridView.SelectedRows)
            {
                foreach (DataGridViewColumn column in _DataGridView.Columns)
                {
                    if (Regex.Matches(row.Cells[column.Index].Value.ToString(), _RegexPattern, RegexOptions.IgnoreCase).Count > 0)
                    {
                        _Result += $"{column.Name}='{row.Cells[column.Index].Value}' AND ";
                    }
                    else
                    {
                        _Result += $"{column.Name}={row.Cells[column.Index].Value} AND ";
                    }
                }
                _Result = _Result.Substring(0, _Result.Length - 5);
                _Result += ";";
            }
            return _Result;
        }

        public string GenerateInsertRequest(string TableName, List<string> _Columns, List<TextBox> _TextBoxes)
        {
            string _Result = $"INSERT INTO {TableName} (";
            foreach (string columnName in _Columns)
            {
                _Result += columnName + ", ";
            }
            _Result = _Result.Substring(0, _Result.Length - 2);
            _Result += ") VALUES (";
            foreach (TextBox box in _TextBoxes)
            {
                if (Regex.Matches(box.Text, "[^0-9]", RegexOptions.IgnoreCase).Count > 0)
                    _Result += $"\'{box.Text}\', ";
                else
                    _Result += $"{box.Text}, ";
            }
            _Result = _Result.Substring(0, _Result.Length - 2);
            _Result += ");";
            return _Result;
        }
    }
}
