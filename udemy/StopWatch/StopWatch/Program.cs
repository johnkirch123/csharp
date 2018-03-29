using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatchRun();
        }

        private static void StopWatchRun()
        {
            do
            {
                Console.WriteLine("Please type start to start the clock, stop to end it, and quit to end the program");
                var value = Console.ReadLine();

                if (value == "start")
                {
                    StopWatch.Start(DateTime.Now);
                }
                else if (value == "stop")
                {
                    StopWatch.End(DateTime.Now);
                    Console.WriteLine("Start time: " + StopWatch.StartTime + " End time: " + StopWatch.EndTime);
                    Console.WriteLine("Elapsed time was " + StopWatch.TimeSpan);
                }
                else if (value == "quit") break;
                else
                {
                    Console.WriteLine("Please enter a valid value");
                }

            } while (true);
        }
    }
}
