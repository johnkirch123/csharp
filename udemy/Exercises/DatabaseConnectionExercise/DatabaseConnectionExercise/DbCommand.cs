using System;

namespace DatabaseConnectionExercise
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _command;

        public DbCommand(DbConnection connection, string command)
        {
            try
            {
                this._connection = connection;
                this._command = command;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("No Database Connection...");
                throw;
            }
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine(_command);
            _connection.CloseConnection();
        }
    }
}