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

namespace Sprint_9_7_4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ConfCndWithInexistantVar recording.
    /// </summary>
    [TestModule("d07a2a07-3ca6-447c-8fa3-71cdd534b856", ModuleType.Recording, 1)]
    public partial class ConfCndWithInexistantVar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_4Repository repository.
        /// </summary>
        public static Sprint_9_7_4Repository repo = Sprint_9_7_4Repository.Instance;

        static ConfCndWithInexistantVar instance = new ConfCndWithInexistantVar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfCndWithInexistantVar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfCndWithInexistantVar Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023973DEV.Cnc1' at 41;10.", repo.CWork2023973DEV.Cnc1Info, new RecordItemIndex(0));
            repo.CWork2023973DEV.Cnc1.Click("41;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWork2023973DEV.BProperty' at 59;31.", repo.CWork2023973DEV.BPropertyInfo, new RecordItemIndex(1));
            repo.CWork2023973DEV.BProperty.Click("59;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChoixDuneConfiguration.Fermer' at 17;11.", repo.ChoixDuneConfiguration.FermerInfo, new RecordItemIndex(2));
            repo.ChoixDuneConfiguration.Fermer.Click("17;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ProprietesPourCnc1.Commandes' at 30;5.", repo.ProprietesPourCnc1.CommandesInfo, new RecordItemIndex(3));
            repo.ProprietesPourCnc1.Commandes.DoubleClick("30;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TabSheet11.ActiverLesCommandes' at 6;7.", repo.ProprietesPourCnc1.TabSheet11.ActiverLesCommandesInfo, new RecordItemIndex(4));
            repo.ProprietesPourCnc1.TabSheet11.ActiverLesCommandes.Click("6;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TabSheet11.Production' at 45;8.", repo.ProprietesPourCnc1.TabSheet11.ProductionInfo, new RecordItemIndex(5));
            repo.ProprietesPourCnc1.TabSheet11.Production.Click("45;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.MemVarPascal' at 24;18.", repo.ProprietesPourCnc1.MemVarPascalInfo, new RecordItemIndex(6));
            repo.ProprietesPourCnc1.MemVarPascal.Click("24;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '({{@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Channel1.Device2.Tag1@} = 3) and ({{@VAR|INT|mavariablenonexistante@} = 4)' with focus on 'ProprietesPourCnc1.MemVarPascal'.", repo.ProprietesPourCnc1.MemVarPascalInfo, new RecordItemIndex(7));
            repo.ProprietesPourCnc1.MemVarPascal.PressKeys("({{@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Channel1.Device2.Tag1@} = 3) and ({{@VAR|INT|mavariablenonexistante@} = 4)");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.TabSheet11.BCommandValid' at 13;11.", repo.ProprietesPourCnc1.TabSheet11.BCommandValidInfo, new RecordItemIndex(8));
            repo.ProprietesPourCnc1.TabSheet11.BCommandValid.Click("13;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProprietesPourCnc1.ButtonAppliquer' at 38;15.", repo.ProprietesPourCnc1.ButtonAppliquerInfo, new RecordItemIndex(9));
            repo.ProprietesPourCnc1.ButtonAppliquer.Click("38;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
