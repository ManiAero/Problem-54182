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
    ///The Clean71Directory recording.
    /// </summary>
    [TestModule("ea841446-3243-4065-936e-e5be0fa449b0", ModuleType.Recording, 1)]
    public partial class Clean71Directory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_1Repository repository.
        /// </summary>
        public static Sprint_9_7_1Repository repo = Sprint_9_7_1Repository.Instance;

        static Clean71Directory instance = new Clean71Directory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Clean71Directory()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Clean71Directory Instance
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

            CworkTestLib.UserCodeCollection.RunProgramAndWait("TestPrep\\CleanDirForExportMultiMazacamTest.BAT", "", ValueConverter.ArgumentFromString<int>("waitSeconds", "1"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
