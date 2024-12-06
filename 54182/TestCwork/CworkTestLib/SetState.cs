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

namespace CworkTestLib
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SetState recording.
    /// </summary>
    [TestModule("9c140ad0-a963-4d2c-93e8-58134caad169", ModuleType.Recording, 1)]
    public partial class SetState : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static SetState instance = new SetState();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetState()
        {
            stateNum = "3";
            StateLibel = "Attente";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetState Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable stateNum.
        /// </summary>
        [TestVariable("597a693e-e65b-4028-93fa-15eb0d48ac6a")]
        public string stateNum
        {
            get { return repo.StateNum; }
            set { repo.StateNum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StateLibel.
        /// </summary>
        [TestVariable("f2bd20d4-44b3-4738-b1f6-b55fcf61abbd")]
        public string StateLibel
        {
            get { return repo.StateLibel; }
            set { repo.StateLibel = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.StationsTiles' at 173;80.", repo.CworkMainForm.CWork202195.StationsTilesInfo, new RecordItemIndex(0));
            repo.CworkMainForm.CWork202195.StationsTiles.Click("173;80");
            Delay.Milliseconds(9700);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BShowStateView' at 58;19.", repo.CworkMainForm.CWork202195.BShowStateViewInfo, new RecordItemIndex(1));
            repo.CworkMainForm.CWork202195.BShowStateView.Click("58;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.ButtonStateNum' at 15;22.", repo.CworkMainForm.CWork202195.ButtonStateNumInfo, new RecordItemIndex(2));
            repo.CworkMainForm.CWork202195.ButtonStateNum.Click("15;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CworkMainForm.CWork202195.ImgGood'.", repo.CworkMainForm.CWork202195.ImgGoodInfo, new RecordItemIndex(3));
            Validate.Exists(repo.CworkMainForm.CWork202195.ImgGoodInfo);
            Delay.Milliseconds(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BtClose' at 28;21.", repo.CworkMainForm.CWork202195.BtCloseInfo, new RecordItemIndex(4));
            repo.CworkMainForm.CWork202195.BtClose.Click("28;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'CworkMainForm.CWork202195.StateLibelInTiles'", repo.CworkMainForm.CWork202195.StateLibelInTilesInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.CworkMainForm.CWork202195.StateLibelInTilesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (RawText=$StateLibel) on item 'CworkMainForm.CWork202195.StateLibelInTiles'.", repo.CworkMainForm.CWork202195.StateLibelInTilesInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.CworkMainForm.CWork202195.StateLibelInTilesInfo, "RawText", StateLibel);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
