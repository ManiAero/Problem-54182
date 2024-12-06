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
    ///The DeleteAllProgFromCNC recording.
    /// </summary>
    [TestModule("d5c47431-86dd-4724-ab36-ff902c5f94c1", ModuleType.Recording, 1)]
    public partial class DeleteAllProgFromCNC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_2Repository repository.
        /// </summary>
        public static Sprint_9_6_2Repository repo = Sprint_9_6_2Repository.Instance;

        static DeleteAllProgFromCNC instance = new DeleteAllProgFromCNC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteAllProgFromCNC()
        {
            Prg = "png1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteAllProgFromCNC Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Prg.
        /// </summary>
        [TestVariable("4b6e5e39-9429-40aa-ab57-fa5677366fb4")]
        public string Prg
        {
            get { return repo.Prg; }
            set { repo.Prg = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CworkMainForm1.RawTextDO0Percent' at 15;35.", repo.CworkMainForm1.RawTextDO0PercentInfo, new RecordItemIndex(0));
            repo.CworkMainForm1.RawTextDO0Percent.DoubleClick("15;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.BibliothequeCnc.BSelectAll' at 26;9.", repo.CworkMainForm1.BibliothequeCnc.BSelectAllInfo, new RecordItemIndex(1));
            repo.CworkMainForm1.BibliothequeCnc.BSelectAll.Click("26;9");
            Delay.Milliseconds(0);
            
            // Effacement
            Report.Log(ReportLevel.Info, "Mouse", "Effacement\r\nMouse Left Click item 'CworkMainForm1.BibliothequeCnc.BDelete' at 54;25.", repo.CworkMainForm1.BibliothequeCnc.BDeleteInfo, new RecordItemIndex(2));
            repo.CworkMainForm1.BibliothequeCnc.BDelete.Click("54;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirmer.ButtonOui1' at 44;9.", repo.Confirmer.ButtonOui1Info, new RecordItemIndex(3));
            repo.Confirmer.ButtonOui1.Click("44;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.BibliothequeCnc.BDeleted' at 54;26.", repo.CworkMainForm1.BibliothequeCnc.BDeletedInfo, new RecordItemIndex(4));
            repo.CworkMainForm1.BibliothequeCnc.BDeleted.Click("54;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm1.BibliothequeCnc.BSelectAll' at 26;9.", repo.CworkMainForm1.BibliothequeCnc.BSelectAllInfo, new RecordItemIndex(5));
            repo.CworkMainForm1.BibliothequeCnc.BSelectAll.Click("26;9");
            Delay.Milliseconds(0);
            
            // Effacement
            Report.Log(ReportLevel.Info, "Mouse", "Effacement\r\nMouse Left Click item 'CworkMainForm1.BibliothequeCnc.BDelete' at 54;25.", repo.CworkMainForm1.BibliothequeCnc.BDeleteInfo, new RecordItemIndex(6));
            repo.CworkMainForm1.BibliothequeCnc.BDelete.Click("54;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirmer.ButtonOui1' at 42;7.", repo.Confirmer.ButtonOui1Info, new RecordItemIndex(7));
            repo.Confirmer.ButtonOui1.Click("42;7");
            Delay.Milliseconds(0);
            
            // Retour atelier
            Report.Log(ReportLevel.Info, "Mouse", "Retour atelier\r\nMouse Left Click item 'CWork2022962DEV.TAdvSmoothToggleButton' at 33;34.", repo.CWork2022962DEV.TAdvSmoothToggleButtonInfo, new RecordItemIndex(8));
            repo.CWork2022962DEV.TAdvSmoothToggleButton.Click("33;34");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
