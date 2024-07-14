using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace sqliteProjekt.Class
{
    internal class dBFunctions
    {
        public static string ConnectionStringSQLite
        {
            get
            {
                string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\Contact.s3db";
                string connectionString = @"Data Source=" + Path.GetFullPath(database);
                return connectionString;
            }
        }
    }
}
