using System;
using System.Collections.Generic;
using System.Text;

namespace NXconsole.src.Apps
{
    class LoginHelper
    {
        public bool logged_in = false;

        public string LoginPrompt()
        { 
            Console.Write("Admin Login > ");

            return Console.ReadLine();
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
