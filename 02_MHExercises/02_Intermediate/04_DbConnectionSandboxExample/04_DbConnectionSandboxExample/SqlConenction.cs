using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DbConnectionSandboxExample
{
    class SqlConenction : DbConnection
    {

        public SqlConenction(string ConnectionString, TimeSpan Timeout)
            :base(ConnectionString, Timeout) {}

        public override void OpenConnection()
        {
            Console.WriteLine("SQL connection is openned.");
        }

        public override void CloseConnection()
        {
            if (ConnectionString != "")
            {
                Console.WriteLine("SQL connection is closed");
            }
        }

        
    }
}
