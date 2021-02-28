using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaret
{
    public class Database
    {
        public SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=trade;integrated security=true");
        public void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }
        }
        public ConnectionState ConnectinState { get; private set; }
    }
}
