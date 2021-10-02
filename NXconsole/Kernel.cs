using System;
using System.Collections.Generic;
using System.Text;
using NXconsole.src.Core;
using NXconsole.src.Apps;
using NXconsole.src.Utils;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using Terminal.Gui;

namespace NXconsole
{
    public class Kernel : Sys.Kernel
    {
        Canvas canvas;

        protected override void BeforeRun()
        {
            SystemLogger.LogPackageInit("Root System");
            SystemLogger.LogPackageInit("C# System");

            SystemLogger.LogPackageInit("GUI Canvas");


            Console.Clear();
        }
        protected override void AfterRun()
        {
            SystemLogger.LogPackageShutdown("Root System");
        }


        protected override void Run()
        {
            Main mMain = new Main();
            mMain.Start();
        }
    }
}
