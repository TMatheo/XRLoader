using System;
using System.IO;
using System.Runtime.InteropServices;

namespace XRLoader.ConsoleUtils
{
    internal class Consola
    {
        public static string LoaderVersion = "0.0.1";
       
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        public static void Alloc()
        {
            AllocConsole();
            TextWriter writer = new StreamWriter(System.Console.OpenStandardOutput()) { AutoFlush = true };
            System.Console.SetOut(writer);
            System.Console.SetError(writer);
            System.Console.CursorVisible = false;
            System.Console.Title = "XRLoader | V"+LoaderVersion;
        }
        static ConsoleColor GetGradientColor(ConsoleColor[] colors, double t)
        {
            int colorIndex = (int)(t * (colors.Length - 1));
            return colors[colorIndex];
        }
        public static void ShowLogo()
        {
            string text = " __   _______  _                     _           \r\n \\ \\ / /  __ \\| |                   | |          \r\n  \\ V /| |__) | |     ___   __ _  __| | ___ _ __ \r\n   > < |  _  /| |    / _ \\ / _` |/ _` |/ _ \\ '__|\r\n  / . \\| | \\ \\| |___| (_) | (_| | (_| |  __/ |   \r\n /_/ \\_\\_|  \\_\\______\\___/ \\__,_|\\__,_|\\___|_|   \r\n                                                 \r\n                                                 \n";
            int steps = text.Length;
            ConsoleColor[] gradientColors = 
        {
            ConsoleColor.Red,
            ConsoleColor.DarkRed,
            ConsoleColor.Yellow,
            ConsoleColor.DarkYellow,
            ConsoleColor.Green,
            ConsoleColor.DarkGreen,
            ConsoleColor.Gray,
            ConsoleColor.DarkGray,
            ConsoleColor.Cyan,
            ConsoleColor.DarkCyan,
            ConsoleColor.Blue,
            ConsoleColor.DarkBlue,
            ConsoleColor.Magenta,
            ConsoleColor.DarkMagenta
        };

            for (int i = 0; i < text.Length; i++)
            {
                double t = (double)i / (steps - 1);

                Console.ForegroundColor = GetGradientColor(gradientColors, t);

                Console.Write(text[i]);
            }
            ConsoleLog.Log("Wolecome to XRLoader.");
            Console.ResetColor();
        }
    }
}