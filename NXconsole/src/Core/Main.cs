using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Utils;

namespace NXconsole.src.Core
{
    class Main
    {
        //Classes
        LoginHelper m_LHelper = new LoginHelper();
        AppHandler m_AppHandler = new AppHandler();

        public void Start()
        {

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
                    if(m_LHelper.LoginPrompt() == "0542519")
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
                Console.Write("Admin@NX > ");
                m_AppHandler.HandleAppRequest(Console.ReadLine());
            }
        }
    }
}
