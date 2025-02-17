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
    ///The ConfigCncAsFtpClient recording.
    /// </summary>
    [TestModule("dc68bfdc-a511-41f6-a658-9e604769f59e", ModuleType.Recording, 1)]
    public partial class ConfigCncAsFtpClient : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static ConfigCncAsFtpClient instance = new ConfigCncAsFtpClient();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfigCncAsFtpClient()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfigCncAsFtpClient Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.HurcoFTP' at 22;4.", repo.ChoixDuneConfiguration.HurcoFTPInfo, new RecordItemIndex(2));
            repo.ChoixDuneConfiguration.HurcoFTP.Click("22;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.ElementBOk' at 40;16.", repo.ChoixDuneConfiguration.ElementBOkInfo, new RecordItemIndex(3));
            repo.ChoixDuneConfiguration.ElementBOk.Click("40;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.FTPClient' at 23;5.", repo.ProprietesPourCnc1.FTPClientInfo, new RecordItemIndex(4));
            repo.ProprietesPourCnc1.FTPClient.Click("23;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TxtFTPCliIP' at 5;15.", repo.ProprietesPourCnc1.TxtFTPCliIPInfo, new RecordItemIndex(5));
            repo.ProprietesPourCnc1.TxtFTPCliIP.Click("5;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '127000000001' with focus on 'ProprietesPourCnc1.TxtFTPCliIP'.", repo.ProprietesPourCnc1.TxtFTPCliIPInfo, new RecordItemIndex(6));
            repo.ProprietesPourCnc1.TxtFTPCliIP.PressKeys("127000000001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TxtFTPCliRoot' at 34;15.", repo.ProprietesPourCnc1.TxtFTPCliRootInfo, new RecordItemIndex(7));
            repo.ProprietesPourCnc1.TxtFTPCliRoot.Click("34;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '/' with focus on 'ProprietesPourCnc1.TxtFTPCliRoot'.", repo.ProprietesPourCnc1.TxtFTPCliRootInfo, new RecordItemIndex(8));
            repo.ProprietesPourCnc1.TxtFTPCliRoot.PressKeys("/");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TreeItemFTP' at 12;7.", repo.ProprietesPourCnc1.TreeItemFTPInfo, new RecordItemIndex(9));
            repo.ProprietesPourCnc1.TreeItemFTP.Click("12;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.UsernameEdit' at 45;8.", repo.ProprietesPourCnc1.UsernameEditInfo, new RecordItemIndex(10));
            repo.ProprietesPourCnc1.UsernameEdit.Click("45;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ProprietesPourCnc1.UsernameEdit'.", repo.ProprietesPourCnc1.UsernameEditInfo, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.ProprietesPourCnc1.UsernameEdit);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ftp' with focus on 'ProprietesPourCnc1.UsernameEdit'.", repo.ProprietesPourCnc1.UsernameEditInfo, new RecordItemIndex(12));
            repo.ProprietesPourCnc1.UsernameEdit.PressKeys("ftp");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.PasswordEdit' at 54;11.", repo.ProprietesPourCnc1.PasswordEditInfo, new RecordItemIndex(13));
            repo.ProprietesPourCnc1.PasswordEdit.Click("54;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ProprietesPourCnc1.PasswordEdit'.", repo.ProprietesPourCnc1.PasswordEditInfo, new RecordItemIndex(14));
            Keyboard.PrepareFocus(repo.ProprietesPourCnc1.PasswordEdit);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ftp' with focus on 'ProprietesPourCnc1.PasswordEdit'.", repo.ProprietesPourCnc1.PasswordEditInfo, new RecordItemIndex(15));
            repo.ProprietesPourCnc1.PasswordEdit.PressKeys("ftp");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ButtonAppliquer' at 47;8.", repo.ProprietesPourCnc1.ButtonAppliquerInfo, new RecordItemIndex(16));
            repo.ProprietesPourCnc1.ButtonAppliquer.Click("47;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
