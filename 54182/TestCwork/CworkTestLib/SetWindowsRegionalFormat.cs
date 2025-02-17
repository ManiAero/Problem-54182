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

namespace CworkTestLib
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SetWindowsRegionalFormat recording.
    /// </summary>
    [TestModule("cca4d043-8c11-42fa-accc-7551adb4d278", ModuleType.Recording, 1)]
    public partial class SetWindowsRegionalFormat : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static SetWindowsRegionalFormat instance = new SetWindowsRegionalFormat();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetWindowsRegionalFormat()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetWindowsRegionalFormat Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RegionFormatParam.
        /// </summary>
        [TestVariable("da7760c2-b0b8-43da-8b5a-2be45a16b465")]
        public string RegionFormatParam
        {
            get { return repo.RegionFormatParam; }
            set { repo.RegionFormatParam = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application '%systemroot%\\system32\\control.exe' with arguments ' /name Microsoft.RegionalAndLanguageOptions /page /p:\"Location\"' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("%systemroot%\\system32\\control.exe", " /name Microsoft.RegionalAndLanguageOptions /page /p:\"Location\"", "", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.Tile' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.TileInfo, new RecordItemIndex(1));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.Tile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsRegionRegionalFormatCom' at 433;14.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsRegionRegionalFormatComInfo, new RecordItemIndex(2));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsRegionRegionalFormatCom.Click("433;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Home}'.", new RecordItemIndex(3));
            Keyboard.Press("{Home}");
            Delay.Milliseconds(980);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.FrancaisSuisse' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.FrancaisSuisseInfo, new RecordItemIndex(4));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.FrancaisSuisse.Click();
            Delay.Milliseconds(4700);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.Close' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.CloseInfo, new RecordItemIndex(5));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.Close.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
