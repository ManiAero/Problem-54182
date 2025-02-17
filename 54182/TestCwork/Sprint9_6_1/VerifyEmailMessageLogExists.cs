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

namespace Sprint9_6_1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyEmailMessageLogExists recording.
    /// </summary>
    [TestModule("313f6596-ca3a-4908-97ce-4e7c052793b7", ModuleType.Recording, 1)]
    public partial class VerifyEmailMessageLogExists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint9_6_1Repository repository.
        /// </summary>
        public static Sprint9_6_1Repository repo = Sprint9_6_1Repository.Instance;

        static VerifyEmailMessageLogExists instance = new VerifyEmailMessageLogExists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyEmailMessageLogExists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyEmailMessageLogExists Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.BSoftwareEvent' at 30;32.", repo.CWork202296DEV.BSoftwareEventInfo, new RecordItemIndex(0));
            repo.CWork202296DEV.BSoftwareEvent.Click("30;32");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (RawText='Création de TIdMessageBuilderHtml OK') on item 'CWork202296DEV.CreationDeTIdMessageBuilderHtmlOK'.", repo.CWork202296DEV.CreationDeTIdMessageBuilderHtmlOKInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.CWork202296DEV.CreationDeTIdMessageBuilderHtmlOKInfo, "RawText", "Création de TIdMessageBuilderHtml OK");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202296DEV.BSoftwareEvent' at 30;32.", repo.CWork202296DEV.BSoftwareEventInfo, new RecordItemIndex(2));
            repo.CWork202296DEV.BSoftwareEvent.Click("30;32");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
