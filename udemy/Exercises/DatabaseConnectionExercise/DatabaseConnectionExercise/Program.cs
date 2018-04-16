using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand command = new DbCommand(new SqlConnection("SqlConnection"), "Add something to the database");
            command.Execute();
            Console.WriteLine("Operations Complete");
        }
    }
}
