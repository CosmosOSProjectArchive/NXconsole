using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NXconsole.src.Utils
{
    class Logger
    {
        public static void LogInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        public static void LogWarn(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        public static void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        public static void Exeption(string code, string msg)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.WriteLine("\n\nError Code: "+code);
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Press ENTER To Restart...");

            bool Wait = true;
            while (Wait)
            {
                if (Console.ReadLine().Equals(""))
                {
                    Wait = false;
                    Sys.Power.Reboot();
                }
            }
        }
    }

    class SystemLogger
    {
        public static void LogPackageInit(string package)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK (2)");
            Console.ResetColor();
            Console.Write("] - " + package);
            Console.Write("\n");
        }
        public static void LogPackageShutdown(string package)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("SHUTDOWN (3)");
            Console.ResetColor();
            Console.Write("] - " + package);
            Console.Write("\n");
        }
    }
}
