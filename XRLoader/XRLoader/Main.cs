using XRLoader;
using XRLoader.ConsoleUtils;
using XRLoader.Utils;

namespace Loader
{
    internal class Main
    {
        public static void Load()
        {
            Consola.Alloc();
            Consola.ShowLogo();
            ConsoleLog.Log("Starting... ");
            Checkers.Main();
            ModManager.CheckFolder();
            ModManager.LoadMods();
        }
    }
}