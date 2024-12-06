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
    ///The ModifyYesterdaySecondState recording.
    /// </summary>
    [TestModule("031517e0-c544-4001-8aa5-edea4f36e275", ModuleType.Recording, 1)]
    public partial class ModifyYesterdaySecondState : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static ModifyYesterdaySecondState instance = new ModifyYesterdaySecondState();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifyYesterdaySecondState()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ModifyYesterdaySecondState Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.TogBtnRealTimeOff' at 57;24.", repo.CWork202296DEV.TogBtnRealTimeOffInfo, new RecordItemIndex(0));
            repo.CWork202296DEV.TogBtnRealTimeOff.Click("57;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.HistoryListViewForm.Panne1' at 38;11.", repo.CWork202296DEV.HistoryListViewForm.Panne1Info, new RecordItemIndex(1));
            repo.CWork202296DEV.HistoryListViewForm.Panne1.Click("38;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.HistoryListViewForm.BEditCurrentState' at 30;26.", repo.CWork202296DEV.HistoryListViewForm.BEditCurrentStateInfo, new RecordItemIndex(2));
            repo.CWork202296DEV.HistoryListViewForm.BEditCurrentState.Click("30;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.HistoryListViewForm.CbReplaceStateMono' at 215;12.", repo.CWork202296DEV.HistoryListViewForm.CbReplaceStateMonoInfo, new RecordItemIndex(3));
            repo.CWork202296DEV.HistoryListViewForm.CbReplaceStateMono.Click("215;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'None__2.Attente' at 27;2.", repo.None__2.AttenteInfo, new RecordItemIndex(4));
            repo.None__2.Attente.Click("27;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.HistoryListViewForm.BMonoEditConfirm' at 39;31.", repo.CWork202296DEV.HistoryListViewForm.BMonoEditConfirmInfo, new RecordItemIndex(5));
            repo.CWork202296DEV.HistoryListViewForm.BMonoEditConfirm.Click("39;31");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
