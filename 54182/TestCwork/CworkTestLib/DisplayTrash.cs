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
    ///The DisplayTrash recording.
    /// </summary>
    [TestModule("80078b92-5e58-42ae-b11e-18e6b7da6e60", ModuleType.Recording, 1)]
    public partial class DisplayTrash : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static DisplayTrash instance = new DisplayTrash();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DisplayTrash()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DisplayTrash Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CNC.
        /// </summary>
        [TestVariable("1b1f48b4-ccce-4153-bd8b-498c20ed219d")]
        public string CNC
        {
            get { return repo.CNC; }
            set { repo.CNC = value; }
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

            // selection CNC
            Report.Log(ReportLevel.Info, "Mouse", "selection CNC\r\nMouse Left DoubleClick item 'CworkMainForm1.Cnc' at 27;14.", repo.CworkMainForm1.CncInfo, new RecordItemIndex(0));
            repo.CworkMainForm1.Cnc.DoubleClick("27;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.BibliothequeCnc.BDeleted' at 54;26.", repo.CworkMainForm1.BibliothequeCnc.BDeletedInfo, new RecordItemIndex(1));
            repo.CworkMainForm1.BibliothequeCnc.BDeleted.Click("54;26");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
