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

namespace Sprint_9_6_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LogWithNewUser recording.
    /// </summary>
    [TestModule("fe4d9b22-1f57-4c3f-84ca-f35e04cd6c32", ModuleType.Recording, 1)]
    public partial class LogWithNewUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_2Repository repository.
        /// </summary>
        public static Sprint_9_6_2Repository repo = Sprint_9_6_2Repository.Instance;

        static LogWithNewUser instance = new LogWithNewUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogWithNewUser()
        {
            UserPsw = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogWithNewUser Instance
        {
            get { return instance; }
        }

#region Variables

        string _UserPsw;

        /// <summary>
        /// Gets or sets the value of variable UserPsw.
        /// </summary>
        [TestVariable("9fde0a9b-c88b-4f1f-a2fc-3c2cec9830b0")]
        public string UserPsw
        {
            get { return _UserPsw; }
            set { _UserPsw = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.OuvertureDeSessionCWork.ComboUser' at 279;17.", repo.CworkMainForm.OuvertureDeSessionCWork.ComboUserInfo, new RecordItemIndex(0));
            repo.CworkMainForm.OuvertureDeSessionCWork.ComboUser.Click("279;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'None.Toto' at 17;8.", repo.None.TotoInfo, new RecordItemIndex(1));
            repo.None.Toto.Click("17;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.OuvertureDeSessionCWork.ElementBOk' at 17;20.", repo.CworkMainForm.OuvertureDeSessionCWork.ElementBOkInfo, new RecordItemIndex(2));
            repo.CworkMainForm.OuvertureDeSessionCWork.ElementBOk.Click("17;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'CWork2022962DEV.Atelier1'", repo.CWork2022962DEV.Atelier1Info, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.CWork2022962DEV.Atelier1Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Atelier1') on item 'CWork2022962DEV.Atelier1'.", repo.CWork2022962DEV.Atelier1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.CWork2022962DEV.Atelier1Info, "Text", "Atelier1");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
