using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Filesystem;

namespace NXconsole.src.Apps
{
    class df : App
    {
        public override void Init()
        {

        }

        public override void Execute()
        {
            var available_space = FilesystemMaster.Instance.m_Fs.GetAvailableFreeSpace(@"0:\");
            Console.WriteLine("Available Free Space: " + available_space);
        }
    }
}
