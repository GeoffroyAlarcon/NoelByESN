using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Context
{
    public class MySQLConnector : IDisposable
    {
        public MySQLConnector(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection Connection { get; set; }
        public void Dispose()
        {
        }
    }
}
