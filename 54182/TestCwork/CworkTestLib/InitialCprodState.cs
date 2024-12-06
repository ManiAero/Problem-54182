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
    ///The InitialCprodState recording.
    /// </summary>
    [TestModule("b0831f0a-0898-4842-b4b4-33d475807a4c", ModuleType.Recording, 1)]
    public partial class InitialCprodState : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static InitialCprodState instance = new InitialCprodState();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InitialCprodState()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InitialCprodState Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.MenuItemOutils' at 27;9.", repo.CworkMainForm.CWork202195.MenuItemOutilsInfo, new RecordItemIndex(0));
            //repo.CworkMainForm.CWork202195.MenuItemOutils.Click("27;9");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork2024983DEV.MenuItemOutils' at Center.", repo.Cwork2024983DEV.MenuItemOutilsInfo, new RecordItemIndex(1));
            repo.Cwork2024983DEV.MenuItemOutils.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork.MenuItem2' at 87;13.", repo.CworkMainForm.Cwork.MenuItem2Info, new RecordItemIndex(2));
            repo.CworkMainForm.Cwork.MenuItem2.Click("87;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OptionsDeProduction.EtatsGeneraux' at 63;5.", repo.OptionsDeProduction.EtatsGenerauxInfo, new RecordItemIndex(3));
            repo.OptionsDeProduction.EtatsGeneraux.Click("63;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OptionsDeProduction.ParDef' at 60;13.", repo.OptionsDeProduction.ParDefInfo, new RecordItemIndex(4));
            repo.OptionsDeProduction.ParDef.Click("60;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Production') on item 'OptionsDeProduction.Production'.", repo.OptionsDeProduction.ProductionInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.OptionsDeProduction.ProductionInfo, "Text", "Production");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'OptionsDeProduction.Valider' at 35;10.", repo.OptionsDeProduction.ValiderInfo, new RecordItemIndex(6));
            repo.OptionsDeProduction.Valider.MoveTo("35;10");
            repo.OptionsDeProduction.Valider.MouseDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'OptionsDeProduction.Valider' at 35;10.", repo.OptionsDeProduction.ValiderInfo, new RecordItemIndex(7));
            repo.OptionsDeProduction.Valider.MoveTo("35;10");
            repo.OptionsDeProduction.Valider.MouseUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormHash32770.ButtonOK' at 39;10.", repo.FormHash32770.ButtonOKInfo, new RecordItemIndex(8));
            repo.FormHash32770.ButtonOK.Click("39;10");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Informations.ButtonOui' at 39;11.", repo.Informations.ButtonOuiInfo, new RecordItemIndex(9));
            //repo.Informations.ButtonOui.Click("39;11");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
