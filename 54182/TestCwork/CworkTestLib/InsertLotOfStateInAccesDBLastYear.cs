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
    ///The InsertLotOfStateInAccesDBLastYear recording.
    /// </summary>
    [TestModule("dbdcb961-0dec-424f-b014-18e29e036ade", ModuleType.Recording, 1)]
    public partial class InsertLotOfStateInAccesDBLastYear : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static InsertLotOfStateInAccesDBLastYear instance = new InsertLotOfStateInAccesDBLastYear();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertLotOfStateInAccesDBLastYear()
        {
            cnc = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertLotOfStateInAccesDBLastYear Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable cnc.
        /// </summary>
        [TestVariable("a298b654-8685-4d2f-a4a5-3f8443360be5")]
        public string cnc
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

            AccesDatabaseMethods.OpenDatabaseConnexion();
            Delay.Milliseconds(0);
            
            AccesDatabaseMethods.ClearTopTableContents(ValueConverter.ArgumentFromString<int>("cnc", cnc));
            Delay.Milliseconds(0);
            
            AccesDatabaseMethods.insertLotOfstatesInTops2(ValueConverter.ArgumentFromString<int>("cnc", cnc));
            Delay.Milliseconds(0);
            
            //AccesDatabaseMethods.insertLotOfstatesInTops3(ValueConverter.ArgumentFromString<int>("cnc", cnc));
            //Delay.Milliseconds(0);
            
            AccesDatabaseMethods.CloseDatabaseConnexion();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
