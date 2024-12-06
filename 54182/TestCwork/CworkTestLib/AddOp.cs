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
    ///The AddOp recording.
    /// </summary>
    [TestModule("10b2a278-f32d-43b9-bd2c-ff790fbc16ae", ModuleType.Recording, 1)]
    public partial class AddOp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static AddOp instance = new AddOp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddOp()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddOp Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BNewOP' at 55;27.", repo.CworkMainForm.CWork202195.BNewOPInfo, new RecordItemIndex(0));
            repo.CworkMainForm.CWork202195.BNewOP.Click("55;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn' at 15;6.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtnInfo, new RecordItemIndex(1));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn.Click("15;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'OP test' with focus on 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn'.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtnInfo, new RecordItemIndex(2));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn.PressKeys("OP test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn1' at 14;11.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn1Info, new RecordItemIndex(3));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn1.Click("14;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'OP desc' with focus on 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn1'.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn1Info, new RecordItemIndex(4));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn1.PressKeys("OP desc");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn2' at 32;14.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn2Info, new RecordItemIndex(5));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.TEditBtn2.Click("32;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Button' at 7;8.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.ButtonInfo, new RecordItemIndex(6));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Button.Click("7;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SelectionnerUneCnc.Cnc1' at 17;6.", repo.SelectionnerUneCnc.Cnc1Info, new RecordItemIndex(7));
            repo.SelectionnerUneCnc.Cnc1.Click("17;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SelectionnerUneCnc.ButtonOK' at 36;10.", repo.SelectionnerUneCnc.ButtonOKInfo, new RecordItemIndex(8));
            repo.SelectionnerUneCnc.ButtonOK.Click("36;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0' at 19;12.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0Info, new RecordItemIndex(9));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0.Click("19;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0'.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0Info, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10' with focus on 'CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0'.", repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0Info, new RecordItemIndex(11));
            repo.CreationDuneNouvelleOPSurLOFOFTes.AdvPanel1.Text0.PressKeys("10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CreationDuneNouvelleOPSurLOFOFTes.ElementBOK' at 65;13.", repo.CreationDuneNouvelleOPSurLOFOFTes.ElementBOKInfo, new RecordItemIndex(12));
            repo.CreationDuneNouvelleOPSurLOFOFTes.ElementBOK.Click("65;13");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
