using System;

namespace XRLoader.ConsoleUtils
{
    internal class ConsoleLog
    {
        internal static void Log(string MessageToLog, ConsoleColor NameColor = ConsoleColor.White, ConsoleColor TextColor = ConsoleColor.White, ConsoleColor MidColor = ConsoleColor.Green)
        {
            string formattedDateTime = DateTime.Now.ToString("[HH:mm:ss:ml]:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(formattedDateTime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("XRLoader");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]:");
            Console.ForegroundColor = MidColor;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MessageToLog);
            Console.ResetColor();
        }
        internal static void Error(string MessageToLog, ConsoleColor NameColor = ConsoleColor.White, ConsoleColor TextColor = ConsoleColor.White, ConsoleColor MidColor = ConsoleColor.Red)
        {
            string formattedDateTime = DateTime.Now.ToString("[HH:mm:ss:ml]:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(formattedDateTime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("XRLoader : Error");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]:");
            Console.ForegroundColor = MidColor;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MessageToLog);
            Console.ResetColor();
        }
    }
}