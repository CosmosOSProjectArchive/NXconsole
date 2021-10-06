using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Apps;
using NXconsole.src.Filesystem;

namespace NXconsole.src.Apps
{
    class create_fs : App
    {
        public override void Init()
        {

        }

        public override void Execute()
        {
            FilesystemMaster.Instance.CreateFS();
        }
    }
}
