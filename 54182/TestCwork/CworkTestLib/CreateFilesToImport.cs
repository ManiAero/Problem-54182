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
    ///The CreateFilesToImport recording.
    /// </summary>
    [TestModule("0ea66e3a-18a8-4fe7-8a5e-4fe9816f8ad2", ModuleType.Recording, 1)]
    public partial class CreateFilesToImport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static CreateFilesToImport instance = new CreateFilesToImport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateFilesToImport()
        {
            NbFiles = "8";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateFilesToImport Instance
        {
            get { return instance; }
        }

#region Variables

        string _NbFiles;

        /// <summary>
        /// Gets or sets the value of variable NbFiles.
        /// </summary>
        [TestVariable("efa82801-f7f6-4870-8b6d-57ae60dca4b1")]
        public string NbFiles
        {
            get { return _NbFiles; }
            set { _NbFiles = value; }
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

            UserCodeCollection.RunProgramAndWait("TestPrep\\genfic.bat", NbFiles, ValueConverter.ArgumentFromString<int>("waitSeconds", "180"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
