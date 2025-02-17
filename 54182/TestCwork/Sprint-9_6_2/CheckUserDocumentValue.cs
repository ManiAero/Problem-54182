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
    ///The CheckUserDocumentValue recording.
    /// </summary>
    [TestModule("bfe7c1b1-0af5-4dcc-b0df-6c10a2d57f56", ModuleType.Recording, 1)]
    public partial class CheckUserDocumentValue : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_2Repository repository.
        /// </summary>
        public static Sprint_9_6_2Repository repo = Sprint_9_6_2Repository.Instance;

        static CheckUserDocumentValue instance = new CheckUserDocumentValue();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckUserDocumentValue()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckUserDocumentValue Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CworkMainForm1.Png' at 65;9.", repo.CworkMainForm1.PngInfo, new RecordItemIndex(1));
            repo.CworkMainForm1.Png.DoubleClick("65;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.BShowTrace' at 13;18.", repo.VersionsDeDocument.BShowTraceInfo, new RecordItemIndex(2));
            repo.VersionsDeDocument.BShowTrace.Click("13;18");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse None Click item 'VersionsDeDocument.TOTO' at 20;11.", repo.VersionsDeDocument.TOTOInfo, new RecordItemIndex(3));
            //repo.VersionsDeDocument.TOTO.Click(System.Windows.Forms.MouseButtons.None, "20;11");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'TOTO') on item 'VersionsDeDocument.TOTO'.", repo.VersionsDeDocument.TOTOInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.VersionsDeDocument.TOTOInfo, "Text", "TOTO");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionsDeDocument.Fermer' at 14;17.", repo.VersionsDeDocument.FermerInfo, new RecordItemIndex(5));
            repo.VersionsDeDocument.Fermer.Click("14;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2022962DEV.TAdvSmoothToggleButton' at 25;35.", repo.CWork2022962DEV.TAdvSmoothToggleButtonInfo, new RecordItemIndex(6));
            repo.CWork2022962DEV.TAdvSmoothToggleButton.Click("25;35");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
