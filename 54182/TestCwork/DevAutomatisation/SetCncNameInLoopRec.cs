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

namespace DevAutomatisation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SetCncNameInLoopRec recording.
    /// </summary>
    [TestModule("255d91f7-5934-4148-bf08-c949cca2162c", ModuleType.Recording, 1)]
    public partial class SetCncNameInLoopRec : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DevAutomatisationRepository repository.
        /// </summary>
        public static DevAutomatisationRepository repo = DevAutomatisationRepository.Instance;

        static SetCncNameInLoopRec instance = new SetCncNameInLoopRec();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetCncNameInLoopRec()
        {
            CncNameInLoop = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetCncNameInLoopRec Instance
        {
            get { return instance; }
        }

#region Variables

        string _CncNameInLoop;

        /// <summary>
        /// Gets or sets the value of variable CncNameInLoop.
        /// </summary>
        [TestVariable("24cf6ab3-5fcb-4d9d-acab-f9602412b072")]
        public string CncNameInLoop
        {
            get { return _CncNameInLoop; }
            set { _CncNameInLoop = value; }
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

            CncNameInLoop = SetCncNameInLoop();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
