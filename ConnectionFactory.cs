using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ApiTest
{
    public class ConnectionFactory
    {
        public  static MySqlConnection Create()
        {
            var connStr = "Server=localhost;Port=3306;Database=pashn_test;Uid=root;persistsecurityinfo=True;Pwd=abcd1234;";
            return new MySqlConnection(connStr);
        }
    }
}
