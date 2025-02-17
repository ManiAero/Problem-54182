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

namespace Sprint_9_7_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The testDisplayCurentDayState recording.
    /// </summary>
    [TestModule("07353c44-99e5-438d-82d5-006b081f0484", ModuleType.Recording, 1)]
    public partial class testDisplayCurentDayState : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_2Repository repository.
        /// </summary>
        public static Sprint_9_7_2Repository repo = Sprint_9_7_2Repository.Instance;

        static testDisplayCurentDayState instance = new testDisplayCurentDayState();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public testDisplayCurentDayState()
        {
            curentday = "01/01/1970";
            CurentDay1 = " 15/06/2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static testDisplayCurentDayState Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CurentDay1.
        /// </summary>
        [TestVariable("31285dbd-c61f-4300-bfce-f612a7026645")]
        public string CurentDay1
        {
            get { return repo.CurentDay1; }
            set { repo.CurentDay1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable curentday.
        /// </summary>
        [TestVariable("c5c3f400-36c6-4c54-a726-02f5192dc61b")]
        public string curentday
        {
            get { return repo.curentday; }
            set { repo.curentday = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.Cnc1' at 28;14.", repo.CWork2023972DEV.Cnc1Info, new RecordItemIndex(0));
            repo.CWork2023972DEV.Cnc1.Click("28;14");
            Delay.Milliseconds(0);
            
            CurentDay1 = GetCurentDate();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.Cnc1' at 33;15.", repo.CWork2023972DEV.Cnc1Info, new RecordItemIndex(2));
            repo.CWork2023972DEV.Cnc1.Click("33;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.BShowTimeline' at 80;44.", repo.CWork2023972DEV.BShowTimelineInfo, new RecordItemIndex(3));
            repo.CWork2023972DEV.BShowTimeline.Click("80;44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.BtShow' at 103;31.", repo.CWork2023972DEV.BtShowInfo, new RecordItemIndex(4));
            repo.CWork2023972DEV.BtShow.Click("103;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.MenuItem' at 61;10.", repo.Cwork.MenuItemInfo, new RecordItemIndex(5));
            repo.Cwork.MenuItem.Click("61;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.HistoriqueDeProduction.ToolPanelTab' at 9;36.", repo.CWork2023972DEV.HistoriqueDeProduction.ToolPanelTabInfo, new RecordItemIndex(6));
            repo.CWork2023972DEV.HistoriqueDeProduction.ToolPanelTab.Click("9;36");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.HistoriqueDeProduction.BtnDay' at 28;28.", repo.CWork2023972DEV.HistoriqueDeProduction.BtnDayInfo, new RecordItemIndex(7));
            repo.CWork2023972DEV.HistoriqueDeProduction.BtnDay.Click("28;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.HistoriqueDeProduction.RawText15062023' at 32;7.", repo.CWork2023972DEV.HistoriqueDeProduction.RawText15062023Info, new RecordItemIndex(8));
            repo.CWork2023972DEV.HistoriqueDeProduction.RawText15062023.Click("32;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.HistoriqueDeProduction.Panne' at 90;27.", repo.CWork2023972DEV.HistoriqueDeProduction.PanneInfo, new RecordItemIndex(9));
            repo.CWork2023972DEV.HistoriqueDeProduction.Panne.Click("90;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$CurentDay1) on item 'CWork2023972DEV.HistoriqueDeProduction.Text14062023'.", repo.CWork2023972DEV.HistoriqueDeProduction.Text14062023Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.CWork2023972DEV.HistoriqueDeProduction.Text14062023Info, "Text", CurentDay1);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023972DEV.HistoriqueDeProduction.BtClose' at 53;25.", repo.CWork2023972DEV.HistoriqueDeProduction.BtCloseInfo, new RecordItemIndex(11));
            repo.CWork2023972DEV.HistoriqueDeProduction.BtClose.Click("53;25");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
