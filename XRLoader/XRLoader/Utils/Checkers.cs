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
                ConsoleLog.Log("Still working on it sorry...");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();
            }
            else if (currentProcessName.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                UnityManager.LoadAllUnityDlls("Human_Data/Managed");
            }
            else
            {
                Console.WriteLine($"The current process is: {currentProcessName}");
            }
        }
    }
}
