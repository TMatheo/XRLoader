using System;
using System.Diagnostics;
using XRLoader.ConsoleUtils;

namespace XRLoader.Utils
{
    internal class Checkers
    {
        public static void Main()
        {
            string currentProcessName = Process.GetCurrentProcess().ProcessName;

            if (currentProcessName.Equals("AmongUs", StringComparison.OrdinalIgnoreCase))
            {
                ConsoleLog.Log("The current process is: AmongUs");
            }
            else if (currentProcessName.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                ConsoleLog.Log("The current process is: Human");
            }
            else
            {
                Console.WriteLine($"The current process is: {currentProcessName}");
            }
        }
    }
}
