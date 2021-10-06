using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using NXconsole.src.Utils;

namespace NXconsole.src.Filesystem
{
    public sealed class FilesystemMaster
    {
        /////////////////
        /// Singleton Class
        /////////////////
        private FilesystemMaster() { }
        private static FilesystemMaster instance = null;
        public static FilesystemMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FilesystemMaster();
                }
                return instance;
            }
        }


        /////////////////
        /// Master Class
        /////////////////
        public Sys.FileSystem.CosmosVFS m_Fs;
        public bool FS_started = false;

        public void Init()
        {
            m_Fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(m_Fs);

            FS_started = true;
        }

        public void CreateFS()
        {
            if (!FS_started){ Logger.Exeption("CALLED_BEFFOR_INIT", "A function in 'FilesystemMaster' called before VFS initialization"); }

            m_Fs.Format("0" /*drive id*/, "FAT32" /*fat type*/, true /*use quick format*/);

            Console.WriteLine("A restart is required.\n");
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
}
