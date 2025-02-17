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

namespace Sprint_9_8
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckIfErrPopupExist recording.
    /// </summary>
    [TestModule("fa5954e1-050b-4064-a03f-be3641c46ac8", ModuleType.Recording, 1)]
    public partial class CheckIfErrPopupExist : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_8Repository repository.
        /// </summary>
        public static Sprint_9_8Repository repo = Sprint_9_8Repository.Instance;

        static CheckIfErrPopupExist instance = new CheckIfErrPopupExist();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckIfErrPopupExist()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckIfErrPopupExist Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'Cwork202498DEV.Text65535'.", repo.Cwork202498DEV.Text65535Info, new RecordItemIndex(0));
            Validate.NotExists(repo.Cwork202498DEV.Text65535Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
