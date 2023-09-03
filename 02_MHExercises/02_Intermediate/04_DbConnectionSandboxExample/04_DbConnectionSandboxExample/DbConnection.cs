using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DbConnectionSandboxExample
{
    abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connText, TimeSpan timeout)
        {
            ConnectionString = connText;
            Timeout = timeout;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
