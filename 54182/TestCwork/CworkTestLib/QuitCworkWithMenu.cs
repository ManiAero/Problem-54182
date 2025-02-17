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
    ///The QuitCworkWithMenu recording.
    /// </summary>
    [TestModule("18d918e9-dd19-4efa-bc7c-4325a6e1cd9b", ModuleType.Recording, 1)]
    public partial class QuitCworkWithMenu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static QuitCworkWithMenu instance = new QuitCworkWithMenu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public QuitCworkWithMenu()
        {
            QuitItemNum = "11";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static QuitCworkWithMenu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable QuitItemNum.
        /// </summary>
        [TestVariable("44eaca36-bd5c-4a7c-b26a-8108081eb466")]
        public string QuitItemNum
        {
            get { return repo.QuitItemNum; }
            set { repo.QuitItemNum = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.CWork202195.MenuItemFichier' at Center.", repo.CworkMainForm.CWork202195.MenuItemFichierInfo, new RecordItemIndex(0));
            //repo.CworkMainForm.CWork202195.MenuItemFichier.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Cwork2024983DEV.MenuItemFichier' at Center.", repo.Cwork2024983DEV.MenuItemFichierInfo, new RecordItemIndex(1));
            repo.Cwork2024983DEV.MenuItemFichier.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CworkMainForm.Cwork.MenuItemQuit' at 58;14.", repo.CworkMainForm.Cwork.MenuItemQuitInfo, new RecordItemIndex(2));
            repo.CworkMainForm.Cwork.MenuItemQuit.Click("58;14");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
