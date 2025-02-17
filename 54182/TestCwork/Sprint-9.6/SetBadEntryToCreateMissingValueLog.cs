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

namespace Sprint9_6
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SetBadEntryToCreateMissingValueLog recording.
    /// </summary>
    [TestModule("92dfbefe-273c-4431-bd17-e7e40888463b", ModuleType.Recording, 1)]
    public partial class SetBadEntryToCreateMissingValueLog : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6Repository repository.
        /// </summary>
        public static Sprint_9_6Repository repo = Sprint_9_6Repository.Instance;

        static SetBadEntryToCreateMissingValueLog instance = new SetBadEntryToCreateMissingValueLog();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetBadEntryToCreateMissingValueLog()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetBadEntryToCreateMissingValueLog Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CworkMainForm.StationsTiles' at 148;100.", repo.CworkMainForm.StationsTilesInfo, new RecordItemIndex(0));
            repo.CworkMainForm.StationsTiles.Click(System.Windows.Forms.MouseButtons.Right, "148;100");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.Proprietes' at 72;1.", repo.Cwork.ProprietesInfo, new RecordItemIndex(1));
            repo.Cwork.Proprietes.Click("72;1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.MazakT1' at 29;7.", repo.ChoixDuneConfiguration.MazakT1Info, new RecordItemIndex(2));
            repo.ChoixDuneConfiguration.MazakT1.Click("29;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.ElementBOk' at 45;13.", repo.ChoixDuneConfiguration.ElementBOkInfo, new RecordItemIndex(3));
            repo.ChoixDuneConfiguration.ElementBOk.Click("45;13");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ButtonAppliquer' at 23;6.", repo.ProprietesPourCnc1.ButtonAppliquerInfo, new RecordItemIndex(4));
            //repo.ProprietesPourCnc1.ButtonAppliquer.Click("23;6");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CworkMainForm.StationsTiles' at 183;83.", repo.CworkMainForm.StationsTilesInfo, new RecordItemIndex(5));
            //repo.CworkMainForm.StationsTiles.Click(System.Windows.Forms.MouseButtons.Right, "183;83");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.Proprietes' at 54;10.", repo.Cwork.ProprietesInfo, new RecordItemIndex(6));
            //repo.Cwork.Proprietes.Click("54;10");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.LSV2' at 25;9.", repo.ProprietesPourCnc1.LSV2Info, new RecordItemIndex(7));
            repo.ProprietesPourCnc1.LSV2.Click("25;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TxtProdLSV2ip' at 5;15.", repo.ProprietesPourCnc1.TxtProdLSV2ipInfo, new RecordItemIndex(8));
            repo.ProprietesPourCnc1.TxtProdLSV2ip.Click("5;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad2}{NumPad7}{Right}{Right}{NumPad0}' with focus on 'ProprietesPourCnc1.TxtProdLSV2ip'.", repo.ProprietesPourCnc1.TxtProdLSV2ipInfo, new RecordItemIndex(9));
            repo.ProprietesPourCnc1.TxtProdLSV2ip.PressKeys("{NumPad1}{NumPad2}{NumPad7}{Right}{Right}{NumPad0}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}{Right}' with focus on 'ProprietesPourCnc1.TxtProdLSV2ip'.", repo.ProprietesPourCnc1.TxtProdLSV2ipInfo, new RecordItemIndex(10));
            repo.ProprietesPourCnc1.TxtProdLSV2ip.PressKeys("{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad0}{Right}{Right}{NumPad1}' with focus on 'ProprietesPourCnc1.TxtProdLSV2ip'.", repo.ProprietesPourCnc1.TxtProdLSV2ipInfo, new RecordItemIndex(11));
            repo.ProprietesPourCnc1.TxtProdLSV2ip.PressKeys("{NumPad0}{Right}{Right}{NumPad1}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.Commandes' at 49;10.", repo.ProprietesPourCnc1.CommandesInfo, new RecordItemIndex(12));
            repo.ProprietesPourCnc1.Commandes.Click("49;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TabSheet2.ActiverLesCommandes' at 3;6.", repo.ProprietesPourCnc1.TabSheet2.ActiverLesCommandesInfo, new RecordItemIndex(13));
            repo.ProprietesPourCnc1.TabSheet2.ActiverLesCommandes.Click("3;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TabSheet2.Production' at 31;9.", repo.ProprietesPourCnc1.TabSheet2.ProductionInfo, new RecordItemIndex(14));
            repo.ProprietesPourCnc1.TabSheet2.Production.Click("31;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.MemVarPascal' at 21;19.", repo.ProprietesPourCnc1.MemVarPascalInfo, new RecordItemIndex(15));
            repo.ProprietesPourCnc1.MemVarPascal.Click("21;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '({{@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Channel1.Device2.Tag1@} = 3) AND ({{@OPCDA|INT|localhost&Matrikon.OPC.Simulation.1&Random.Int1@} =15)' with focus on 'ProprietesPourCnc1.MemVarPascal'.", repo.ProprietesPourCnc1.MemVarPascalInfo, new RecordItemIndex(16));
            repo.ProprietesPourCnc1.MemVarPascal.PressKeys("({{@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Channel1.Device2.Tag1@} = 3) AND ({{@OPCDA|INT|localhost&Matrikon.OPC.Simulation.1&Random.Int1@} =15)");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TabSheet2.BCommandValid' at 11;11.", repo.ProprietesPourCnc1.TabSheet2.BCommandValidInfo, new RecordItemIndex(17));
            repo.ProprietesPourCnc1.TabSheet2.BCommandValid.Click("11;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ButtonAppliquer' at 59;8.", repo.ProprietesPourCnc1.ButtonAppliquerInfo, new RecordItemIndex(18));
            repo.ProprietesPourCnc1.ButtonAppliquer.Click("59;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
