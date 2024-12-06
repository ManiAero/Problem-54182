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
    ///The DeleteProg recording.
    /// </summary>
    [TestModule("a0fba04d-f095-427a-ba5c-f938a69d15b9", ModuleType.Recording, 1)]
    public partial class DeleteProg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static DeleteProg instance = new DeleteProg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteProg()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteProg Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork202296DEV.StationsTiles' at 151;79.", repo.CWork202296DEV.StationsTilesInfo, new RecordItemIndex(0));
            repo.CWork202296DEV.StationsTiles.DoubleClick("151;79");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CWork202296DEV.Png1Cnc' at 37;5.", repo.CWork202296DEV.Png1CncInfo, new RecordItemIndex(1));
            repo.CWork202296DEV.Png1Cnc.Click(System.Windows.Forms.MouseButtons.Right, "37;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.Ouvrir' at 75;16.", repo.Cwork.OuvrirInfo, new RecordItemIndex(3));
            repo.Cwork.Ouvrir.Click("75;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '' with focus on 'VersionsDeDocument'.", repo.VersionsDeDocument.SelfInfo, new RecordItemIndex(4));
            repo.VersionsDeDocument.Self.EnsureVisible();
            Keyboard.Press("");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.BCompare2' at 115;23.", repo.VersionsDeDocument.BCompare2Info, new RecordItemIndex(5));
            repo.VersionsDeDocument.BCompare2.Click("115;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.A0VALIDE' at 62;14.", repo.VersionsDeDocument.A0VALIDEInfo, new RecordItemIndex(6));
            repo.VersionsDeDocument.A0VALIDE.Click("62;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}' with focus on 'VersionsDeDocument'.", repo.VersionsDeDocument.SelfInfo, new RecordItemIndex(7));
            repo.VersionsDeDocument.Self.EnsureVisible();
            Keyboard.Press("{LControlKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.A1EDITE' at 77;8.", repo.VersionsDeDocument.A1EDITEInfo, new RecordItemIndex(8));
            repo.VersionsDeDocument.A1EDITE.Click("77;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}' with focus on 'VersionsDeDocument'.", repo.VersionsDeDocument.SelfInfo, new RecordItemIndex(9));
            repo.VersionsDeDocument.Self.EnsureVisible();
            Keyboard.Press("{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.BCompare1' at 69;89.", repo.VersionsDeDocument.BCompare1Info, new RecordItemIndex(10));
            repo.VersionsDeDocument.BCompare1.Click("69;89");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.Fermer' at 14;19.", repo.VersionsDeDocument.FermerInfo, new RecordItemIndex(12));
            repo.VersionsDeDocument.Fermer.Click("14;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.TAdvSmoothToggleButton' at 31;40.", repo.CWork202296DEV.TAdvSmoothToggleButtonInfo, new RecordItemIndex(14));
            repo.CWork202296DEV.TAdvSmoothToggleButton.Click("31;40");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
