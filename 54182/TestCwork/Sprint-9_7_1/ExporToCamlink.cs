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

namespace Sprint_9_7_1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ExporToCamlink recording.
    /// </summary>
    [TestModule("ec6f725d-5d45-4eb2-8766-a7b377231e4c", ModuleType.Recording, 1)]
    public partial class ExporToCamlink : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_1Repository repository.
        /// </summary>
        public static Sprint_9_7_1Repository repo = Sprint_9_7_1Repository.Instance;

        static ExporToCamlink instance = new ExporToCamlink();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExporToCamlink()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ExporToCamlink Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202397.BSelectAll' at 29;12.", repo.CWork202397.BSelectAllInfo, new RecordItemIndex(0));
            repo.CWork202397.BSelectAll.Click("29;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CWork202397.Png2' at 52;7.", repo.CWork202397.Png2Info, new RecordItemIndex(1));
            repo.CWork202397.Png2.Click(System.Windows.Forms.MouseButtons.Right, "52;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.Exporter' at 58;9.", repo.Cwork.ExporterInfo, new RecordItemIndex(2));
            repo.Cwork.Exporter.Click("58;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'RechercherUnDossier.CePC' at 17;13.", repo.RechercherUnDossier.CePCInfo, new RecordItemIndex(3));
            repo.RechercherUnDossier.CePC.DoubleClick("17;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'RechercherUnDossier.DisqueLocalC' at 46;6.", repo.RechercherUnDossier.DisqueLocalCInfo, new RecordItemIndex(4));
            repo.RechercherUnDossier.DisqueLocalC.DoubleClick("46;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'RechercherUnDossier.CworkTestAuto' at 37;4.", repo.RechercherUnDossier.CworkTestAutoInfo, new RecordItemIndex(5));
            repo.RechercherUnDossier.CworkTestAuto.DoubleClick("37;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'RechercherUnDossier.EXPORT' at 25;11.", repo.RechercherUnDossier.EXPORTInfo, new RecordItemIndex(6));
            repo.RechercherUnDossier.EXPORT.DoubleClick("25;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'RechercherUnDossier.MULTI1' at 12;11.", repo.RechercherUnDossier.MULTI1Info, new RecordItemIndex(7));
            repo.RechercherUnDossier.MULTI1.DoubleClick("12;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RechercherUnDossier.ButtonOK' at 38;12.", repo.RechercherUnDossier.ButtonOKInfo, new RecordItemIndex(8));
            repo.RechercherUnDossier.ButtonOK.Click("38;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExporterUneSerieDeDocuments4.ExporterLaDerniereVersionDesProgram' at 8;20.", repo.ExporterUneSerieDeDocuments4.ExporterLaDerniereVersionDesProgramInfo, new RecordItemIndex(9));
            repo.ExporterUneSerieDeDocuments4.ExporterLaDerniereVersionDesProgram.Click("8;20");
            Delay.Milliseconds(0);
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExporterUneSerieDeDocuments4.SomeButton' at 2;7.", repo.ExporterUneSerieDeDocuments4.SomeButtonInfo, new RecordItemIndex(10));
                //repo.ExporterUneSerieDeDocuments4.SomeButton.Click("2;7");
                //Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'List1000.FichiersCamlinkCMTTEXTAsteriskTCA' at 40;8.", repo.List1000.FichiersCamlinkCMTTEXTAsteriskTCAInfo, new RecordItemIndex(11));
                //repo.List1000.FichiersCamlinkCMTTEXTAsteriskTCA.Click("40;8");
                //Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExporterUneSerieDeDocuments4.ElementBOK' at 24;12.", repo.ExporterUneSerieDeDocuments4.ElementBOKInfo, new RecordItemIndex(12));
            repo.ExporterUneSerieDeDocuments4.ElementBOK.Click("24;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
