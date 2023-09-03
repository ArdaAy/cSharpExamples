using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DbConnectionSandboxExample
{
    class DbCommand
    {
        private DbConnection _dbConnection;
        private string _command;

        public DbCommand(DbConnection dbConenction, string command)
        {
            _dbConnection = dbConenction;
            _command = command;
        }

        public void Execute()
        {
            if(_dbConnection.ConnectionString == "")
                Console.WriteLine("Connection string of DB is empty.");
            else if(_command == "")
                Console.WriteLine("Command string is empty.");
            else
            {
                _dbConnection.OpenConnection();
                Console.WriteLine("The below command is executing.");
                Console.WriteLine(_command);
                _dbConnection.CloseConnection();
                Console.WriteLine("Execution is completed.");
            }

            

        }
    }
}
