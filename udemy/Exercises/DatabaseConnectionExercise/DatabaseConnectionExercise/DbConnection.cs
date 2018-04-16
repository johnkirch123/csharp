using System;

namespace DatabaseConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            try
            {
                this.ConnectionString = connectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}