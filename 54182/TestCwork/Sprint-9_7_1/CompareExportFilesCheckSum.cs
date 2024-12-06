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
    ///The CompareExportFilesCheckSum recording.
    /// </summary>
    [TestModule("693d025b-0c3e-4b8d-a8b1-249f5a5ad35c", ModuleType.Recording, 1)]
    public partial class CompareExportFilesCheckSum : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_1Repository repository.
        /// </summary>
        public static Sprint_9_7_1Repository repo = Sprint_9_7_1Repository.Instance;

        static CompareExportFilesCheckSum instance = new CompareExportFilesCheckSum();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CompareExportFilesCheckSum()
        {
            CompCheckSum = "TestPrep\\ChecksumComp.bat";
            CMT = "Prog2.CMT";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CompareExportFilesCheckSum Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompCheckSum;

        /// <summary>
        /// Gets or sets the value of variable CompCheckSum.
        /// </summary>
        [TestVariable("3cb171fb-661b-480d-ae2a-0044339ace82")]
        public string CompCheckSum
        {
            get { return _CompCheckSum; }
            set { _CompCheckSum = value; }
        }

        string _CMT;

        /// <summary>
        /// Gets or sets the value of variable CMT.
        /// </summary>
        [TestVariable("21a38d1b-6734-43b3-b9ad-4a0457a26996")]
        public string CMT
        {
            get { return _CMT; }
            set { _CMT = value; }
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

            CworkTestLib.UserCodeCollection.RunProgramAndWait("TestPrep\\ChecksumComp.bat", CMT, ValueConverter.ArgumentFromString<int>("waitSeconds", "10"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
