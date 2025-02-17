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
    ///The ConfigSendMailIsStateChange recording.
    /// </summary>
    [TestModule("ce09904a-03b3-4da4-8a17-68ad767436a1", ModuleType.Recording, 1)]
    public partial class ConfigSendMailIsStateChange : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static ConfigSendMailIsStateChange instance = new ConfigSendMailIsStateChange();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfigSendMailIsStateChange()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfigSendMailIsStateChange Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.MenuItemOutils' at 20;7.", repo.CworkMainForm.CWork202195.MenuItemOutilsInfo, new RecordItemIndex(0));
            repo.CworkMainForm.CWork202195.MenuItemOutils.Click("20;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork.MenuItem3' at 63;11.", repo.CworkMainForm.Cwork.MenuItem3Info, new RecordItemIndex(1));
            repo.CworkMainForm.Cwork.MenuItem3.Click("63;11");
            Delay.Milliseconds(12370);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.GestionDesNotifications' at 57;6.", repo.Preferences.GestionDesNotificationsInfo, new RecordItemIndex(2));
            repo.Preferences.GestionDesNotifications.Click("57;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.BAddNotif' at 30;10.", repo.Preferences.BAddNotifInfo, new RecordItemIndex(3));
            repo.Preferences.BAddNotif.Click("30;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork1.ChangementDetat' at Center.", repo.CworkMainForm.Cwork1.ChangementDetatInfo, new RecordItemIndex(4));
            repo.CworkMainForm.Cwork1.ChangementDetat.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.TabNewState.SelectionnerTout' at 183;8.", repo.Preferences.TabNewState.SelectionnerToutInfo, new RecordItemIndex(5));
            repo.Preferences.TabNewState.SelectionnerTout.Click("183;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.TabNewState.SelectionnerTout1' at 184;7.", repo.Preferences.TabNewState.SelectionnerTout1Info, new RecordItemIndex(6));
            repo.Preferences.TabNewState.SelectionnerTout1.Click("184;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.TabNewState.SelectionnerTout2' at 192;8.", repo.Preferences.TabNewState.SelectionnerTout2Info, new RecordItemIndex(7));
            repo.Preferences.TabNewState.SelectionnerTout2.Click("192;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.ButtonOk' at 49;15.", repo.Preferences.ButtonOkInfo, new RecordItemIndex(8));
            repo.Preferences.ButtonOk.Click("49;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
