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

namespace Sprint9_6
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SendCallPng1InFolderWithTed recording.
    /// </summary>
    [TestModule("c20b9d0a-ee21-41a0-b299-5d41c990e14d", ModuleType.Recording, 1)]
    public partial class SendCallPng1InFolderWithTed : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6Repository repository.
        /// </summary>
        public static Sprint_9_6Repository repo = Sprint_9_6Repository.Instance;

        static SendCallPng1InFolderWithTed instance = new SendCallPng1InFolderWithTed();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SendCallPng1InFolderWithTed()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SendCallPng1InFolderWithTed Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTEDSCDemonstrationSoftwareV.LabelF2' at 35;14.", repo.FormTEDSCDemonstrationSoftwareV.LabelF2Info, new RecordItemIndex(0));
            repo.FormTEDSCDemonstrationSoftwareV.LabelF2.Click("35;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTEDSCDemonstrationSoftwareV.Memo1' at 25;8.", repo.FormTEDSCDemonstrationSoftwareV.Memo1Info, new RecordItemIndex(1));
            repo.FormTEDSCDemonstrationSoftwareV.Memo1.Click("25;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '%{Return}:5000{Return}(png1){Return}(ImportFAO\\){Return}%{Return}' with focus on 'FormTEDSCDemonstrationSoftwareV.Memo1'.", repo.FormTEDSCDemonstrationSoftwareV.Memo1Info, new RecordItemIndex(2));
            repo.FormTEDSCDemonstrationSoftwareV.Memo1.PressKeys("%{Return}:5000{Return}(png1){Return}(ImportFAO\\){Return}%{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTEDSCDemonstrationSoftwareV.BtEnvoi' at 29;12.", repo.FormTEDSCDemonstrationSoftwareV.BtEnvoiInfo, new RecordItemIndex(3));
            repo.FormTEDSCDemonstrationSoftwareV.BtEnvoi.Click("29;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTEDSCDemonstrationSoftwareV.LabelF2' at 28;11.", repo.FormTEDSCDemonstrationSoftwareV.LabelF2Info, new RecordItemIndex(4));
            repo.FormTEDSCDemonstrationSoftwareV.LabelF2.Click("28;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (RawText='ÎĈČĐĎĂĪĜĞǺĨĆĎĮ ÎĨĈĆÅ') on item 'FormTEDSCDemonstrationSoftwareV.IĈČĐĎĂĪĜĞǺĨĆĎĮIĨĈĆA'.", repo.FormTEDSCDemonstrationSoftwareV.IĈČĐĎĂĪĜĞǺĨĆĎĮIĨĈĆAInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FormTEDSCDemonstrationSoftwareV.IĈČĐĎĂĪĜĞǺĨĆĎĮIĨĈĆAInfo, "RawText", "ÎĈČĐĎĂĪĜĞǺĨĆĎĮ ÎĨĈĆÅ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(6));
            Delay.Duration(30000, false);
            
            // ligne %OPG1  n'exite pas
            Report.Log(ReportLevel.Info, "Validation", "ligne %OPG1  n'exite pas\r\nValidating AttributeNotEqual (Text!='%\r\nOpng1\r\n(png1)\r\nG10\r\n%') on item 'FormTEDSCDemonstrationSoftwareV.Memo1'.", repo.FormTEDSCDemonstrationSoftwareV.Memo1Info, new RecordItemIndex(7));
            Validate.AttributeNotEqual(repo.FormTEDSCDemonstrationSoftwareV.Memo1Info, "Text", "%\r\nOpng1\r\n(png1)\r\nG10\r\n%");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
