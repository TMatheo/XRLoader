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

            if (currentProcessName.Equals("1v1_LOL", StringComparison.OrdinalIgnoreCase))
            {
                UnityManager.LoadAllUnityDlls("1v1_LOL_Data/Managed");
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
