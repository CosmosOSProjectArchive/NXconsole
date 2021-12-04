using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Utils;

namespace NXconsole.src.Helpers
{
    class AppHandler
    {
        List<App> m_AppList = new List<App>();
        List<string> m_AppListNames = new List<string>();

        public void InitApps()
        {
            //Register Apps
            m_AppList.Add(new Clear());         m_AppListNames.Add("clear");                                        //Clear The Console

            //Filesystem
            m_AppList.Add(new di());            m_AppListNames.Add("dskinf");                                       //Display Disk Info
            m_AppList.Add(new ls());            m_AppListNames.Add("ls");                                           //Current directory list
            m_AppList.Add(new cat());           m_AppListNames.Add("cat");                                          //Read the contents of a file
        }

        public void HandleAppRequest(string request)
        {
            string[] mArgs = request.Split(" ");

            if (!String.IsNullOrEmpty(request) && m_AppListNames.Contains(mArgs[0]))
            {
                try
                {
                    m_AppList[m_AppListNames.IndexOf(mArgs[0])].Execute(mArgs);

                } catch(Exception e) {
                    Logger.Exeption("FATAL_COMMAND", "Command executed fatal function\n\n"+e.ToString());
                }

            }
            else if (String.IsNullOrEmpty(request)) {
                return;
            }
            else {
                Logger.LogError("\nCommand '"+request+"' not found.\n");
            }
        }

    }
}
