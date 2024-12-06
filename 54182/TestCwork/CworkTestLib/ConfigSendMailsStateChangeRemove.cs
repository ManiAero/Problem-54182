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
    ///The ConfigSendMailsStateChangeRemove recording.
    /// </summary>
    [TestModule("f0a915a6-21be-46fb-9f9d-1cf8278904f8", ModuleType.Recording, 1)]
    public partial class ConfigSendMailsStateChangeRemove : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static ConfigSendMailsStateChangeRemove instance = new ConfigSendMailsStateChangeRemove();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfigSendMailsStateChangeRemove()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfigSendMailsStateChangeRemove Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.MenuItemOutils' at 20;7.", repo.CworkMainForm.CWork202195.MenuItemOutilsInfo, new RecordItemIndex(0));
            //repo.CworkMainForm.CWork202195.MenuItemOutils.Click("20;7");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork2024983DEV.MenuItemOutils' at Center.", repo.Cwork2024983DEV.MenuItemOutilsInfo, new RecordItemIndex(1));
            repo.Cwork2024983DEV.MenuItemOutils.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork.MenuItem3' at 63;11.", repo.CworkMainForm.Cwork.MenuItem3Info, new RecordItemIndex(2));
            repo.CworkMainForm.Cwork.MenuItem3.Click("63;11");
            Delay.Milliseconds(12370);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.GestionDesNotifications' at 57;6.", repo.Preferences.GestionDesNotificationsInfo, new RecordItemIndex(3));
            repo.Preferences.GestionDesNotifications.Click("57;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.BDelNotif' at 10;8.", repo.Preferences.BDelNotifInfo, new RecordItemIndex(4));
            repo.Preferences.BDelNotif.Click("10;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.ButtonOk' at 36;12.", repo.Preferences.ButtonOkInfo, new RecordItemIndex(5));
            repo.Preferences.ButtonOk.Click("36;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
