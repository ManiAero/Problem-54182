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
    ///The WrongAdminSMSConfig recording.
    /// </summary>
    [TestModule("fa64f214-769c-4854-b6f4-66b4e7df083c", ModuleType.Recording, 1)]
    public partial class WrongAdminSMSConfig : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static WrongAdminSMSConfig instance = new WrongAdminSMSConfig();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WrongAdminSMSConfig()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WrongAdminSMSConfig Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.MenuItemOutils' at 20;7.", repo.CWork202296DEV.MenuItemOutilsInfo, new RecordItemIndex(0));
            //repo.CWork202296DEV.MenuItemOutils.Click("20;7");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork2024983DEV.MenuItemOutils' at Center.", repo.Cwork2024983DEV.MenuItemOutilsInfo, new RecordItemIndex(1));
            repo.Cwork2024983DEV.MenuItemOutils.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork.MenuItem3' at 63;11.", repo.CworkMainForm.Cwork.MenuItem3Info, new RecordItemIndex(2));
            repo.CworkMainForm.Cwork.MenuItem3.Click("63;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.DroitsDesUtilisateurs' at 53;4.", repo.Preferences.DroitsDesUtilisateursInfo, new RecordItemIndex(3));
            repo.Preferences.DroitsDesUtilisateurs.Click("53;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.Administrateur' at 46;7.", repo.Preferences.AdministrateurInfo, new RecordItemIndex(4));
            repo.Preferences.Administrateur.Click("46;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Preferences.Administrateur' at 49;4.", repo.Preferences.AdministrateurInfo, new RecordItemIndex(5));
            repo.Preferences.Administrateur.DoubleClick("49;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AjoutDunUtilisateur.OptPhone' at 49;9.", repo.AjoutDunUtilisateur.OptPhoneInfo, new RecordItemIndex(6));
            repo.AjoutDunUtilisateur.OptPhone.Click("49;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'AjoutDunUtilisateur.OptPhone'.", repo.AjoutDunUtilisateur.OptPhoneInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.AjoutDunUtilisateur.OptPhone);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '+33000000000' with focus on 'AjoutDunUtilisateur.OptPhone'.", repo.AjoutDunUtilisateur.OptPhoneInfo, new RecordItemIndex(8));
            repo.AjoutDunUtilisateur.OptPhone.PressKeys("+33000000000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AjoutDunUtilisateur.ButtonOK' at 31;8.", repo.AjoutDunUtilisateur.ButtonOKInfo, new RecordItemIndex(9));
            repo.AjoutDunUtilisateur.ButtonOK.Click("31;8");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormHash32770.ButtonOK' at 42;9.", repo.FormHash32770.ButtonOKInfo, new RecordItemIndex(10));
            //repo.FormHash32770.ButtonOK.Click("42;9");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AjoutDunUtilisateur.ButtonAnnuler' at 40;8.", repo.AjoutDunUtilisateur.ButtonAnnulerInfo, new RecordItemIndex(11));
            //repo.AjoutDunUtilisateur.ButtonAnnuler.Click("40;8");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Preferences.ButtonOk' at 37;17.", repo.Preferences.ButtonOkInfo, new RecordItemIndex(12));
            repo.Preferences.ButtonOk.Click("37;17");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
