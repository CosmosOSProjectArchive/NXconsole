using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Core;
using NXconsole.src.Utils;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using Terminal.Gui;

namespace NXconsole
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            SystemLogger.LogPackageInit("[BeforeRun] Root System");
            SystemLogger.LogPackageInit("[BeforeRun] C# System");
            SystemLogger.LogPackageInit("[BeforeRun] Graphics Driver");
        }
        protected override void AfterRun()
        {
            Console.Clear();
        }


        protected override void Run()
        {
            Main mMain = new Main();
            mMain.Start();
        }
    }
}
