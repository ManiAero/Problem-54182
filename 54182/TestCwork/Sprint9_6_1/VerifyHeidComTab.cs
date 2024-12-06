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
    ///The VerifyHeidComTab recording.
    /// </summary>
    [TestModule("7dc3bf07-5ce3-4c59-ab9a-110dc2007106", ModuleType.Recording, 1)]
    public partial class VerifyHeidComTab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static VerifyHeidComTab instance = new VerifyHeidComTab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyHeidComTab()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyHeidComTab Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.MenuItemOutils' at 23;8.", repo.CWork202296DEV.MenuItemOutilsInfo, new RecordItemIndex(0));
            //repo.CWork202296DEV.MenuItemOutils.Click("23;8");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork2024983DEV.MenuItemOutils' at Center.", repo.Cwork2024983DEV.MenuItemOutilsInfo, new RecordItemIndex(1));
            repo.Cwork2024983DEV.MenuItemOutils.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork.MenuItemGererMoteur' at 61;15.", repo.CworkMainForm.Cwork.MenuItemGererMoteurInfo, new RecordItemIndex(2));
            repo.CworkMainForm.Cwork.MenuItemGererMoteur.Click("61;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GestionDesServeursEtMoteurs.StatusDesEntrees' at 44;5.", repo.GestionDesServeursEtMoteurs.StatusDesEntreesInfo, new RecordItemIndex(3));
            repo.GestionDesServeursEtMoteurs.StatusDesEntrees.Click("44;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='HeidCom') on item 'GestionDesServeursEtMoteurs.HeidCom'.", repo.GestionDesServeursEtMoteurs.HeidComInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.GestionDesServeursEtMoteurs.HeidComInfo, "Title", "HeidCom");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GestionDesServeursEtMoteurs.Valider' at 50;9.", repo.GestionDesServeursEtMoteurs.ValiderInfo, new RecordItemIndex(5));
            repo.GestionDesServeursEtMoteurs.Valider.Click("50;9");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
