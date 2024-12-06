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
    ///The ImportFromShortCut recording.
    /// </summary>
    [TestModule("6c7a0dcc-d1d9-45c3-a5d8-78b58b5da39f", ModuleType.Recording, 1)]
    public partial class ImportFromShortCut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_2Repository repository.
        /// </summary>
        public static Sprint_9_6_2Repository repo = Sprint_9_6_2Repository.Instance;

        static ImportFromShortCut instance = new ImportFromShortCut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ImportFromShortCut()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ImportFromShortCut Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.StationsTiles' at 893;265.", repo.CWork2022962DEV.StationsTilesInfo, new RecordItemIndex(0));
            repo.CWork2022962DEV.StationsTiles.Click("893;265");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+I' Press with focus on 'CWork2022962DEV'.", repo.CWork2022962DEV.SelfInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.CWork2022962DEV.Self);
            Keyboard.Press(System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.Control, 23, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.StationsTiles' at 690;108.", repo.CWork2022962DEV.StationsTilesInfo, new RecordItemIndex(2));
            repo.CWork2022962DEV.StationsTiles.Click("690;108");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportationDunDocumentOuDunDossier.OptImportFolder' at 17;11.", repo.ImportationDunDocumentOuDunDossier.OptImportFolderInfo, new RecordItemIndex(3));
            repo.ImportationDunDocumentOuDunDossier.OptImportFolder.Click("17;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\CworkTestAuto\\ImportFAO' with focus on 'ImportationDunDocumentOuDunDossier.OptImportFolder'.", repo.ImportationDunDocumentOuDunDossier.OptImportFolderInfo, new RecordItemIndex(4));
            repo.ImportationDunDocumentOuDunDossier.OptImportFolder.PressKeys("C:\\CworkTestAuto\\ImportFAO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportationDunDocumentOuDunDossier.Button1' at 8;12.", repo.ImportationDunDocumentOuDunDossier.Button1Info, new RecordItemIndex(5));
            repo.ImportationDunDocumentOuDunDossier.Button1.Click("8;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SelectionnerUneCnc.Cnc1' at 15;8.", repo.SelectionnerUneCnc.Cnc1Info, new RecordItemIndex(6));
            repo.SelectionnerUneCnc.Cnc1.Click("15;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SelectionnerUneCnc.ButtonOK' at 44;13.", repo.SelectionnerUneCnc.ButtonOKInfo, new RecordItemIndex(7));
            repo.SelectionnerUneCnc.ButtonOK.Click("44;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ImportationDunDocumentOuDunDossier.ElementBOk' at 92;14.", repo.ImportationDunDocumentOuDunDossier.ElementBOkInfo, new RecordItemIndex(8));
            repo.ImportationDunDocumentOuDunDossier.ElementBOk.Click("92;14");
            Delay.Milliseconds(0);
            
            try {
                repo.Confirmer.OuiPourTout.Click("68;10");
                Delay.Milliseconds(0);
            } catch(Exception) {  }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 4m to not exist. Associated repository item: 'ImportationDunDocumentOuDunDossier'", repo.ImportationDunDocumentOuDunDossier.SelfInfo, new ActionTimeout(240000), new RecordItemIndex(10));
            repo.ImportationDunDocumentOuDunDossier.SelfInfo.WaitForNotExists(240000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
