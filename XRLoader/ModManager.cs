using System;
using System.IO;
using System.Reflection;
using XRLoader.ConsoleUtils;

namespace XRLoader
{
    internal class ModManager
    {
        public static string modFolderPath = @"XRMod";

        public static void CheckFolder()
        {
            ConsoleLog.Log("Checking mods...");
            if (!Directory.Exists(modFolderPath))
            {
                ConsoleLog.Log($"Mod folder does not exist. Creating '{modFolderPath}'...");
                Directory.CreateDirectory(modFolderPath);
                ConsoleLog.Log("Mod folder created.");
            }
        }
        public static void LoadMods()
        {
            string[] dllFiles = Directory.GetFiles(modFolderPath, "*.dll", SearchOption.AllDirectories);
            int dllCount = dllFiles.Length;
            ConsoleLog.Log($"{dllCount} mods found.");
            foreach (var dllFile in dllFiles)
            {
                try
                {
                    ConsoleLog.Log($"Attempting to load DLL:{dllFile}");

                    Assembly loadedAssembly = Assembly.LoadFrom(dllFile);

                    ConsoleLog.Log($"Successfully loaded:{Path.GetFileName(dllFile)}");

                    foreach (Type type in loadedAssembly.GetTypes())
                    {
                        if (type.IsClass)
                        {
                            object instance = Activator.CreateInstance(type);

                            MethodInfo method = type.GetMethod("XRModOnLoad");

                            if (method != null)
                            {
                                ConsoleLog.Log($"Invoking method '{method.Name}' in '{type.Name}'...");
                                method.Invoke(instance, null);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ConsoleLog.Error($"Failed to load {dllFile} or invoke method: {ex.Message}");
                }
            }
        }
    }
}