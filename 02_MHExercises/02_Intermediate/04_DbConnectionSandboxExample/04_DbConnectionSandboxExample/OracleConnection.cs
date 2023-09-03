using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DbConnectionSandboxExample
{
    class OracleConnection : DbConnection
    {

        public OracleConnection(string ConnectionString, TimeSpan Timeout)
            :base(ConnectionString, Timeout) {}


        public override void OpenConnection()
        {
            if(ConnectionString != ""){
                Console.WriteLine("Oracle connection is openned.");
            }
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection is closed");
        }

        
    }
}
