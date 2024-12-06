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
    ///The Test_filtre_Repertoire_dechargement recording.
    /// </summary>
    [TestModule("86547150-9931-41f3-b6b6-157e93e6bc87", ModuleType.Recording, 1)]
    public partial class Test_filtre_Repertoire_dechargement : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sprint_9_6_3Repository repository.
        /// </summary>
        public static Sprint_9_6_3Repository repo = Sprint_9_6_3Repository.Instance;

        static Test_filtre_Repertoire_dechargement instance = new Test_filtre_Repertoire_dechargement();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Test_filtre_Repertoire_dechargement()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Test_filtre_Repertoire_dechargement Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNetDNC.Decharger' at 117;18.", repo.CNetDNC.DechargerInfo, new RecordItemIndex(0));
            repo.CNetDNC.Decharger.Click("117;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNetDNC.RechNom' at 92;32.", repo.CNetDNC.RechNomInfo, new RecordItemIndex(1));
            repo.CNetDNC.RechNom.Click("92;32");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNetDNC.RSName' at 84;14.", repo.CNetDNC.RSNameInfo, new RecordItemIndex(2));
            repo.CNetDNC.RSName.Click("84;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WPD' with focus on 'CNetDNC.RSName'.", repo.CNetDNC.RSNameInfo, new RecordItemIndex(3));
            repo.CNetDNC.RSName.PressKeys("WPD");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNetDNC.AppliquerLaRechercheSurLesRepertoir' at 6;9.", repo.CNetDNC.AppliquerLaRechercheSurLesRepertoirInfo, new RecordItemIndex(4));
            repo.CNetDNC.AppliquerLaRechercheSurLesRepertoir.Click("6;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CNetDNC.Recherche' at 88;20.", repo.CNetDNC.RechercheInfo, new RecordItemIndex(5));
            repo.CNetDNC.Recherche.Click("88;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='piece1.WPD') on item 'CNetDNC.TLSave.Piece1WPD'.", repo.CNetDNC.TLSave.Piece1WPDInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.CNetDNC.TLSave.Piece1WPDInfo, "Text", "piece1.WPD");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Count='4') on item 'CNetDNC.TLSave.Piece1WPD'.", repo.CNetDNC.TLSave.Piece1WPDInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.CNetDNC.TLSave.Piece1WPDInfo, "Count", "4");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='piece2.WPD') on item 'CNetDNC.TLSave.Piece2WPD'.", repo.CNetDNC.TLSave.Piece2WPDInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.CNetDNC.TLSave.Piece2WPDInfo, "Text", "piece2.WPD");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Count='4') on item 'CNetDNC.TLSave.Piece2WPD'.", repo.CNetDNC.TLSave.Piece2WPDInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.CNetDNC.TLSave.Piece2WPDInfo, "Count", "4");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='piece3.WPD') on item 'CNetDNC.TLSave.Piece3WPD'.", repo.CNetDNC.TLSave.Piece3WPDInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.CNetDNC.TLSave.Piece3WPDInfo, "Text", "piece3.WPD");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Count='4') on item 'CNetDNC.TLSave.Piece3WPD'.", repo.CNetDNC.TLSave.Piece3WPDInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.CNetDNC.TLSave.Piece3WPDInfo, "Count", "4");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
