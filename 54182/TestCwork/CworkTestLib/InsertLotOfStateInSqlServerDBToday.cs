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
    ///The InsertLotOfStateInSqlServerDBToday recording.
    /// </summary>
    [TestModule("325e4d36-57da-4374-b564-4658eb6bc5b7", ModuleType.Recording, 1)]
    public partial class InsertLotOfStateInSqlServerDBToday : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static InsertLotOfStateInSqlServerDBToday instance = new InsertLotOfStateInSqlServerDBToday();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertLotOfStateInSqlServerDBToday()
        {
            StateDuration = "60";
            CncName = "Cnc_1";
            CncId = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertLotOfStateInSqlServerDBToday Instance
        {
            get { return instance; }
        }

#region Variables

        string _StateDuration;

        /// <summary>
        /// Gets or sets the value of variable StateDuration.
        /// </summary>
        [TestVariable("25c71bcc-45fc-461d-b1f9-7b69b13b7786")]
        public string StateDuration
        {
            get { return _StateDuration; }
            set { _StateDuration = value; }
        }

        string _CncName;

        /// <summary>
        /// Gets or sets the value of variable CncName.
        /// </summary>
        [TestVariable("8b3910e2-3f29-4ff3-8c7f-d8135ee4ea75")]
        public string CncName
        {
            get { return _CncName; }
            set { _CncName = value; }
        }

        string _CncId;

        /// <summary>
        /// Gets or sets the value of variable CncId.
        /// </summary>
        [TestVariable("bc159c6e-822b-46d0-affa-1ee577a8d3ef")]
        public string CncId
        {
            get { return _CncId; }
            set { _CncId = value; }
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

            InsertStatesIntoDbSqlServerToday(ValueConverter.ArgumentFromString<int>("StateDuration", StateDuration), ValueConverter.ArgumentFromString<int>("CncId", CncId), CncName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
