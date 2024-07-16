using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqliteKepek.Model
{
    public class dBHelper
    {
        public DataSet DataSet { get; set; }
        private SQLiteDataAdapter dataAdapter;
        private SQLiteConnection connection;

        public dBHelper(string connectionString)
        {
            connection = new SQLiteConnection(connectionString);
            DataSet = new DataSet();
        }

        public bool Load(string commandText, string tableName)
        {
            try
            {
                dataAdapter = new SQLiteDataAdapter(commandText, connection);
                dataAdapter.Fill(DataSet, tableName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
                dataAdapter.Update(DataSet);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
