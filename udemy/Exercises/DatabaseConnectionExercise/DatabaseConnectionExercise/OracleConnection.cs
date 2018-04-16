using System;

namespace DatabaseConnectionExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Connection");
        }
    }
}