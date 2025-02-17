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
    ///The ConfigCncAsLsv2 recording.
    /// </summary>
    [TestModule("69607ce9-f4f1-4ec7-9005-909d37d7672c", ModuleType.Recording, 1)]
    public partial class ConfigCncAsLsv2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static ConfigCncAsLsv2 instance = new ConfigCncAsLsv2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfigCncAsLsv2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfigCncAsLsv2 Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.Lsv2' at 22;4.", repo.ChoixDuneConfiguration.Lsv2Info, new RecordItemIndex(2));
            repo.ChoixDuneConfiguration.Lsv2.Click("22;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.ElementBOk' at 40;16.", repo.ChoixDuneConfiguration.ElementBOkInfo, new RecordItemIndex(3));
            repo.ChoixDuneConfiguration.ElementBOk.Click("40;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.LSV2_DNC' at 23;5.", repo.ProprietesPourCnc1.LSV2_DNCInfo, new RecordItemIndex(4));
            repo.ProprietesPourCnc1.LSV2_DNC.Click("23;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TxtIP' at Center.", repo.ProprietesPourCnc1.TxtIPInfo, new RecordItemIndex(5));
            repo.ProprietesPourCnc1.TxtIP.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Home' Press with focus on 'ProprietesPourCnc1.TxtProdLSV2ip'.", repo.ProprietesPourCnc1.TxtProdLSV2ipInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.ProprietesPourCnc1.TxtProdLSV2ip);
            Keyboard.Press(System.Windows.Forms.Keys.Home, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'ProprietesPourCnc1'.", repo.ProprietesPourCnc1.SelfInfo, new RecordItemIndex(7));
            repo.ProprietesPourCnc1.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10001000187' with focus on 'ProprietesPourCnc1.TxtProdLSV2ip'.", repo.ProprietesPourCnc1.TxtProdLSV2ipInfo, new RecordItemIndex(8));
            repo.ProprietesPourCnc1.TxtProdLSV2ip.PressKeys("10001000187");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ButtonAppliquer' at 46;10.", repo.ProprietesPourCnc1.ButtonAppliquerInfo, new RecordItemIndex(9));
            repo.ProprietesPourCnc1.ButtonAppliquer.Click("46;10");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
