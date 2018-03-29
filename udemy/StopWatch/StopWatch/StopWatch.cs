using System;

namespace StopWatch
{
    public class StopWatch
    {
        public static DateTime StartTime { get; private set; }
        public static DateTime EndTime { get; private set; }
        public static TimeSpan TimeSpan { get; private set; }
        private static bool _isRunning = false;

        public static void Start(DateTime time)
        {
            if (!_isRunning)
            {
                StartTime = time;
                _isRunning = true;
            }
            else
            {
                Console.WriteLine("The stop watch is already running.");
            }
        }

        public static void End(DateTime time)
        {
            if (_isRunning)
            {
                TimeSpan = time - StartTime;
                EndTime = time;
                _isRunning = false;
            }
            else
            {
                Console.WriteLine("You have already stopped the watch.");
            }
            
        }
    }
}