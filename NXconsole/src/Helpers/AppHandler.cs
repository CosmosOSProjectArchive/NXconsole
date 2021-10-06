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
            m_AppList.Add(new df());         m_AppListNames.Add("df");                                              //Display Disk Info
            m_AppList.Add(new create_fs());         m_AppListNames.Add("create_fs");                                //Create the filesystem
        }

        public void HandleAppRequest(string request)
        {
            if(!String.IsNullOrEmpty(request) && m_AppListNames.Contains(request))
            {
                m_AppList[m_AppListNames.IndexOf(request)].Execute();
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
