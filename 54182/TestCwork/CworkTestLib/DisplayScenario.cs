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
    ///The DisplayScenario recording.
    /// </summary>
    [TestModule("a673c296-0a18-4812-a6b5-f8f722cb882c", ModuleType.Recording, 1)]
    public partial class DisplayScenario : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static DisplayScenario instance = new DisplayScenario();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DisplayScenario()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DisplayScenario Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varScenarioName.
        /// </summary>
        [TestVariable("2e7efc9c-dc64-4a71-adc4-fe40a7f2c6b0")]
        public string varScenarioName
        {
            get { return repo.varScenarioName; }
            set { repo.varScenarioName = value; }
        }

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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.MenuItemOutils' at 25;12.", repo.CworkMainForm.CWork202195.MenuItemOutilsInfo, new RecordItemIndex(0));
            //repo.CworkMainForm.CWork202195.MenuItemOutils.Click("25;12");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork2024983DEV.MenuItemOutils' at Center.", repo.Cwork2024983DEV.MenuItemOutilsInfo, new RecordItemIndex(1));
            repo.Cwork2024983DEV.MenuItemOutils.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork1.MenuItem1' at 125;11.", repo.CworkMainForm.Cwork1.MenuItem1Info, new RecordItemIndex(2));
            repo.CworkMainForm.Cwork1.MenuItem1.Click("125;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OptionsDeCommunication.OptionsPrincipales' at 61;2.", repo.OptionsDeCommunication.OptionsPrincipalesInfo, new RecordItemIndex(3));
            repo.OptionsDeCommunication.OptionsPrincipales.Click("61;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OptionsDeCommunication.TeButton2' at 15;8.", repo.OptionsDeCommunication.TeButton2Info, new RecordItemIndex(4));
            repo.OptionsDeCommunication.TeButton2.Click("15;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SelectionDuScenarioDeCWork.ScenarioList' at 130;8.", repo.SelectionDuScenarioDeCWork.ScenarioListInfo, new RecordItemIndex(5));
            repo.SelectionDuScenarioDeCWork.ScenarioList.Click("130;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Scenario1' at 27;3.", repo.List1000.Scenario1Info, new RecordItemIndex(6));
            repo.List1000.Scenario1.Click("27;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SelectionDuScenarioDeCWork.ButtonOK' at 54;8.", repo.SelectionDuScenarioDeCWork.ButtonOKInfo, new RecordItemIndex(7));
            repo.SelectionDuScenarioDeCWork.ButtonOK.Click("54;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormHash32770.ButtonOK' at 58;11.", repo.FormHash32770.ButtonOKInfo, new RecordItemIndex(8));
            repo.FormHash32770.ButtonOK.Click("58;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
