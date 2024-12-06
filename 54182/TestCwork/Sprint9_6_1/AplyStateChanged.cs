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
    ///The AplyStateChanged recording.
    /// </summary>
    [TestModule("f231f3dc-6623-4fa2-aee5-6eddb7db9608", ModuleType.Recording, 1)]
    public partial class AplyStateChanged : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static AplyStateChanged instance = new AplyStateChanged();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AplyStateChanged()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AplyStateChanged Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.TAdvSmoothToggleButton1_2' at 31;27.", repo.CWork202296DEV.TAdvSmoothToggleButton1_2Info, new RecordItemIndex(0));
            repo.CWork202296DEV.TAdvSmoothToggleButton1_2.Click("31;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.BtSaveTops' at 51;18.", repo.CWork202296DEV.BtSaveTopsInfo, new RecordItemIndex(1));
            repo.CWork202296DEV.BtSaveTops.Click("51;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.BtClose1' at 50;20.", repo.CWork202296DEV.BtClose1Info, new RecordItemIndex(2));
            repo.CWork202296DEV.BtClose1.Click("50;20");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
