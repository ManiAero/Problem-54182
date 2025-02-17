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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sprint_9_7_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Sprint_9_7_2Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("652b32e5-8a8e-4597-937e-2fc217123020")]
    public partial class Sprint_9_7_2Repository : RepoGenBaseFolder
    {
        static Sprint_9_7_2Repository instance = new Sprint_9_7_2Repository();
        Sprint_9_7_2RepositoryFolders.CWork2023972DEVAppFolder _cwork2023972dev;
        Sprint_9_7_2RepositoryFolders.CworkAppFolder _cwork;
        Sprint_9_7_2RepositoryFolders.PreferencesAppFolder _preferences;
        Sprint_9_7_2RepositoryFolders.AjoutDunGroupeAppFolder _ajoutdungroupe;
        Sprint_9_7_2RepositoryFolders.Cwork2024983DEVAppFolder _cwork2024983dev;

        /// <summary>
        /// Gets the singleton class instance representing the Sprint_9_7_2Repository element repository.
        /// </summary>
        [RepositoryFolder("652b32e5-8a8e-4597-937e-2fc217123020")]
        public static Sprint_9_7_2Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Sprint_9_7_2Repository() 
            : base("Sprint_9_7_2Repository", "/", null, 0, false, "652b32e5-8a8e-4597-937e-2fc217123020", ".\\RepositoryImages\\Sprint_9_7_2Repository652b32e5.rximgres")
        {
            _cwork2023972dev = new Sprint_9_7_2RepositoryFolders.CWork2023972DEVAppFolder(this);
            _cwork = new Sprint_9_7_2RepositoryFolders.CworkAppFolder(this);
            _preferences = new Sprint_9_7_2RepositoryFolders.PreferencesAppFolder(this);
            _ajoutdungroupe = new Sprint_9_7_2RepositoryFolders.AjoutDunGroupeAppFolder(this);
            _cwork2024983dev = new Sprint_9_7_2RepositoryFolders.Cwork2024983DEVAppFolder(this);
        }

#region Variables

        string _curentday = "15/06/2023";

        /// <summary>
        /// Gets or sets the value of variable curentday.
        /// </summary>
        [TestVariable("ba3863f8-9c63-4532-829a-f7098b1bec35")]
        public string curentday
        {
            get { return _curentday; }
            set { _curentday = value; }
        }

        string _CurentDay1 = "15/06/2023";

        /// <summary>
        /// Gets or sets the value of variable CurentDay1.
        /// </summary>
        [TestVariable("31285dbd-c61f-4300-bfce-f612a7026645")]
        public string CurentDay1
        {
            get { return _CurentDay1; }
            set { _CurentDay1 = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("652b32e5-8a8e-4597-937e-2fc217123020")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The CWork2023972DEV folder.
        /// </summary>
        [RepositoryFolder("d699b3d0-f200-4063-b7bc-12964ee7e70e")]
        public virtual Sprint_9_7_2RepositoryFolders.CWork2023972DEVAppFolder CWork2023972DEV
        {
            get { return _cwork2023972dev; }
        }

        /// <summary>
        /// The Cwork folder.
        /// </summary>
        [RepositoryFolder("4c789013-dd77-41f3-99fd-6834b68fe528")]
        public virtual Sprint_9_7_2RepositoryFolders.CworkAppFolder Cwork
        {
            get { return _cwork; }
        }

        /// <summary>
        /// The Preferences folder.
        /// </summary>
        [RepositoryFolder("b44bff19-a82b-49b2-8be3-279716ef0e69")]
        public virtual Sprint_9_7_2RepositoryFolders.PreferencesAppFolder Preferences
        {
            get { return _preferences; }
        }

        /// <summary>
        /// The AjoutDunGroupe folder.
        /// </summary>
        [RepositoryFolder("a55424a7-dac4-4cba-a550-19141a545214")]
        public virtual Sprint_9_7_2RepositoryFolders.AjoutDunGroupeAppFolder AjoutDunGroupe
        {
            get { return _ajoutdungroupe; }
        }

        /// <summary>
        /// The Cwork2024983DEV folder.
        /// </summary>
        [RepositoryFolder("d21f0658-0e4e-45b4-bb4b-7948eaed301d")]
        public virtual Sprint_9_7_2RepositoryFolders.Cwork2024983DEVAppFolder Cwork2024983DEV
        {
            get { return _cwork2024983dev; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Sprint_9_7_2RepositoryFolders
    {
        /// <summary>
        /// The CWork2023972DEVAppFolder folder.
        /// </summary>
        [RepositoryFolder("d699b3d0-f200-4063-b7bc-12964ee7e70e")]
        public partial class CWork2023972DEVAppFolder : RepoGenBaseFolder
        {
            Sprint_9_7_2RepositoryFolders.HistoriqueDeProductionFolder _historiquedeproduction;
            RepoItemInfo _cnc1Info;
            RepoItemInfo _bshowtimelineInfo;
            RepoItemInfo _btshowInfo;
            RepoItemInfo _menuitemoutilsInfo;
            RepoItemInfo _tadvsmoothtogglebuttonInfo;
            RepoItemInfo _cell12Info;

            /// <summary>
            /// Creates a new CWork2023972DEV  folder.
            /// </summary>
            public CWork2023972DEVAppFolder(RepoGenBaseFolder parentFolder) :
                    base("CWork2023972DEV", "/form[@name='CworkMainForm']", parentFolder, 30000, null, false, "d699b3d0-f200-4063-b7bc-12964ee7e70e", "")
            {
                _historiquedeproduction = new Sprint_9_7_2RepositoryFolders.HistoriqueDeProductionFolder(this);
                _cnc1Info = new RepoItemInfo(this, "Cnc1", "element[@name='pages']/?/?/form[@name='CncViewForm']/?/?/rawtext[@rawtext='Cnc-1']", "", 30000, null, "adae4b37-13ba-4dfe-9417-0ad44bfd2d58");
                _bshowtimelineInfo = new RepoItemInfo(this, "BShowTimeline", "element[@name='pages']/?/?/form[@name='CncViewForm']//element[@name='bShowTimeline']", "", 30000, null, "6462cb5a-93d9-4d22-bbf2-4ff7a31e7e74");
                _btshowInfo = new RepoItemInfo(this, "BtShow", "element[@name='pages']/?/?/form[@name='StationHistoryForm']//element[@name='btShow']", "", 30000, null, "7b279064-76c0-4b9f-bf36-d12d3698e230");
                _menuitemoutilsInfo = new RepoItemInfo(this, "MenuItemOutils", "?/?/menuitem[@name='mnTools']", "", 30000, null, "8c1f6ae0-0a9f-49a3-a9bc-4ca2da4e5884");
                _tadvsmoothtogglebuttonInfo = new RepoItemInfo(this, "TAdvSmoothToggleButton", "?/?/element[@instance='3']", "", 30000, null, "0ddeca3c-4e47-4100-8ecc-5758d59145fe");
                _cell12Info = new RepoItemInfo(this, "Cell12", ".//form[@name='FullProductionViewForm']/?/?/table[@name='grActivity']/row[@index='1']/cell[@name='12']", "", 30000, null, "b55d39dd-6d04-4dca-9abb-bda6ab126eb6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d699b3d0-f200-4063-b7bc-12964ee7e70e")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d699b3d0-f200-4063-b7bc-12964ee7e70e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Cnc1 item.
            /// </summary>
            [RepositoryItem("adae4b37-13ba-4dfe-9417-0ad44bfd2d58")]
            public virtual Ranorex.RawText Cnc1
            {
                get
                {
                    return _cnc1Info.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The Cnc1 item info.
            /// </summary>
            [RepositoryItemInfo("adae4b37-13ba-4dfe-9417-0ad44bfd2d58")]
            public virtual RepoItemInfo Cnc1Info
            {
                get
                {
                    return _cnc1Info;
                }
            }

            /// <summary>
            /// The BShowTimeline item.
            /// </summary>
            [RepositoryItem("6462cb5a-93d9-4d22-bbf2-4ff7a31e7e74")]
            public virtual Ranorex.Unknown BShowTimeline
            {
                get
                {
                    return _bshowtimelineInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BShowTimeline item info.
            /// </summary>
            [RepositoryItemInfo("6462cb5a-93d9-4d22-bbf2-4ff7a31e7e74")]
            public virtual RepoItemInfo BShowTimelineInfo
            {
                get
                {
                    return _bshowtimelineInfo;
                }
            }

            /// <summary>
            /// The BtShow item.
            /// </summary>
            [RepositoryItem("7b279064-76c0-4b9f-bf36-d12d3698e230")]
            public virtual Ranorex.Unknown BtShow
            {
                get
                {
                    return _btshowInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtShow item info.
            /// </summary>
            [RepositoryItemInfo("7b279064-76c0-4b9f-bf36-d12d3698e230")]
            public virtual RepoItemInfo BtShowInfo
            {
                get
                {
                    return _btshowInfo;
                }
            }

            /// <summary>
            /// The MenuItemOutils item.
            /// </summary>
            [RepositoryItem("8c1f6ae0-0a9f-49a3-a9bc-4ca2da4e5884")]
            public virtual Ranorex.MenuItem MenuItemOutils
            {
                get
                {
                    return _menuitemoutilsInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItemOutils item info.
            /// </summary>
            [RepositoryItemInfo("8c1f6ae0-0a9f-49a3-a9bc-4ca2da4e5884")]
            public virtual RepoItemInfo MenuItemOutilsInfo
            {
                get
                {
                    return _menuitemoutilsInfo;
                }
            }

            /// <summary>
            /// The TAdvSmoothToggleButton item.
            /// </summary>
            [RepositoryItem("0ddeca3c-4e47-4100-8ecc-5758d59145fe")]
            public virtual Ranorex.Unknown TAdvSmoothToggleButton
            {
                get
                {
                    return _tadvsmoothtogglebuttonInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The TAdvSmoothToggleButton item info.
            /// </summary>
            [RepositoryItemInfo("0ddeca3c-4e47-4100-8ecc-5758d59145fe")]
            public virtual RepoItemInfo TAdvSmoothToggleButtonInfo
            {
                get
                {
                    return _tadvsmoothtogglebuttonInfo;
                }
            }

            /// <summary>
            /// The Cell12 item.
            /// </summary>
            [RepositoryItem("b55d39dd-6d04-4dca-9abb-bda6ab126eb6")]
            public virtual Ranorex.Cell Cell12
            {
                get
                {
                    return _cell12Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Cell12 item info.
            /// </summary>
            [RepositoryItemInfo("b55d39dd-6d04-4dca-9abb-bda6ab126eb6")]
            public virtual RepoItemInfo Cell12Info
            {
                get
                {
                    return _cell12Info;
                }
            }

            /// <summary>
            /// The HistoriqueDeProduction folder.
            /// </summary>
            [RepositoryFolder("5e278959-e1c4-4f03-a28a-1eccf65be557")]
            public virtual Sprint_9_7_2RepositoryFolders.HistoriqueDeProductionFolder HistoriqueDeProduction
            {
                get { return _historiquedeproduction; }
            }
        }

        /// <summary>
        /// The HistoriqueDeProductionFolder folder.
        /// </summary>
        [RepositoryFolder("5e278959-e1c4-4f03-a28a-1eccf65be557")]
        public partial class HistoriqueDeProductionFolder : RepoGenBaseFolder
        {
            RepoItemInfo _panneInfo;
            RepoItemInfo _text14062023Info;
            RepoItemInfo _btndayInfo;
            RepoItemInfo _toolpaneltabInfo;
            RepoItemInfo _btcloseInfo;
            RepoItemInfo _btnweekInfo;
            RepoItemInfo _rawtext15062023Info;

            /// <summary>
            /// Creates a new HistoriqueDeProduction  folder.
            /// </summary>
            public HistoriqueDeProductionFolder(RepoGenBaseFolder parentFolder) :
                    base("HistoriqueDeProduction", ".//form[@name='StationHistoryForm']", parentFolder, 30000, null, false, "5e278959-e1c4-4f03-a28a-1eccf65be557", "")
            {
                _panneInfo = new RepoItemInfo(this, "Panne", "container[@name='pnlMainView']/form[@name='HistoryTimelineView']/container[@name='paFooter']//text[@name='lCurrentState']", "", 30000, null, "b3f6eab3-4b05-4903-896b-e477611f547b");
                _text14062023Info = new RepoItemInfo(this, "Text14062023", "container[@name='pnlMainView']/form[@name='HistoryTimelineView']/container[@name='paFooter']//text[@name='lStartDate']", "", 30000, null, "546d8268-ed30-4345-bc4b-2e1bae65bc70");
                _btndayInfo = new RepoItemInfo(this, "BtnDay", "container[@name='toolPanelDateSelect']/?/?/element[@name='btnDay']", "", 30000, null, "ccd7a96a-9fbf-468c-94f0-d6c9b837ce81");
                _toolpaneltabInfo = new RepoItemInfo(this, "ToolPanelTab", "container[@name='toolPanelTab']", "", 30000, null, "cbc5d6a6-56ea-40cc-9d82-6325b54c9ff9");
                _btcloseInfo = new RepoItemInfo(this, "BtClose", ".//element[@name='btClose']", "", 30000, null, "d733e955-1563-4b3d-86d6-495693c50419");
                _btnweekInfo = new RepoItemInfo(this, "BtnWeek", "container[@name='toolPanelDateSelect']/?/?/element[@name='btnWeek']", "", 30000, null, "f1b18187-8ce5-4a7c-9549-dd8c1dc0b5e4");
                _rawtext15062023Info = new RepoItemInfo(this, "RawText15062023", "container[@name='toolPanelDateSelect']/?/?/rawtext[@rawtext=' '+$CurentDay1]", "", 30000, null, "e55988a1-f88a-4e0c-a18e-3a1bc9c783a2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5e278959-e1c4-4f03-a28a-1eccf65be557")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5e278959-e1c4-4f03-a28a-1eccf65be557")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Panne item.
            /// </summary>
            [RepositoryItem("b3f6eab3-4b05-4903-896b-e477611f547b")]
            public virtual Ranorex.Text Panne
            {
                get
                {
                    return _panneInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Panne item info.
            /// </summary>
            [RepositoryItemInfo("b3f6eab3-4b05-4903-896b-e477611f547b")]
            public virtual RepoItemInfo PanneInfo
            {
                get
                {
                    return _panneInfo;
                }
            }

            /// <summary>
            /// The Text14062023 item.
            /// </summary>
            [RepositoryItem("546d8268-ed30-4345-bc4b-2e1bae65bc70")]
            public virtual Ranorex.Text Text14062023
            {
                get
                {
                    return _text14062023Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text14062023 item info.
            /// </summary>
            [RepositoryItemInfo("546d8268-ed30-4345-bc4b-2e1bae65bc70")]
            public virtual RepoItemInfo Text14062023Info
            {
                get
                {
                    return _text14062023Info;
                }
            }

            /// <summary>
            /// The BtnDay item.
            /// </summary>
            [RepositoryItem("ccd7a96a-9fbf-468c-94f0-d6c9b837ce81")]
            public virtual Ranorex.Unknown BtnDay
            {
                get
                {
                    return _btndayInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtnDay item info.
            /// </summary>
            [RepositoryItemInfo("ccd7a96a-9fbf-468c-94f0-d6c9b837ce81")]
            public virtual RepoItemInfo BtnDayInfo
            {
                get
                {
                    return _btndayInfo;
                }
            }

            /// <summary>
            /// The ToolPanelTab item.
            /// </summary>
            [RepositoryItem("cbc5d6a6-56ea-40cc-9d82-6325b54c9ff9")]
            public virtual Ranorex.Container ToolPanelTab
            {
                get
                {
                    return _toolpaneltabInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The ToolPanelTab item info.
            /// </summary>
            [RepositoryItemInfo("cbc5d6a6-56ea-40cc-9d82-6325b54c9ff9")]
            public virtual RepoItemInfo ToolPanelTabInfo
            {
                get
                {
                    return _toolpaneltabInfo;
                }
            }

            /// <summary>
            /// The BtClose item.
            /// </summary>
            [RepositoryItem("d733e955-1563-4b3d-86d6-495693c50419")]
            public virtual Ranorex.Unknown BtClose
            {
                get
                {
                    return _btcloseInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtClose item info.
            /// </summary>
            [RepositoryItemInfo("d733e955-1563-4b3d-86d6-495693c50419")]
            public virtual RepoItemInfo BtCloseInfo
            {
                get
                {
                    return _btcloseInfo;
                }
            }

            /// <summary>
            /// The BtnWeek item.
            /// </summary>
            [RepositoryItem("f1b18187-8ce5-4a7c-9549-dd8c1dc0b5e4")]
            public virtual Ranorex.Unknown BtnWeek
            {
                get
                {
                    return _btnweekInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtnWeek item info.
            /// </summary>
            [RepositoryItemInfo("f1b18187-8ce5-4a7c-9549-dd8c1dc0b5e4")]
            public virtual RepoItemInfo BtnWeekInfo
            {
                get
                {
                    return _btnweekInfo;
                }
            }

            /// <summary>
            /// The RawText15062023 item.
            /// </summary>
            [RepositoryItem("e55988a1-f88a-4e0c-a18e-3a1bc9c783a2")]
            public virtual Ranorex.RawText RawText15062023
            {
                get
                {
                    return _rawtext15062023Info.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The RawText15062023 item info.
            /// </summary>
            [RepositoryItemInfo("e55988a1-f88a-4e0c-a18e-3a1bc9c783a2")]
            public virtual RepoItemInfo RawText15062023Info
            {
                get
                {
                    return _rawtext15062023Info;
                }
            }
        }

        /// <summary>
        /// The CworkAppFolder folder.
        /// </summary>
        [RepositoryFolder("4c789013-dd77-41f3-99fd-6834b68fe528")]
        public partial class CworkAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _menuitemInfo;
            RepoItemInfo _menuitem1Info;

            /// <summary>
            /// Creates a new Cwork  folder.
            /// </summary>
            public CworkAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Cwork", "/contextmenu[@processname='Cwork']", parentFolder, 30000, null, false, "4c789013-dd77-41f3-99fd-6834b68fe528", "")
            {
                _menuitemInfo = new RepoItemInfo(this, "MenuItem", "contextmenu/menuitem[1]", "", 30000, null, "9dadb1cc-7e53-4245-b8ce-277dc77f5487");
                _menuitem1Info = new RepoItemInfo(this, "MenuItem1", "contextmenu/menuitem[7]", "", 30000, null, "d9601581-5281-4903-8258-0e9e237223f6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4c789013-dd77-41f3-99fd-6834b68fe528")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4c789013-dd77-41f3-99fd-6834b68fe528")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MenuItem item.
            /// </summary>
            [RepositoryItem("9dadb1cc-7e53-4245-b8ce-277dc77f5487")]
            public virtual Ranorex.MenuItem MenuItem
            {
                get
                {
                    return _menuitemInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItem item info.
            /// </summary>
            [RepositoryItemInfo("9dadb1cc-7e53-4245-b8ce-277dc77f5487")]
            public virtual RepoItemInfo MenuItemInfo
            {
                get
                {
                    return _menuitemInfo;
                }
            }

            /// <summary>
            /// The MenuItem1 item.
            /// </summary>
            [RepositoryItem("d9601581-5281-4903-8258-0e9e237223f6")]
            public virtual Ranorex.MenuItem MenuItem1
            {
                get
                {
                    return _menuitem1Info.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItem1 item info.
            /// </summary>
            [RepositoryItemInfo("d9601581-5281-4903-8258-0e9e237223f6")]
            public virtual RepoItemInfo MenuItem1Info
            {
                get
                {
                    return _menuitem1Info;
                }
            }
        }

        /// <summary>
        /// The PreferencesAppFolder folder.
        /// </summary>
        [RepositoryFolder("b44bff19-a82b-49b2-8be3-279716ef0e69")]
        public partial class PreferencesAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _droitsdesutilisateursInfo;
            RepoItemInfo _administrateursInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new Preferences  folder.
            /// </summary>
            public PreferencesAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Preferences", "/form[@name='Preference']", parentFolder, 30000, null, false, "b44bff19-a82b-49b2-8be3-279716ef0e69", "")
            {
                _droitsdesutilisateursInfo = new RepoItemInfo(this, "DroitsDesUtilisateurs", "?/?/listitem[@name='Droits des utilisateurs']", "", 30000, null, "5924ac32-df68-497a-988d-258078b1c81f");
                _administrateursInfo = new RepoItemInfo(this, "Administrateurs", ".//list[@name='optUserGroupList']/listitem[@name='Administrateurs']", "", 30000, null, "218bcf0a-f840-4929-ba52-400e1e1b07e8");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOk", "button[@name='bOk']", "", 30000, null, "a2f8b38a-cf51-4387-87ce-da08663af37f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b44bff19-a82b-49b2-8be3-279716ef0e69")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b44bff19-a82b-49b2-8be3-279716ef0e69")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DroitsDesUtilisateurs item.
            /// </summary>
            [RepositoryItem("5924ac32-df68-497a-988d-258078b1c81f")]
            public virtual Ranorex.ListItem DroitsDesUtilisateurs
            {
                get
                {
                    return _droitsdesutilisateursInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The DroitsDesUtilisateurs item info.
            /// </summary>
            [RepositoryItemInfo("5924ac32-df68-497a-988d-258078b1c81f")]
            public virtual RepoItemInfo DroitsDesUtilisateursInfo
            {
                get
                {
                    return _droitsdesutilisateursInfo;
                }
            }

            /// <summary>
            /// The Administrateurs item.
            /// </summary>
            [RepositoryItem("218bcf0a-f840-4929-ba52-400e1e1b07e8")]
            public virtual Ranorex.ListItem Administrateurs
            {
                get
                {
                    return _administrateursInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Administrateurs item info.
            /// </summary>
            [RepositoryItemInfo("218bcf0a-f840-4929-ba52-400e1e1b07e8")]
            public virtual RepoItemInfo AdministrateursInfo
            {
                get
                {
                    return _administrateursInfo;
                }
            }

            /// <summary>
            /// The ButtonOk item.
            /// </summary>
            [RepositoryItem("a2f8b38a-cf51-4387-87ce-da08663af37f")]
            public virtual Ranorex.Button ButtonOk
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOk item info.
            /// </summary>
            [RepositoryItemInfo("a2f8b38a-cf51-4387-87ce-da08663af37f")]
            public virtual RepoItemInfo ButtonOkInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The AjoutDunGroupeAppFolder folder.
        /// </summary>
        [RepositoryFolder("a55424a7-dac4-4cba-a550-19141a545214")]
        public partial class AjoutDunGroupeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _listitempeutinitialiserlenombredeInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new AjoutDunGroupe  folder.
            /// </summary>
            public AjoutDunGroupeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AjoutDunGroupe", "/form[@name='UserGroupOptionsForm']", parentFolder, 30000, null, false, "a55424a7-dac4-4cba-a550-19141a545214", "")
            {
                _listitempeutinitialiserlenombredeInfo = new RepoItemInfo(this, "ListItemPeutInitialiserLeNombreDe", ".//list[@name='optGroupRights']/listitem[@name>'   Peut initialiser le nombre']", "", 30000, null, "5de86214-edc5-4a3e-ae02-bb7da85cab82");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@name='bOk']", "", 30000, null, "8b36a9b5-916a-4197-b8d1-7d1d806bbe29");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a55424a7-dac4-4cba-a550-19141a545214")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a55424a7-dac4-4cba-a550-19141a545214")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ListItemPeutInitialiserLeNombreDe item.
            /// </summary>
            [RepositoryItem("5de86214-edc5-4a3e-ae02-bb7da85cab82")]
            public virtual Ranorex.ListItem ListItemPeutInitialiserLeNombreDe
            {
                get
                {
                    return _listitempeutinitialiserlenombredeInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItemPeutInitialiserLeNombreDe item info.
            /// </summary>
            [RepositoryItemInfo("5de86214-edc5-4a3e-ae02-bb7da85cab82")]
            public virtual RepoItemInfo ListItemPeutInitialiserLeNombreDeInfo
            {
                get
                {
                    return _listitempeutinitialiserlenombredeInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("8b36a9b5-916a-4197-b8d1-7d1d806bbe29")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("8b36a9b5-916a-4197-b8d1-7d1d806bbe29")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The Cwork2024983DEVAppFolder folder.
        /// </summary>
        [RepositoryFolder("d21f0658-0e4e-45b4-bb4b-7948eaed301d")]
        public partial class Cwork2024983DEVAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _menuitemfichierInfo;
            RepoItemInfo _menuitemoutilsInfo;

            /// <summary>
            /// Creates a new Cwork2024983DEV  folder.
            /// </summary>
            public Cwork2024983DEVAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Cwork2024983DEV", "/form[@title>'Cwork']", parentFolder, 30000, null, true, "d21f0658-0e4e-45b4-bb4b-7948eaed301d", "")
            {
                _menuitemfichierInfo = new RepoItemInfo(this, "MenuItemFichier", "menubar[@automationid='MenuBar']/menuitem[1]", "", 30000, null, "701b0cf0-4aab-4254-bf14-9e9d8db1bf40");
                _menuitemoutilsInfo = new RepoItemInfo(this, "MenuItemOutils", "menubar[@automationid='MenuBar']/menuitem[8]", "", 30000, null, "f7599bac-a294-478b-9e6c-70c238fa15d1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d21f0658-0e4e-45b4-bb4b-7948eaed301d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d21f0658-0e4e-45b4-bb4b-7948eaed301d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MenuItemFichier item.
            /// </summary>
            [RepositoryItem("701b0cf0-4aab-4254-bf14-9e9d8db1bf40")]
            public virtual Ranorex.MenuItem MenuItemFichier
            {
                get
                {
                    return _menuitemfichierInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItemFichier item info.
            /// </summary>
            [RepositoryItemInfo("701b0cf0-4aab-4254-bf14-9e9d8db1bf40")]
            public virtual RepoItemInfo MenuItemFichierInfo
            {
                get
                {
                    return _menuitemfichierInfo;
                }
            }

            /// <summary>
            /// The MenuItemOutils item.
            /// </summary>
            [RepositoryItem("f7599bac-a294-478b-9e6c-70c238fa15d1")]
            public virtual Ranorex.MenuItem MenuItemOutils
            {
                get
                {
                    return _menuitemoutilsInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItemOutils item info.
            /// </summary>
            [RepositoryItemInfo("f7599bac-a294-478b-9e6c-70c238fa15d1")]
            public virtual RepoItemInfo MenuItemOutilsInfo
            {
                get
                {
                    return _menuitemoutilsInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
