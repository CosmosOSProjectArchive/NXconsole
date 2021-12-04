using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Filesystem;
using NXconsole.src.Utils;

namespace NXconsole.src.Apps
{
    class cat : App
    {
        public override void Init()
        {

        }

        public override void Execute(string[] p_Args)
        {
            if(p_Args.Length < 1)
            {
                Logger.LogWarn("No arguments passed");
                return;
            }

            try
            {
                var file = FilesystemMaster.Instance.m_Fs.GetFile(@"0:"+FilesystemMaster.Instance.m_CurrentDirectory+p_Args[1]);
                var file_stream = file.GetFileStream();

                if (file_stream.CanRead)
                {
                    byte[] text_to_read = new byte[file_stream.Length];
                    file_stream.Read(text_to_read, 0, (int)file_stream.Length);
                    Console.WriteLine(Encoding.Default.GetString(text_to_read));
                }

            } catch {
                Logger.LogWarn("Failed to read file '"+ p_Args[1] +"'");
            }
        }
    }
}
