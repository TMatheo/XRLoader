using System;
using System.IO;
using System.Reflection;
using XRLoader.ConsoleUtils;

namespace XRLoader
{
    internal class UnityManager
    {
        public static void LoadAllUnityDlls(string unityDllPath)
        {
            if (!Directory.Exists(unityDllPath))
            {
                throw new DirectoryNotFoundException($"Directory not found: {unityDllPath}");
            }

            string[] dllFiles = Directory.GetFiles(unityDllPath, "*.dll");

            int loadedCount = 0;
            int failedCount = 0;

            foreach (string dllFile in dllFiles)
            {
                try
                {
                    Assembly loadedAssembly = Assembly.LoadFile(dllFile);
                    ConsoleLog.Log($"Successfully loaded: {Path.GetFileName(dllFile)}");
                    loadedCount++;
                }
                catch (Exception ex)
                {
                    ConsoleLog.Error($"Failed to load: {Path.GetFileName(dllFile)}. Error: {ex.Message}");
                    failedCount++;
                }
            }
            ConsoleLog.Log($"Total DLLs loaded: {loadedCount} | Total DLLs failed: {failedCount}");
        }
    }
}