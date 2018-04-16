using System;

namespace DatabaseConnectionExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Sql Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Sql Connection");
        }
    }
}