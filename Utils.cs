using System;

namespace SimpleCalculator
{
    public static class Utils
    {
        // Log a message to the console with a timestamp
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}
