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
    ///The CallSendAsyncProgApi recording.
    /// </summary>
    [TestModule("2401f33b-2ad7-406b-bbc8-cbf355d61271", ModuleType.Recording, 1)]
    public partial class CallSendAsyncProgApi : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CworkTestLibRepository repository.
        /// </summary>
        public static CworkTestLibRepository repo = CworkTestLibRepository.Instance;

        static CallSendAsyncProgApi instance = new CallSendAsyncProgApi();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CallSendAsyncProgApi()
        {
            varCncId = "0";
            varDocumentName = "";
            varDocExtension = "";
            varSourceFolder = "";
            varUser = "";
            varpsw = "";
            varExpectedRes = "";
            varDestinationFolder = "";
            varDestinationFolderMode = "";
            varOverride = "False";
            varWaitBeforQuerySendStatus = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CallSendAsyncProgApi Instance
        {
            get { return instance; }
        }

#region Variables

        string _varCncId;

        /// <summary>
        /// Gets or sets the value of variable varCncId.
        /// </summary>
        [TestVariable("fd6dbdb3-e01c-479a-ae8c-89d073044e08")]
        public string varCncId
        {
            get { return _varCncId; }
            set { _varCncId = value; }
        }

        string _varDocumentName;

        /// <summary>
        /// Gets or sets the value of variable varDocumentName.
        /// </summary>
        [TestVariable("1f52682a-3634-41ac-a6b3-6555b45b8c5f")]
        public string varDocumentName
        {
            get { return _varDocumentName; }
            set { _varDocumentName = value; }
        }

        string _varDocExtension;

        /// <summary>
        /// Gets or sets the value of variable varDocExtension.
        /// </summary>
        [TestVariable("b38a1580-5daa-45a3-92f1-19f522f51900")]
        public string varDocExtension
        {
            get { return _varDocExtension; }
            set { _varDocExtension = value; }
        }

        string _varSourceFolder;

        /// <summary>
        /// Gets or sets the value of variable varSourceFolder.
        /// </summary>
        [TestVariable("f1022dc7-f722-42f3-924a-41e4ee7c9c26")]
        public string varSourceFolder
        {
            get { return _varSourceFolder; }
            set { _varSourceFolder = value; }
        }

        string _varUser;

        /// <summary>
        /// Gets or sets the value of variable varUser.
        /// </summary>
        [TestVariable("1d6e1679-0a11-46ea-981e-235e661d62d9")]
        public string varUser
        {
            get { return _varUser; }
            set { _varUser = value; }
        }

        string _varpsw;

        /// <summary>
        /// Gets or sets the value of variable varpsw.
        /// </summary>
        [TestVariable("38b78081-e681-48a5-8ae8-4e3552629f97")]
        public string varpsw
        {
            get { return _varpsw; }
            set { _varpsw = value; }
        }

        string _varExpectedRes;

        /// <summary>
        /// Gets or sets the value of variable varExpectedRes.
        /// </summary>
        [TestVariable("3bd679c0-b569-42c8-bdf6-01697ccca806")]
        public string varExpectedRes
        {
            get { return _varExpectedRes; }
            set { _varExpectedRes = value; }
        }

        string _varDestinationFolder;

        /// <summary>
        /// Gets or sets the value of variable varDestinationFolder.
        /// </summary>
        [TestVariable("41bdc882-9073-4d02-a76e-4f64350fdc72")]
        public string varDestinationFolder
        {
            get { return _varDestinationFolder; }
            set { _varDestinationFolder = value; }
        }

        string _varDestinationFolderMode;

        /// <summary>
        /// Gets or sets the value of variable varDestinationFolderMode.
        /// </summary>
        [TestVariable("b1d58fdd-b909-4bbd-9151-715ea0b151f9")]
        public string varDestinationFolderMode
        {
            get { return _varDestinationFolderMode; }
            set { _varDestinationFolderMode = value; }
        }

        string _varOverride;

        /// <summary>
        /// Gets or sets the value of variable varOverride.
        /// </summary>
        [TestVariable("48ad4443-b09b-4566-986a-ba80789119b6")]
        public string varOverride
        {
            get { return _varOverride; }
            set { _varOverride = value; }
        }

        string _varWaitBeforQuerySendStatus;

        /// <summary>
        /// Gets or sets the value of variable varWaitBeforQuerySendStatus.
        /// </summary>
        [TestVariable("b19e57d5-27d9-43b7-9b6e-04ab27bd2f8d")]
        public string varWaitBeforQuerySendStatus
        {
            get { return _varWaitBeforQuerySendStatus; }
            set { _varWaitBeforQuerySendStatus = value; }
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

            CallSendAsyncProgApiCode(ValueConverter.ArgumentFromString<int>("CncId", varCncId), varDocumentName, varDocExtension, varSourceFolder, varUser, varpsw, varExpectedRes, varDestinationFolder, varDestinationFolderMode, ValueConverter.ArgumentFromString<bool>("Override", varOverride), ValueConverter.ArgumentFromString<int>("WaitBeforQuerySendStatus", varWaitBeforQuerySendStatus));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
