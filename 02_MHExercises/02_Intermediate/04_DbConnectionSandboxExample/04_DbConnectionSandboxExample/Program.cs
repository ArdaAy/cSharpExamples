using System;

namespace _04_DbConnectionSandboxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var OracleConn = new OracleConnection("OracleConn", new TimeSpan());
            var SqlConn = new SqlConenction("SqlConn", new TimeSpan());

            var OracleCommand = new DbCommand(OracleConn, "OracleCommand");
            var SqlCommand = new DbCommand(SqlConn, "SqlCommand");

            OracleCommand.Execute();
            Console.WriteLine();
            SqlCommand.Execute();

        }
    }
}
