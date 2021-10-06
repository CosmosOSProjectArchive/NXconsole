using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Helpers;
using NXconsole.src.Utils;
using NXconsole.src.Filesystem;

namespace NXconsole.src.Core
{
    class Main
    {
        //Classes
        LoginHelper m_LHelper = new LoginHelper();
        AppHandler m_AppHandler = new AppHandler();

        public void Start()
        {
            SystemLogger.LogPackageInit("Init Apps");
            m_AppHandler.InitApps();

            SystemLogger.LogPackageInit("Filesystem");
            FilesystemMaster.Instance.Init();

            //Console.Clear();
            //Start Main Loop
            Update();
        }

        public void Update()
        {
            while(true)
            {
                //Login Box
                if (!m_LHelper.logged_in)
                {
                    if(m_LHelper.LoginPrompt() == "admin")
                    {
                        m_LHelper.logged_in = true;
                        Console.Clear();

                        continue;
                    }

                    m_LHelper.LogWrongCredentials();
                    Console.Clear();
                    continue;
                }

                //Main Console System
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("admin");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("@");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NX");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("> ");

                Console.ForegroundColor = ConsoleColor.Gray;
                string consoleInput = Console.ReadLine();
                Console.ResetColor();

                m_AppHandler.HandleAppRequest(consoleInput);
            }
        }
    }
}
