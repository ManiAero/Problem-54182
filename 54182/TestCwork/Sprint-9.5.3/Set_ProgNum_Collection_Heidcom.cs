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

namespace Sprint9_5_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Set_ProgNum_Collection_Heidcom recording.
    /// </summary>
    [TestModule("100fab39-3fd4-421e-bf82-2e6ada0535d0", ModuleType.Recording, 1)]
    public partial class Set_ProgNum_Collection_Heidcom : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_5_3Repository repository.
        /// </summary>
        public static Sprint_9_5_3Repository repo = Sprint_9_5_3Repository.Instance;

        static Set_ProgNum_Collection_Heidcom instance = new Set_ProgNum_Collection_Heidcom();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Set_ProgNum_Collection_Heidcom()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Set_ProgNum_Collection_Heidcom Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.Cnc1' at Center.", repo.CworkMainForm1.Cnc1Info, new RecordItemIndex(0));
            repo.CworkMainForm1.Cnc1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BProperty' at Center.", repo.CworkMainForm.CWork202195.BPropertyInfo, new RecordItemIndex(1));
            repo.CworkMainForm.CWork202195.BProperty.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.CollecteDevenements' at 60;9.", repo.ProprietesPourCnc1.CollecteDevenementsInfo, new RecordItemIndex(2));
            repo.ProprietesPourCnc1.CollecteDevenements.Click("60;9");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ActiverLaCollecteDesProgrammesEnCo' at 6;5.", repo.ProprietesPourCnc1.ActiverLaCollecteDesProgrammesEnCoInfo, new RecordItemIndex(3));
            //repo.ProprietesPourCnc1.ActiverLaCollecteDesProgrammesEnCo.Click("6;5");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ActiverLaCollecteDesProgrammesEnCo' at 7;9.", repo.ProprietesPourCnc1.ActiverLaCollecteDesProgrammesEnCoInfo, new RecordItemIndex(4));
            repo.ProprietesPourCnc1.ActiverLaCollecteDesProgrammesEnCo.Click("7;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.SomeButton2' at 6;8.", repo.ProprietesPourCnc1.SomeButton2Info, new RecordItemIndex(5));
            repo.ProprietesPourCnc1.SomeButton2.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ViaHeidCOM' at 41;4.", repo.List1000.ViaHeidCOMInfo, new RecordItemIndex(6));
            repo.List1000.ViaHeidCOM.Click("41;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Via Heid COM') on item 'ProprietesPourCnc1.CbRunningPrgMode'.", repo.ProprietesPourCnc1.CbRunningPrgModeInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ProprietesPourCnc1.CbRunningPrgModeInfo, "Text", "Via Heid COM");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ActiverLaCollecteDesProgrammesCoura' at 6;9.", repo.ProprietesPourCnc1.ActiverLaCollecteDesProgrammesCouraInfo, new RecordItemIndex(8));
            //repo.ProprietesPourCnc1.ActiverLaCollecteDesProgrammesCoura.Click("6;9");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.SomeButton1' at 10;10.", repo.ProprietesPourCnc1.SomeButton1Info, new RecordItemIndex(9));
            //repo.ProprietesPourCnc1.SomeButton1.Click("10;10");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ViaHeidCOM' at 91;3.", repo.List1000.ViaHeidCOMInfo, new RecordItemIndex(10));
            //repo.List1000.ViaHeidCOM.Click("91;3");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Via Heid COM') on item 'ProprietesPourCnc1.CbProgMode'.", repo.ProprietesPourCnc1.CbProgModeInfo, new RecordItemIndex(11));
            //Validate.AttributeEqual(repo.ProprietesPourCnc1.CbProgModeInfo, "Text", "Via Heid COM");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ButtonAppliquer' at 19;11.", repo.ProprietesPourCnc1.ButtonAppliquerInfo, new RecordItemIndex(12));
            repo.ProprietesPourCnc1.ButtonAppliquer.Click("19;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
