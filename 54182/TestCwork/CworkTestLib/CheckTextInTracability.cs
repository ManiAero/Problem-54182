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
    ///The CheckTextInTracability recording.
    /// </summary>
    [TestModule("38646486-7870-4de2-9d6d-e6f53188930a", ModuleType.Recording, 1)]
    public partial class CheckTextInTracability : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static CheckTextInTracability instance = new CheckTextInTracability();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckTextInTracability()
        {
            varLogAction = "<UPLOAD-USER-COMPACT> (A/0)";
            varDocName = "prg1";
            varLogSender = "Cnc-1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckTextInTracability Instance
        {
            get { return instance; }
        }

#region Variables

        string _varLogAction;

        /// <summary>
        /// Gets or sets the value of variable varLogAction.
        /// </summary>
        [TestVariable("7cbf7448-7327-4a0f-910d-3c689b8975dc")]
        public string varLogAction
        {
            get { return _varLogAction; }
            set { _varLogAction = value; }
        }

        string _varDocName;

        /// <summary>
        /// Gets or sets the value of variable varDocName.
        /// </summary>
        [TestVariable("5ef42fae-d3a2-42d0-8c70-75f12733f8f3")]
        public string varDocName
        {
            get { return _varDocName; }
            set { _varDocName = value; }
        }

        string _varLogSender;

        /// <summary>
        /// Gets or sets the value of variable varLogSender.
        /// </summary>
        [TestVariable("4c1e946b-43c6-4c75-a52b-01575b92301c")]
        public string varLogSender
        {
            get { return _varLogSender; }
            set { _varLogSender = value; }
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

            AccesDatabaseMethods.OpenDatabaseConnexion();
            Delay.Milliseconds(0);
            
            AccesDatabaseMethods.CheckLogTableContents(varLogSender, varLogAction, varDocName);
            Delay.Milliseconds(0);
            
            AccesDatabaseMethods.CloseDatabaseConnexion();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
