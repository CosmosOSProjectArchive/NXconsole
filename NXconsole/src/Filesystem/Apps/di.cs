using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Filesystem;

namespace NXconsole.src.Apps
{
    class di : App
    {
        public override void Init()
        {

        }

        public override void Execute(string[] p_Args)
        {
            var available_space = FilesystemMaster.Instance.m_Fs.GetAvailableFreeSpace(@"0:\");
            string fs_type = FilesystemMaster.Instance.m_Fs.GetFileSystemType("0:/");

            Console.WriteLine("Available Free Space: " + available_space);
            Console.WriteLine("File System Type: " + fs_type);
        }
    }
}
