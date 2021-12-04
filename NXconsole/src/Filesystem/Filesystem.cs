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
        public string m_CurrentDirectory;
        public bool FS_started = false;

        public void Init()
        {
            m_Fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(m_Fs);

            m_CurrentDirectory = "\\";

            try
            {
                switch (Sys.FileSystem.VFS.VFSManager.IsValidDriveId(@"0:\"))
                {
                    case true:
                        SystemLogger.LogPackageInit("Filesystem checks, valid");
                        break;

                    case false:
                        Logger.LogError("Invalid Filesystem, some features will not work");
                        break;

                    default:
                        Logger.Exeption("INVALID_RESPONCE", "Failed to check the file system");
                        break;
                }
            } catch {
                Logger.Exeption("FATAL_FUNCTION", "Invalid drive ID");
            }

            FS_started = true;
        }
    }
}
