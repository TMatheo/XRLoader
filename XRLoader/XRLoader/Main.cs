using XRLoader;
using XRLoader.ConsoleUtils;

namespace Loader
{
    internal class Main
    {
        public static void Load()
        {
            Consola.Alloc();
            Consola.ShowLogo();
            ConsoleLog.Log("Starting... ");
            //UnityManager.LoadAllUnityDlls("Human_Data\\Managed");
            ModManager.CheckFolder();
            ModManager.LoadMods();
        }
    }
}