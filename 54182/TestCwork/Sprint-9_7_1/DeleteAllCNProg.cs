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
    ///The DeleteAllCNProg recording.
    /// </summary>
    [TestModule("37135091-b585-462c-b8d0-80da58ab8ed5", ModuleType.Recording, 1)]
    public partial class DeleteAllCNProg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_1Repository repository.
        /// </summary>
        public static Sprint_9_7_1Repository repo = Sprint_9_7_1Repository.Instance;

        static DeleteAllCNProg instance = new DeleteAllCNProg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteAllCNProg()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteAllCNProg Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CWork202397.RawTextDO0Percent' at 40;28.", repo.CWork202397.RawTextDO0PercentInfo, new RecordItemIndex(0));
            repo.CWork202397.RawTextDO0Percent.DoubleClick("40;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202397.BSelectAll' at 28;7.", repo.CWork202397.BSelectAllInfo, new RecordItemIndex(1));
            repo.CWork202397.BSelectAll.Click("28;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202397.BDelete' at 47;25.", repo.CWork202397.BDeleteInfo, new RecordItemIndex(2));
            repo.CWork202397.BDelete.Click("47;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirmer.ButtonOui' at 49;12.", repo.Confirmer.ButtonOuiInfo, new RecordItemIndex(3));
            repo.Confirmer.ButtonOui.Click("49;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202397.BDeleted' at 80;33.", repo.CWork202397.BDeletedInfo, new RecordItemIndex(4));
            repo.CWork202397.BDeleted.Click("80;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202397.BSelectAll' at 28;11.", repo.CWork202397.BSelectAllInfo, new RecordItemIndex(5));
            repo.CWork202397.BSelectAll.Click("28;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork202397.BDelete' at 53;33.", repo.CWork202397.BDeleteInfo, new RecordItemIndex(6));
            repo.CWork202397.BDelete.Click("53;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirmer.ButtonOui' at 24;6.", repo.Confirmer.ButtonOuiInfo, new RecordItemIndex(7));
            repo.Confirmer.ButtonOui.Click("24;6");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
