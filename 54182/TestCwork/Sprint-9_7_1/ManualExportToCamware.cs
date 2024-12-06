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
    ///The ManualExportToCamware recording.
    /// </summary>
    [TestModule("54d8afe1-3c6e-4af1-b3ab-5085499b5a46", ModuleType.Recording, 1)]
    public partial class ManualExportToCamware : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_1Repository repository.
        /// </summary>
        public static Sprint_9_7_1Repository repo = Sprint_9_7_1Repository.Instance;

        static ManualExportToCamware instance = new ManualExportToCamware();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ManualExportToCamware()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ManualExportToCamware Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CWork202397.Prog2' at 55;8.", repo.CWork202397.Prog2Info, new RecordItemIndex(0));
            repo.CWork202397.Prog2.Click(System.Windows.Forms.MouseButtons.Right, "55;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork.Exporter' at 66;11.", repo.Cwork.ExporterInfo, new RecordItemIndex(1));
            repo.Cwork.Exporter.Click("66;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnregistrerSous.ToolBar10011' at 451;13.", repo.EnregistrerSous.ToolBar10011Info, new RecordItemIndex(2));
            repo.EnregistrerSous.ToolBar10011.Click("451;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\CworkTestAuto\\EXPORT\\SOLO' with focus on 'EnregistrerSous'.", repo.EnregistrerSous.SelfInfo, new RecordItemIndex(3));
            repo.EnregistrerSous.Self.EnsureVisible();
            Keyboard.Press("C:\\CworkTestAuto\\EXPORT\\SOLO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnregistrerSous.TousLesFichiersAsteriskAsterisk' at 277;5.", repo.EnregistrerSous.TousLesFichiersAsteriskAsteriskInfo, new RecordItemIndex(4));
            repo.EnregistrerSous.TousLesFichiersAsteriskAsterisk.Click("277;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List10001.FichiersCamwareAsteriskCMT' at 46;6.", repo.List10001.FichiersCamwareAsteriskCMTInfo, new RecordItemIndex(5));
            repo.List10001.FichiersCamwareAsteriskCMT.Click("46;6");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'EnregistrerSous.ButtonEnregistrer'", repo.EnregistrerSous.ButtonEnregistrerInfo, new ActionTimeout(5000), new RecordItemIndex(6));
            //repo.EnregistrerSous.ButtonEnregistrerInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnregistrerSous.ButtonEnregistrer' at Center.", repo.EnregistrerSous.ButtonEnregistrerInfo, new RecordItemIndex(8));
            repo.EnregistrerSous.ButtonEnregistrer.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            // Pour contourner un disfonctionnement u test
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nPour contourner un disfonctionnement u test\r\nMouse Left Click item 'EnregistrerSous.ButtonEnregistrer' at Center.", repo.EnregistrerSous.ButtonEnregistrerInfo, new RecordItemIndex(10));
                repo.EnregistrerSous.ButtonEnregistrer.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.BOpenVersion' at 64;27.", repo.VersionsDeDocument.BOpenVersionInfo, new RecordItemIndex(11));
            repo.VersionsDeDocument.BOpenVersion.Click("64;27");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
