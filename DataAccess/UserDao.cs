using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace DataAccess
{
    public class UserDao: MySqlConnection
    {
        public bool login(string user, string password)
        {
            using(var cn = GetConnection())
            {
                cn.Open();
            }
        }
    }
}
