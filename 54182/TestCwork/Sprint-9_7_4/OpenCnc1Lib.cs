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

namespace Sprint_9_7_4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenCnc1Lib recording.
    /// </summary>
    [TestModule("a511f5a1-86f5-4b8d-8ef7-987ec104da6e", ModuleType.Recording, 1)]
    public partial class OpenCnc1Lib : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_4Repository repository.
        /// </summary>
        public static Sprint_9_7_4Repository repo = Sprint_9_7_4Repository.Instance;

        static OpenCnc1Lib instance = new OpenCnc1Lib();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenCnc1Lib()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenCnc1Lib Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023973DEV.Cnc1' at 37;16.", repo.CWork2023973DEV.Cnc1Info, new RecordItemIndex(0));
            repo.CWork2023973DEV.Cnc1.Click("37;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023973DEV.BShowProgram' at 57;26.", repo.CWork2023973DEV.BShowProgramInfo, new RecordItemIndex(1));
            repo.CWork2023973DEV.BShowProgram.Click("57;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork2023973DEV.Cnc2' at 15;7.", repo.CWork2023973DEV.Cnc2Info, new RecordItemIndex(2));
            repo.CWork2023973DEV.Cnc2.DoubleClick("15;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork2023973DEV.Cnc11' at 15;7.", repo.CWork2023973DEV.Cnc11Info, new RecordItemIndex(3));
            repo.CWork2023973DEV.Cnc11.DoubleClick("15;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
