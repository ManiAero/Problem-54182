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
    ///The SetWindowsLocationBase recording.
    /// </summary>
    [TestModule("d61262a4-9946-4a38-b22e-04f14fcc57df", ModuleType.Recording, 1)]
    public partial class SetWindowsLocationBase : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static SetWindowsLocationBase instance = new SetWindowsLocationBase();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetWindowsLocationBase()
        {
            RegionParam = "Suisse";
            RegionFormatParam = "Français (Suisse)";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetWindowsLocationBase Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RegionParam.
        /// </summary>
        [TestVariable("f34acda8-2545-4485-8c1b-e4335a78583a")]
        public string RegionParam
        {
            get { return repo.RegionParam; }
            set { repo.RegionParam = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RegionFormatParam.
        /// </summary>
        [TestVariable("091fc96a-07b5-4c0c-9f3d-e52c49220c09")]
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
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsLanguageDisplayLanguage' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsLanguageDisplayLanguageInfo, new RecordItemIndex(1));
            //repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsLanguageDisplayLanguage.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Home}'.", new RecordItemIndex(2));
            //Keyboard.Press("{Home}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RegionFormatParam'.", new RecordItemIndex(3));
            //Keyboard.Press(RegionFormatParam, 50);
            //Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(4));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.Tile' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.TileInfo, new RecordItemIndex(5));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.Tile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.RagionCombo' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.RagionComboInfo, new RecordItemIndex(6));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.RagionCombo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Home}'.", new RecordItemIndex(7));
            Keyboard.Press("{Home}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RegionParam'.", new RecordItemIndex(8));
            //Keyboard.Press(RegionParam);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(9));
            //Keyboard.Press("{Return}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.RegionItem' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.RegionItemInfo, new RecordItemIndex(10));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.RegionItem.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsRegionRegionalFormatCom' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsRegionRegionalFormatComInfo, new RecordItemIndex(11));
            //repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.SystemSettingsRegionRegionalFormatCom.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Home}'.", new RecordItemIndex(12));
            //Keyboard.Press("{Home}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RegionFormatParam'.", new RecordItemIndex(13));
            //Keyboard.Press(RegionFormatParam, 50);
            //Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(14));
            //Keyboard.Press("{Return}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNEqMicrosoftWindowsOEqMicrosoftCorp.Close' at Center.", repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.CloseInfo, new RecordItemIndex(15));
            repo.CNEqMicrosoftWindowsOEqMicrosoftCorp.Close.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
