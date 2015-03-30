using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DBConnection
{
    public partial class GetAConnectionNow
    {
        public string getADBString()
        {
            string dbConnectionString = @"Data Source=database.db;version=3;";
            return dbConnectionString;
        }//public SQLiteConnection getDBConnection()
    }
}
