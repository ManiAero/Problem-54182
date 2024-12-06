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
    ///The InsertKepServerExpressionInCncstatableSqlServer recording.
    /// </summary>
    [TestModule("2d6e3286-677b-4643-9766-383d1c0bc746", ModuleType.Recording, 1)]
    public partial class InsertKepServerExpressionInCncstatableSqlServer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static InsertKepServerExpressionInCncstatableSqlServer instance = new InsertKepServerExpressionInCncstatableSqlServer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertKepServerExpressionInCncstatableSqlServer()
        {
            CncId = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertKepServerExpressionInCncstatableSqlServer Instance
        {
            get { return instance; }
        }

#region Variables

        string _CncId;

        /// <summary>
        /// Gets or sets the value of variable CncId.
        /// </summary>
        [TestVariable("846916a1-748a-4750-8a2f-9cc6f52dec7b")]
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

            InsertKepServerExpressionSqlServer(ValueConverter.ArgumentFromString<int>("CncId", CncId));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
