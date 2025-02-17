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

namespace Sprint_9_6_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckTotalTimeValue recording.
    /// </summary>
    [TestModule("a28d067f-1f65-4d18-ad34-3be302c83abb", ModuleType.Recording, 1)]
    public partial class CheckTotalTimeValue : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_2Repository repository.
        /// </summary>
        public static Sprint_9_6_2Repository repo = Sprint_9_6_2Repository.Instance;

        static CheckTotalTimeValue instance = new CheckTotalTimeValue();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckTotalTimeValue()
        {
            TotalDayTimeMax = "24:00:00";
            NewVariable = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckTotalTimeValue Instance
        {
            get { return instance; }
        }

#region Variables

        string _TotalDayTimeMax;

        /// <summary>
        /// Gets or sets the value of variable TotalDayTimeMax.
        /// </summary>
        [TestVariable("a568f144-f93c-49fa-8cf3-b3f4da804b41")]
        public string TotalDayTimeMax
        {
            get { return _TotalDayTimeMax; }
            set { _TotalDayTimeMax = value; }
        }

        string _NewVariable;

        /// <summary>
        /// Gets or sets the value of variable NewVariable.
        /// </summary>
        [TestVariable("50cce554-34e6-4484-b98f-634f18fe367c")]
        public string NewVariable
        {
            get { return _NewVariable; }
            set { _NewVariable = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.StationsTiles' at 173;75.", repo.CWork2022962DEV.StationsTilesInfo, new RecordItemIndex(0));
            repo.CWork2022962DEV.StationsTiles.Click("173;75");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.StationsTiles' at 161;-33.", repo.CWork2022962DEV.StationsTilesInfo, new RecordItemIndex(1));
            repo.CWork2022962DEV.StationsTiles.Click("161;-33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.HistoriqueDeProduction.ToolPanelTab' at 11;29.", repo.CworkMainForm1.HistoriqueDeProduction.ToolPanelTabInfo, new RecordItemIndex(2));
            repo.CworkMainForm1.HistoriqueDeProduction.ToolPanelTab.Click("11;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.HistoriqueDeProduction.BtnMonth' at 20;43.", repo.CworkMainForm1.HistoriqueDeProduction.BtnMonthInfo, new RecordItemIndex(3));
            repo.CworkMainForm1.HistoriqueDeProduction.BtnMonth.Click("20;43");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.HistoriqueDeProduction.BtnMonth' at -109;-213.", repo.CworkMainForm1.HistoriqueDeProduction.BtnMonthInfo, new RecordItemIndex(4));
            repo.CworkMainForm1.HistoriqueDeProduction.BtnMonth.Click("-109;-213");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.Systeme' at 179;471.", repo.CworkMainForm1.SystemeInfo, new RecordItemIndex(5));
            repo.CworkMainForm1.Systeme.Click("179;471");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.HistoriqueDeProduction.ChoixDate' at 54;110.", repo.CworkMainForm1.HistoriqueDeProduction.ChoixDateInfo, new RecordItemIndex(6));
            repo.CworkMainForm1.HistoriqueDeProduction.ChoixDate.Click("54;110");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.SgCumul' at 730;467.", repo.CWork2022962DEV.SgCumulInfo, new RecordItemIndex(7));
            repo.CWork2022962DEV.SgCumul.Click("730;467");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$TotalDayTimeMax) on item 'CworkMainForm1.Cell2401'.", repo.CworkMainForm1.Cell2401Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.CworkMainForm1.Cell2401Info, "Text", TotalDayTimeMax);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
