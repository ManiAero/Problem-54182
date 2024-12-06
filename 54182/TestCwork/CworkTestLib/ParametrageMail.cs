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
    ///The ParametrageMail recording.
    /// </summary>
    [TestModule("53ca37ae-4d96-4ca9-9bfd-6174f8a404d1", ModuleType.Recording, 1)]
    public partial class ParametrageMail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static ParametrageMail instance = new ParametrageMail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ParametrageMail()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ParametrageMail Instance
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
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.ParametrageDesNotifications' at 54;4.", repo.Preferences.ParametrageDesNotificationsInfo, new RecordItemIndex(2));
            repo.Preferences.ParametrageDesNotifications.Click("54;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.StationsTiles' at 1074;139.", repo.CworkMainForm.CWork202195.StationsTilesInfo, new RecordItemIndex(3));
            repo.CworkMainForm.CWork202195.StationsTiles.Click("1074;139");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.NotifConfiguration.EdSmtpServer' at 19;11.", repo.Preferences.NotifConfiguration.EdSmtpServerInfo, new RecordItemIndex(4));
            //repo.Preferences.NotifConfiguration.EdSmtpServer.Click("19;11");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.NotifConfiguration.EdSmtpServer' at 11;13.", repo.Preferences.NotifConfiguration.EdSmtpServerInfo, new RecordItemIndex(5));
            //repo.Preferences.NotifConfiguration.EdSmtpServer.Click("11;13");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Preferences.NotifConfiguration.EdSmtpServer'.", repo.Preferences.NotifConfiguration.EdSmtpServerInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.Preferences.NotifConfiguration.EdSmtpServer);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'smtp.gmail.com' with focus on 'Preferences.NotifConfiguration.EdSmtpServer'.", repo.Preferences.NotifConfiguration.EdSmtpServerInfo, new RecordItemIndex(7));
            repo.Preferences.NotifConfiguration.EdSmtpServer.PressKeys("smtp.gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.NotifConfiguration.EdSmtpPort' at 27;9.", repo.Preferences.NotifConfiguration.EdSmtpPortInfo, new RecordItemIndex(8));
            repo.Preferences.NotifConfiguration.EdSmtpPort.Click("27;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Preferences.NotifConfiguration.EdSmtpPort'.", repo.Preferences.NotifConfiguration.EdSmtpPortInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.Preferences.NotifConfiguration.EdSmtpPort);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '587' with focus on 'Preferences.NotifConfiguration.EdSmtpPort'.", repo.Preferences.NotifConfiguration.EdSmtpPortInfo, new RecordItemIndex(10));
            repo.Preferences.NotifConfiguration.EdSmtpPort.PressKeys("587");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.NotifConfiguration.EdSendingAddress' at 8;9.", repo.Preferences.NotifConfiguration.EdSendingAddressInfo, new RecordItemIndex(11));
            repo.Preferences.NotifConfiguration.EdSendingAddress.Click("8;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Preferences.NotifConfiguration.EdSendingAddress'.", repo.Preferences.NotifConfiguration.EdSendingAddressInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.Preferences.NotifConfiguration.EdSendingAddress);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'support@smcom.com' with focus on 'Preferences.NotifConfiguration.EdSendingAddress'.", repo.Preferences.NotifConfiguration.EdSendingAddressInfo, new RecordItemIndex(13));
            repo.Preferences.NotifConfiguration.EdSendingAddress.PressKeys("support@smcom.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.NotifConfiguration.EdMailUser' at 22;12.", repo.Preferences.NotifConfiguration.EdMailUserInfo, new RecordItemIndex(14));
            repo.Preferences.NotifConfiguration.EdMailUser.Click("22;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Preferences.NotifConfiguration.EdMailUser'.", repo.Preferences.NotifConfiguration.EdMailUserInfo, new RecordItemIndex(15));
            Keyboard.PrepareFocus(repo.Preferences.NotifConfiguration.EdMailUser);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'support@smcom.com' with focus on 'Preferences.NotifConfiguration.EdMailUser'.", repo.Preferences.NotifConfiguration.EdMailUserInfo, new RecordItemIndex(16));
            repo.Preferences.NotifConfiguration.EdMailUser.PressKeys("support@smcom.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.NotifConfiguration.EdMailPassword' at 34;8.", repo.Preferences.NotifConfiguration.EdMailPasswordInfo, new RecordItemIndex(17));
            repo.Preferences.NotifConfiguration.EdMailPassword.Click("34;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Preferences.NotifConfiguration.EdMailUser'.", repo.Preferences.NotifConfiguration.EdMailUserInfo, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.Preferences.NotifConfiguration.EdMailUser);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'CgX4bB319' with focus on 'Preferences.NotifConfiguration.EdMailPassword'.", repo.Preferences.NotifConfiguration.EdMailPasswordInfo, new RecordItemIndex(19));
            repo.Preferences.NotifConfiguration.EdMailPassword.PressKeys("CgX4bB319");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.ButtonOk' at 41;11.", repo.Preferences.ButtonOkInfo, new RecordItemIndex(20));
            repo.Preferences.ButtonOk.Click("41;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
