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

namespace Sprint_9_7_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SendRequestResetPartNotAutorized recording.
    /// </summary>
    [TestModule("59588810-2361-4df7-8c6c-d16df097d10a", ModuleType.Recording, 1)]
    public partial class SendRequestResetPartNotAutorized : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_7_2Repository repository.
        /// </summary>
        public static Sprint_9_7_2Repository repo = Sprint_9_7_2Repository.Instance;

        static SendRequestResetPartNotAutorized instance = new SendRequestResetPartNotAutorized();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SendRequestResetPartNotAutorized()
        {
            usr = "Opérateur";
            psw = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SendRequestResetPartNotAutorized Instance
        {
            get { return instance; }
        }

#region Variables

        string _usr;

        /// <summary>
        /// Gets or sets the value of variable usr.
        /// </summary>
        [TestVariable("6d366ebd-f7cd-4228-ad52-3a2947f96f89")]
        public string usr
        {
            get { return _usr; }
            set { _usr = value; }
        }

        string _psw;

        /// <summary>
        /// Gets or sets the value of variable psw.
        /// </summary>
        [TestVariable("9fc9f2e7-5cd0-4ee8-98ae-957e8831ced4")]
        public string psw
        {
            get { return _psw; }
            set { _psw = value; }
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

            CallResetPartNotAutorizedApi(usr, psw);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
