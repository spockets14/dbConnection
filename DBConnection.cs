using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DBConnection
{
    public partial class GetAConnection : IDisposable
    {
        string dbConnectionString = @"Data Source=database.db;version=3;";
        //public SQLiteConnection getDBConnection()
        public SQLiteConnection getDBConnection()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            sqliteCon.Open();
            return sqliteCon;
        }
    }
}
