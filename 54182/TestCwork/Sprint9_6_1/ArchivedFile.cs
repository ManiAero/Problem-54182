﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Sprint9_6_1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ArchivedFile recording.
    /// </summary>
    [TestModule("b34ee33e-62f1-4704-b755-68e1a865ec1c", ModuleType.Recording, 1)]
    public partial class ArchivedFile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static ArchivedFile instance = new ArchivedFile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ArchivedFile()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ArchivedFile Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork202296DEV.RawTextDO0Percent' at 19;40.", repo.CWork202296DEV.RawTextDO0PercentInfo, new RecordItemIndex(0));
            repo.CWork202296DEV.RawTextDO0Percent.DoubleClick("19;40");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CWork202296DEV.Png11' at 52;5.", repo.CWork202296DEV.Png11Info, new RecordItemIndex(1));
            repo.CWork202296DEV.Png11.Click(System.Windows.Forms.MouseButtons.Right, "52;5");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.MenuItem' at 61;10.", repo.Cwork.MenuItemInfo, new RecordItemIndex(3));
            repo.Cwork.MenuItem.Click("61;10");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesDunDocument.Archiver' at 9;6.", repo.ProprietesDunDocument.ArchiverInfo, new RecordItemIndex(4));
            //repo.ProprietesDunDocument.Archiver.Click("9;6");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Check() on item 'ProprietesDunDocument.Archiver'.", repo.ProprietesDunDocument.ArchiverInfo, new RecordItemIndex(5));
            repo.ProprietesDunDocument.Archiver.Check();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesDunDocument.ElementBOK' at 65;12.", repo.ProprietesDunDocument.ElementBOKInfo, new RecordItemIndex(6));
            repo.ProprietesDunDocument.ElementBOK.Click("65;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.TAdvSmoothToggleButton1' at 25;35.", repo.CWork202296DEV.TAdvSmoothToggleButton1Info, new RecordItemIndex(7));
            repo.CWork202296DEV.TAdvSmoothToggleButton1.Click("25;35");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
