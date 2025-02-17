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

namespace Sprint_9_7
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditFileForSearch recording.
    /// </summary>
    [TestModule("64fc1fbd-099f-4367-affb-5cd03d049bfe", ModuleType.Recording, 1)]
    public partial class EditFileForSearch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7Repository repository.
        /// </summary>
        public static Sprint_9_7Repository repo = Sprint_9_7Repository.Instance;

        static EditFileForSearch instance = new EditFileForSearch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditFileForSearch()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditFileForSearch Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022963DEV.StationsTiles' at 165;92.", repo.CWork2022963DEV.StationsTilesInfo, new RecordItemIndex(0));
            repo.CWork2022963DEV.StationsTiles.Click("165;92");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022963DEV.BShowProgram' at 59;27.", repo.CWork2022963DEV.BShowProgramInfo, new RecordItemIndex(1));
            repo.CWork2022963DEV.BShowProgram.Click("59;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork2022963DEV.Png11' at Center.", repo.CWork2022963DEV.Png11Info, new RecordItemIndex(2));
            repo.CWork2022963DEV.Png11.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'VersionsDeDocument.A0VALIDE' at Center.", repo.VersionsDeDocument.A0VALIDEInfo, new RecordItemIndex(3));
            repo.VersionsDeDocument.A0VALIDE.DoubleClick();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'VersionsDeDocument.BOpenVersion' at 33;15.", repo.VersionsDeDocument.BOpenVersionInfo, new RecordItemIndex(4));
            //repo.VersionsDeDocument.BOpenVersion.MoveTo("33;15");
            //repo.VersionsDeDocument.BOpenVersion.MouseUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CWork2022963DEV.ColorMemo3' at 26;59.", repo.CWork2022963DEV.ColorMemo3Info, new RecordItemIndex(5));
            //repo.CWork2022963DEV.ColorMemo3.MoveTo("26;59");
            //repo.CWork2022963DEV.ColorMemo3.MouseDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022963DEV.ColorMemo3' at 14;61.", repo.CWork2022963DEV.ColorMemo3Info, new RecordItemIndex(6));
            repo.CWork2022963DEV.ColorMemo3.Click("14;61");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'testCwork' with focus on 'CWork2022963DEV'.", repo.CWork2022963DEV.SelfInfo, new RecordItemIndex(7));
            repo.CWork2022963DEV.Self.EnsureVisible();
            Keyboard.Press("testCwork");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022963DEV.BSave' at 67;44.", repo.CWork2022963DEV.BSaveInfo, new RecordItemIndex(8));
            repo.CWork2022963DEV.BSave.Click("67;44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022963DEV.BClose' at 20;39.", repo.CWork2022963DEV.BCloseInfo, new RecordItemIndex(9));
            repo.CWork2022963DEV.BClose.Click("20;39");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
