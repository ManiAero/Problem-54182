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
    ///The CheckOtherUserDocumentValue recording.
    /// </summary>
    [TestModule("cb48f330-4a13-4614-b56b-f3564035e7de", ModuleType.Recording, 1)]
    public partial class CheckOtherUserDocumentValue : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_2Repository repository.
        /// </summary>
        public static Sprint_9_6_2Repository repo = Sprint_9_6_2Repository.Instance;

        static CheckOtherUserDocumentValue instance = new CheckOtherUserDocumentValue();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckOtherUserDocumentValue()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckOtherUserDocumentValue Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork2022962DEV.StationsTiles' at 192;96.", repo.CWork2022962DEV.StationsTilesInfo, new RecordItemIndex(0));
            repo.CWork2022962DEV.StationsTiles.DoubleClick("192;96");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F5}' with focus on 'CWork2022962DEV'.", repo.CWork2022962DEV.SelfInfo, new RecordItemIndex(2));
            repo.CWork2022962DEV.Self.EnsureVisible();
            Keyboard.Press("{F5}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork2022962DEV.NUMPLANAsteriskA21131' at 39;5.", repo.CWork2022962DEV.NUMPLANAsteriskA21131Info, new RecordItemIndex(3));
            repo.CWork2022962DEV.NUMPLANAsteriskA21131.DoubleClick("39;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.BShowTrace' at 15;15.", repo.VersionsDeDocument.BShowTraceInfo, new RecordItemIndex(4));
            repo.VersionsDeDocument.BShowTrace.Click("15;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.Cnc1' at 50;14.", repo.VersionsDeDocument.Cnc1Info, new RecordItemIndex(5));
            repo.VersionsDeDocument.Cnc1.Click("50;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Cnc-1') on item 'VersionsDeDocument.Cnc1'.", repo.VersionsDeDocument.Cnc1Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.VersionsDeDocument.Cnc1Info, "Text", "Cnc-1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.Fermer' at 14;17.", repo.VersionsDeDocument.FermerInfo, new RecordItemIndex(7));
            repo.VersionsDeDocument.Fermer.Click("14;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.TAdvSmoothToggleButton' at 25;35.", repo.CWork2022962DEV.TAdvSmoothToggleButtonInfo, new RecordItemIndex(8));
            repo.CWork2022962DEV.TAdvSmoothToggleButton.Click("25;35");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
