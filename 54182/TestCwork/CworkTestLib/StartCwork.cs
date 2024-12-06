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
    ///The StartCwork recording.
    /// </summary>
    [TestModule("438821e3-ebd5-48c1-b943-4176032bb042", ModuleType.Recording, 1)]
    public partial class StartCwork : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static StartCwork instance = new StartCwork();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartCwork()
        {
            AppToRun = "C:\\Program Files (x86)\\Smcom Software\\Cwork\\bin\\Cwork.exe";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartCwork Instance
        {
            get { return instance; }
        }

#region Variables

        string _AppToRun;

        /// <summary>
        /// Gets or sets the value of variable AppToRun.
        /// </summary>
        [TestVariable("cedec09d-c754-4917-8e01-c7004855587d")]
        public string AppToRun
        {
            get { return _AppToRun; }
            set { _AppToRun = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $AppToRun with arguments '/TEST' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(AppToRun, "/TEST", "", false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
