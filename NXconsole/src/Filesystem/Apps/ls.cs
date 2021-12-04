using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Filesystem;
using NXconsole.src.Utils;

namespace NXconsole.src.Apps
{
    class ls : App
    {
        public override void Init()
        {

        }

        public override void Execute(string[] p_Args)
        {
            try
            {
                var directory_list = FilesystemMaster.Instance.m_Fs.GetDirectoryListing("0:/");

                if (directory_list.Count >= 0)
                {
                    Logger.LogInfo("No files in the directory");
                }
                else
                {
                    foreach (var directoryEntry in directory_list)
                    {
                        Console.WriteLine(directoryEntry.mName);
                    }
                }
            } catch {
                Logger.LogWarn("Failed to check the file system, this sometimes happens when there are no files or directories.");
            }
        }
    }
}
