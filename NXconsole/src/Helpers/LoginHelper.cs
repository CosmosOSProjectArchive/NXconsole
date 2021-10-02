using System;
using System.Collections.Generic;
using System.Text;

namespace NXconsole.src.Helpers
{
    class LoginHelper
    {
        public bool logged_in = false;

        public string LoginPrompt()
        { 
            Console.Write("Enter Password For Admin: ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            string consoleResult = Console.ReadLine();
            Console.ResetColor();

            return consoleResult;
        }

        public void LogWrongCredentials()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("** Credentials Invalid **");
            Console.ResetColor();
            Console.WriteLine("------------------");
            Console.WriteLine("Press ENTER to continue...");

            Console.ReadLine();
        }
    }
}
