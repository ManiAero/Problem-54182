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

namespace Sprint_9_6_3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FusionSuivantEtPrecedent recording.
    /// </summary>
    [TestModule("c4352c52-636c-4f05-9930-a256fa6edd7c", ModuleType.Recording, 1)]
    public partial class FusionSuivantEtPrecedent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_3Repository repository.
        /// </summary>
        public static Sprint_9_6_3Repository repo = Sprint_9_6_3Repository.Instance;

        static FusionSuivantEtPrecedent instance = new FusionSuivantEtPrecedent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FusionSuivantEtPrecedent()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FusionSuivantEtPrecedent Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.Panne' at 35;9.", repo.CworkMainForm.CWork202195.PanneInfo, new RecordItemIndex(0));
            repo.CworkMainForm.CWork202195.Panne.Click("35;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BEditCurrentState' at 37;8.", repo.CworkMainForm.CWork202195.BEditCurrentStateInfo, new RecordItemIndex(1));
            repo.CworkMainForm.CWork202195.BEditCurrentState.Click("37;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.CbReplaceStateMono' at 212;15.", repo.CworkMainForm.CWork202195.CbReplaceStateMonoInfo, new RecordItemIndex(2));
            repo.CworkMainForm.CWork202195.CbReplaceStateMono.Click("212;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'None.Reglage' at 36;4.", repo.None.ReglageInfo, new RecordItemIndex(3));
            repo.None.Reglage.Click("36;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BMonoEditConfirm' at 42;13.", repo.CworkMainForm.CWork202195.BMonoEditConfirmInfo, new RecordItemIndex(4));
            repo.CworkMainForm.CWork202195.BMonoEditConfirm.Click("42;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'CworkMainForm.CWork202195.BtSaveTops'.", repo.CworkMainForm.CWork202195.BtSaveTopsInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.CworkMainForm.CWork202195.BtSaveTopsInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.BtSaveTops' at 58;39.", repo.CworkMainForm.CWork202195.BtSaveTopsInfo, new RecordItemIndex(6));
            repo.CworkMainForm.CWork202195.BtSaveTops.Click("58;39");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='03:00:00') on item 'CworkMainForm.CWork202195.Cell030000'.", repo.CworkMainForm.CWork202195.Cell030000Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.CworkMainForm.CWork202195.Cell030000Info, "Text", "03:00:00");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Réglage') on item 'CworkMainForm.CWork202195.Reglage1'.", repo.CworkMainForm.CWork202195.Reglage1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.CworkMainForm.CWork202195.Reglage1Info, "Text", "Réglage");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Désengagement') on item 'CworkMainForm.CWork202195.Desengagement'.", repo.CworkMainForm.CWork202195.DesengagementInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.CworkMainForm.CWork202195.DesengagementInfo, "Text", "Désengagement");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Production') on item 'CworkMainForm.CWork202195.Production'.", repo.CworkMainForm.CWork202195.ProductionInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.CworkMainForm.CWork202195.ProductionInfo, "Text", "Production");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
