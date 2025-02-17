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
    ///The SendAliasPointingAnotherCNC recording.
    /// </summary>
    [TestModule("da1bb728-52c0-464c-92c6-dad9dfa5e6db", ModuleType.Recording, 1)]
    public partial class SendAliasPointingAnotherCNC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static SendAliasPointingAnotherCNC instance = new SendAliasPointingAnotherCNC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SendAliasPointingAnotherCNC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SendAliasPointingAnotherCNC Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.AliasPng1FromCnc2' at 59;10.", repo.CWork202296DEV.AliasPng1FromCnc2Info, new RecordItemIndex(0));
            repo.CWork202296DEV.AliasPng1FromCnc2.Click("59;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.BCommSend' at 47;27.", repo.CWork202296DEV.BCommSendInfo, new RecordItemIndex(1));
            repo.CWork202296DEV.BCommSend.Click("47;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            Ranorex.AutomationHelpers.UserCodeCollections.FileLibrary.CheckFilesExist("C:\\CworkTestAuto\\SMB\\CNC1\\Charg\\ImportFao\\", "png1.CNC", ValueConverter.ArgumentFromString<int>("expectedCount", "1"), ValueConverter.ArgumentFromString<int>("timeout", "0"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
