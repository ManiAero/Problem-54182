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
    ///The TryDeleteFiles recording.
    /// </summary>
    [TestModule("ff804ce2-7520-46e5-90f4-79ab61e56227", ModuleType.Recording, 1)]
    public partial class TryDeleteFiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static TryDeleteFiles instance = new TryDeleteFiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TryDeleteFiles()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TryDeleteFiles Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork202296DEV.RawTextDO0Percent' at 23;35.", repo.CWork202296DEV.RawTextDO0PercentInfo, new RecordItemIndex(0));
            repo.CWork202296DEV.RawTextDO0Percent.DoubleClick("23;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork202296DEV.Png11' at 59;6.", repo.CWork202296DEV.Png11Info, new RecordItemIndex(1));
            repo.CWork202296DEV.Png11.DoubleClick("59;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '' with focus on 'VersionsDeDocument'.", repo.VersionsDeDocument.SelfInfo, new RecordItemIndex(2));
            repo.VersionsDeDocument.Self.EnsureVisible();
            Keyboard.Press("");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}' with focus on 'VersionsDeDocument'.", repo.VersionsDeDocument.SelfInfo, new RecordItemIndex(3));
            repo.VersionsDeDocument.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.A1EDITE' at 73;11.", repo.VersionsDeDocument.A1EDITEInfo, new RecordItemIndex(4));
            repo.VersionsDeDocument.A1EDITE.Click("73;11");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.A0VALIDE' at 80;10.", repo.VersionsDeDocument.A0VALIDEInfo, new RecordItemIndex(5));
            //repo.VersionsDeDocument.A0VALIDE.Click("80;10");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}' with focus on 'VersionsDeDocument'.", repo.VersionsDeDocument.SelfInfo, new RecordItemIndex(6));
            repo.VersionsDeDocument.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.BDelete' at 73;74.", repo.VersionsDeDocument.BDeleteInfo, new RecordItemIndex(7));
            repo.VersionsDeDocument.BDelete.Click("73;74");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.PaMultiVersion' at 469;335.", repo.VersionsDeDocument.PaMultiVersionInfo, new RecordItemIndex(8));
            repo.VersionsDeDocument.PaMultiVersion.Click("469;335");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Avertissement.ButtonNon' at 19;8.", repo.Avertissement.ButtonNonInfo, new RecordItemIndex(9));
            //repo.Avertissement.ButtonNon.Click("19;8");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.Fermer' at 18;13.", repo.VersionsDeDocument.FermerInfo, new RecordItemIndex(10));
            repo.VersionsDeDocument.Fermer.Click("18;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.TAdvSmoothToggleButton1' at 32;36.", repo.CWork202296DEV.TAdvSmoothToggleButton1Info, new RecordItemIndex(11));
            repo.CWork202296DEV.TAdvSmoothToggleButton1.Click("32;36");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
