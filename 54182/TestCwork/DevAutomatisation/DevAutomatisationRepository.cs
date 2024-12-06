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

namespace DevAutomatisation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DevAutomatisationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3587eb24-6de6-41eb-9a3f-e5c3802ace63")]
    public partial class DevAutomatisationRepository : RepoGenBaseFolder
    {
        static DevAutomatisationRepository instance = new DevAutomatisationRepository();
        DevAutomatisationRepositoryFolders.CWork202296AppFolder _cwork202296;
        DevAutomatisationRepositoryFolders.DEVWTOKYOAppFolder _devwtokyo;
        DevAutomatisationRepositoryFolders.ChoixDuneConfigurationAppFolder _choixduneconfiguration;
        DevAutomatisationRepositoryFolders.ProprietesPourCnc1AppFolder _proprietespourcnc1;
        DevAutomatisationRepositoryFolders.List1000AppFolder _list1000;
        RepoItemInfo _dateInfo;

        /// <summary>
        /// Gets the singleton class instance representing the DevAutomatisationRepository element repository.
        /// </summary>
        [RepositoryFolder("3587eb24-6de6-41eb-9a3f-e5c3802ace63")]
        public static DevAutomatisationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DevAutomatisationRepository() 
            : base("DevAutomatisationRepository", "/", null, 0, false, "3587eb24-6de6-41eb-9a3f-e5c3802ace63", ".\\RepositoryImages\\DevAutomatisationRepository3587eb24.rximgres")
        {
            _cwork202296 = new DevAutomatisationRepositoryFolders.CWork202296AppFolder(this);
            _devwtokyo = new DevAutomatisationRepositoryFolders.DEVWTOKYOAppFolder(this);
            _choixduneconfiguration = new DevAutomatisationRepositoryFolders.ChoixDuneConfigurationAppFolder(this);
            _proprietespourcnc1 = new DevAutomatisationRepositoryFolders.ProprietesPourCnc1AppFolder(this);
            _list1000 = new DevAutomatisationRepositoryFolders.List1000AppFolder(this);
            _dateInfo = new RepoItemInfo(this, "date", "/form[@name='CworkMainForm']//form[@name='StationHistoryForm']/container[@name='toolPanelDateSelect']/?/?/rawtext[@rawtext=$NumDay]", 30000, null, "2820837f-f572-4207-bde0-45431da7e727");
        }

#region Variables

        string _NumDay = "20";

        /// <summary>
        /// Gets or sets the value of variable NumDay.
        /// </summary>
        [TestVariable("5bf8e24a-f781-4ab0-a8bd-a6fe47a0e97c")]
        public string NumDay
        {
            get { return _NumDay; }
            set { _NumDay = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3587eb24-6de6-41eb-9a3f-e5c3802ace63")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The date item.
        /// </summary>
        [RepositoryItem("2820837f-f572-4207-bde0-45431da7e727")]
        public virtual Ranorex.RawText date
        {
            get
            {
                 return _dateInfo.CreateAdapter<Ranorex.RawText>(true);
            }
        }

        /// <summary>
        /// The date item info.
        /// </summary>
        [RepositoryItemInfo("2820837f-f572-4207-bde0-45431da7e727")]
        public virtual RepoItemInfo dateInfo
        {
            get
            {
                return _dateInfo;
            }
        }

        /// <summary>
        /// The CWork202296 folder.
        /// </summary>
        [RepositoryFolder("6d90935a-3e2d-4cd5-a88c-628e8bf0cd86")]
        public virtual DevAutomatisationRepositoryFolders.CWork202296AppFolder CWork202296
        {
            get { return _cwork202296; }
        }

        /// <summary>
        /// The DEVWTOKYO folder.
        /// </summary>
        [RepositoryFolder("d6c6db02-e20b-4a89-b4a3-c28618527c78")]
        public virtual DevAutomatisationRepositoryFolders.DEVWTOKYOAppFolder DEVWTOKYO
        {
            get { return _devwtokyo; }
        }

        /// <summary>
        /// The ChoixDuneConfiguration folder.
        /// </summary>
        [RepositoryFolder("4b93a97a-062e-4924-b874-c0ae8d6a0f2d")]
        public virtual DevAutomatisationRepositoryFolders.ChoixDuneConfigurationAppFolder ChoixDuneConfiguration
        {
            get { return _choixduneconfiguration; }
        }

        /// <summary>
        /// The ProprietesPourCnc1 folder.
        /// </summary>
        [RepositoryFolder("218d4a8f-1334-4369-9346-ffeb809b8f3a")]
        public virtual DevAutomatisationRepositoryFolders.ProprietesPourCnc1AppFolder ProprietesPourCnc1
        {
            get { return _proprietespourcnc1; }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("90397706-b3cb-46a4-8f7f-3057032eef2c")]
        public virtual DevAutomatisationRepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class DevAutomatisationRepositoryFolders
    {
        /// <summary>
        /// The CWork202296AppFolder folder.
        /// </summary>
        [RepositoryFolder("6d90935a-3e2d-4cd5-a88c-628e8bf0cd86")]
        public partial class CWork202296AppFolder : RepoGenBaseFolder
        {
            DevAutomatisationRepositoryFolders.ChoixDate2Folder _choixdate2;
            RepoItemInfo _toolpaneltabInfo;
            RepoItemInfo _cnc1Info;
            RepoItemInfo _bpropertyInfo;

            /// <summary>
            /// Creates a new CWork202296  folder.
            /// </summary>
            public CWork202296AppFolder(RepoGenBaseFolder parentFolder) :
                    base("CWork202296", "/form[@name='CworkMainForm']", parentFolder, 30000, null, true, "6d90935a-3e2d-4cd5-a88c-628e8bf0cd86", "")
            {
                _choixdate2 = new DevAutomatisationRepositoryFolders.ChoixDate2Folder(this);
                _toolpaneltabInfo = new RepoItemInfo(this, "ToolPanelTab", "element[@name='pages']/?/?/form[@name='StationHistoryForm']/?/?/rawtext[@rawtext='Choix Date']", "", 30000, null, "c4b4b16f-58a7-4531-b8e2-b6fc4e2665f0");
                _cnc1Info = new RepoItemInfo(this, "Cnc1", "element[@name='pages']/?/?/form[@name='CncViewForm']/?/?/rawtext[@rawtext='Cnc-1']", "", 30000, null, "eeef99fa-34ad-42a3-a2ce-b678494da51a");
                _bpropertyInfo = new RepoItemInfo(this, "BProperty", "element[@name='pages']/?/?/form[@name='CncViewForm']//element[@name='bProperty']", "", 30000, null, "6d1ca4c0-6948-4693-b69a-68f4eb31e827");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6d90935a-3e2d-4cd5-a88c-628e8bf0cd86")]
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
            [RepositoryItemInfo("6d90935a-3e2d-4cd5-a88c-628e8bf0cd86")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ToolPanelTab item.
            /// </summary>
            [RepositoryItem("c4b4b16f-58a7-4531-b8e2-b6fc4e2665f0")]
            public virtual Ranorex.RawText ToolPanelTab
            {
                get
                {
                    return _toolpaneltabInfo.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The ToolPanelTab item info.
            /// </summary>
            [RepositoryItemInfo("c4b4b16f-58a7-4531-b8e2-b6fc4e2665f0")]
            public virtual RepoItemInfo ToolPanelTabInfo
            {
                get
                {
                    return _toolpaneltabInfo;
                }
            }

            /// <summary>
            /// The Cnc1 item.
            /// </summary>
            [RepositoryItem("eeef99fa-34ad-42a3-a2ce-b678494da51a")]
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
            [RepositoryItemInfo("eeef99fa-34ad-42a3-a2ce-b678494da51a")]
            public virtual RepoItemInfo Cnc1Info
            {
                get
                {
                    return _cnc1Info;
                }
            }

            /// <summary>
            /// The BProperty item.
            /// </summary>
            [RepositoryItem("6d1ca4c0-6948-4693-b69a-68f4eb31e827")]
            public virtual Ranorex.Unknown BProperty
            {
                get
                {
                    return _bpropertyInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BProperty item info.
            /// </summary>
            [RepositoryItemInfo("6d1ca4c0-6948-4693-b69a-68f4eb31e827")]
            public virtual RepoItemInfo BPropertyInfo
            {
                get
                {
                    return _bpropertyInfo;
                }
            }

            /// <summary>
            /// The ChoixDate2 folder.
            /// </summary>
            [RepositoryFolder("83e4fc44-2ace-442c-9678-ab29c603803c")]
            public virtual DevAutomatisationRepositoryFolders.ChoixDate2Folder ChoixDate2
            {
                get { return _choixdate2; }
            }
        }

        /// <summary>
        /// The ChoixDate2Folder folder.
        /// </summary>
        [RepositoryFolder("83e4fc44-2ace-442c-9678-ab29c603803c")]
        public partial class ChoixDate2Folder : RepoGenBaseFolder
        {
            RepoItemInfo _choixdateInfo;
            RepoItemInfo _btndayInfo;
            RepoItemInfo _choixdate1Info;

            /// <summary>
            /// Creates a new ChoixDate2  folder.
            /// </summary>
            public ChoixDate2Folder(RepoGenBaseFolder parentFolder) :
                    base("ChoixDate2", ".//form[@name='StationHistoryForm']/container[@name='toolPanelDateSelect']", parentFolder, 30000, null, false, "83e4fc44-2ace-442c-9678-ab29c603803c", "")
            {
                _choixdateInfo = new RepoItemInfo(this, "ChoixDate", "", "", 30000, null, "71bce84f-279d-4e76-a06e-8671ef0c8a0d");
                _btndayInfo = new RepoItemInfo(this, "BtnDay", "?/?/element[@name='btnDay']", "", 30000, null, "b1721715-9696-4b9b-a1a1-49492be437e3");
                _choixdate1Info = new RepoItemInfo(this, "ChoixDate1", "?/?/rawtext[@column='0']", "", 30000, null, "dc2152b7-0c20-48d5-b3fb-c0a58253c1f6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("83e4fc44-2ace-442c-9678-ab29c603803c")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("83e4fc44-2ace-442c-9678-ab29c603803c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ChoixDate item.
            /// </summary>
            [RepositoryItem("71bce84f-279d-4e76-a06e-8671ef0c8a0d")]
            public virtual Ranorex.Container ChoixDate
            {
                get
                {
                    return _choixdateInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The ChoixDate item info.
            /// </summary>
            [RepositoryItemInfo("71bce84f-279d-4e76-a06e-8671ef0c8a0d")]
            public virtual RepoItemInfo ChoixDateInfo
            {
                get
                {
                    return _choixdateInfo;
                }
            }

            /// <summary>
            /// The BtnDay item.
            /// </summary>
            [RepositoryItem("b1721715-9696-4b9b-a1a1-49492be437e3")]
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
            [RepositoryItemInfo("b1721715-9696-4b9b-a1a1-49492be437e3")]
            public virtual RepoItemInfo BtnDayInfo
            {
                get
                {
                    return _btndayInfo;
                }
            }

            /// <summary>
            /// The ChoixDate1 item.
            /// </summary>
            [RepositoryItem("dc2152b7-0c20-48d5-b3fb-c0a58253c1f6")]
            public virtual Ranorex.RawText ChoixDate1
            {
                get
                {
                    return _choixdate1Info.CreateAdapter<Ranorex.RawText>(true);
                }
            }

            /// <summary>
            /// The ChoixDate1 item info.
            /// </summary>
            [RepositoryItemInfo("dc2152b7-0c20-48d5-b3fb-c0a58253c1f6")]
            public virtual RepoItemInfo ChoixDate1Info
            {
                get
                {
                    return _choixdate1Info;
                }
            }
        }

        /// <summary>
        /// The DEVWTOKYOAppFolder folder.
        /// </summary>
        [RepositoryFolder("d6c6db02-e20b-4a89-b4a3-c28618527c78")]
        public partial class DEVWTOKYOAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _devwtokyoInfo;

            /// <summary>
            /// Creates a new DEVWTOKYO  folder.
            /// </summary>
            public DEVWTOKYOAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DEVWTOKYO", "", parentFolder, 30000, null, true, "d6c6db02-e20b-4a89-b4a3-c28618527c78", "")
            {
                _devwtokyoInfo = new RepoItemInfo(this, "DEVWTOKYO", "", "", 30000, null, "fd5df834-9c45-4285-b62d-1aa5df420795");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d6c6db02-e20b-4a89-b4a3-c28618527c78")]
            public virtual Ranorex.Host Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Host>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d6c6db02-e20b-4a89-b4a3-c28618527c78")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DEVWTOKYO item.
            /// </summary>
            [RepositoryItem("fd5df834-9c45-4285-b62d-1aa5df420795")]
            public virtual Ranorex.Host DEVWTOKYO
            {
                get
                {
                    return _devwtokyoInfo.CreateAdapter<Ranorex.Host>(true);
                }
            }

            /// <summary>
            /// The DEVWTOKYO item info.
            /// </summary>
            [RepositoryItemInfo("fd5df834-9c45-4285-b62d-1aa5df420795")]
            public virtual RepoItemInfo DEVWTOKYOInfo
            {
                get
                {
                    return _devwtokyoInfo;
                }
            }
        }

        /// <summary>
        /// The ChoixDuneConfigurationAppFolder folder.
        /// </summary>
        [RepositoryFolder("4b93a97a-062e-4924-b874-c0ae8d6a0f2d")]
        public partial class ChoixDuneConfigurationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _heidenhainlsv2Info;
            RepoItemInfo _elementbokInfo;

            /// <summary>
            /// Creates a new ChoixDuneConfiguration  folder.
            /// </summary>
            public ChoixDuneConfigurationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ChoixDuneConfiguration", "/form[@name='PresetCNCForm']", parentFolder, 30000, null, true, "4b93a97a-062e-4924-b874-c0ae8d6a0f2d", "")
            {
                _heidenhainlsv2Info = new RepoItemInfo(this, "HeidenhainLSV2", ".//list[@name='lbPreset']/listitem[@name='Heidenhain LSV2']", "", 30000, null, "f899cc1f-f5fc-4c3a-8a64-c5bd4cb2a8a6");
                _elementbokInfo = new RepoItemInfo(this, "ElementBOk", "?/?/element[@name='bOk']", "", 30000, null, "49a3523b-8556-4c1e-8759-08e919032ea7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4b93a97a-062e-4924-b874-c0ae8d6a0f2d")]
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
            [RepositoryItemInfo("4b93a97a-062e-4924-b874-c0ae8d6a0f2d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HeidenhainLSV2 item.
            /// </summary>
            [RepositoryItem("f899cc1f-f5fc-4c3a-8a64-c5bd4cb2a8a6")]
            public virtual Ranorex.ListItem HeidenhainLSV2
            {
                get
                {
                    return _heidenhainlsv2Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The HeidenhainLSV2 item info.
            /// </summary>
            [RepositoryItemInfo("f899cc1f-f5fc-4c3a-8a64-c5bd4cb2a8a6")]
            public virtual RepoItemInfo HeidenhainLSV2Info
            {
                get
                {
                    return _heidenhainlsv2Info;
                }
            }

            /// <summary>
            /// The ElementBOk item.
            /// </summary>
            [RepositoryItem("49a3523b-8556-4c1e-8759-08e919032ea7")]
            public virtual Ranorex.Unknown ElementBOk
            {
                get
                {
                    return _elementbokInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The ElementBOk item info.
            /// </summary>
            [RepositoryItemInfo("49a3523b-8556-4c1e-8759-08e919032ea7")]
            public virtual RepoItemInfo ElementBOkInfo
            {
                get
                {
                    return _elementbokInfo;
                }
            }
        }

        /// <summary>
        /// The ProprietesPourCnc1AppFolder folder.
        /// </summary>
        [RepositoryFolder("218d4a8f-1334-4369-9346-ffeb809b8f3a")]
        public partial class ProprietesPourCnc1AppFolder : RepoGenBaseFolder
        {
            DevAutomatisationRepositoryFolders.TvCategoryFolder _tvcategory;
            DevAutomatisationRepositoryFolders.TabSheet11Folder _tabsheet11;
            RepoItemInfo _somebuttonInfo;
            RepoItemInfo _somebutton1Info;
            RepoItemInfo _buttonappliquerInfo;

            /// <summary>
            /// Creates a new ProprietesPourCnc1  folder.
            /// </summary>
            public ProprietesPourCnc1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("ProprietesPourCnc1", "/form[@name='CncOptionsForm']", parentFolder, 30000, null, true, "218d4a8f-1334-4369-9346-ffeb809b8f3a", "")
            {
                _tvcategory = new DevAutomatisationRepositoryFolders.TvCategoryFolder(this);
                _tabsheet11 = new DevAutomatisationRepositoryFolders.TabSheet11Folder(this);
                _somebuttonInfo = new RepoItemInfo(this, "SomeButton", ".//container[@name='TabSheet11']//container[@name='TabSheet8']/combobox[@name='cbProgMode']/button[@text='>']", "", 30000, null, "45fb5e53-1b25-4e44-b49a-8a599668ebdf");
                _somebutton1Info = new RepoItemInfo(this, "SomeButton1", ".//container[@name='TabSheet11']//container[@name='TabSheet8']/combobox[@name='cbAlarmMode']/button[@text='>']", "", 30000, null, "1128a793-a441-4492-b810-dba70935cefa");
                _buttonappliquerInfo = new RepoItemInfo(this, "ButtonAppliquer", "?/?/button[@name='bOK']", "", 30000, null, "ec735c1d-a954-4cbe-8931-dcc2be1d9caf");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("218d4a8f-1334-4369-9346-ffeb809b8f3a")]
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
            [RepositoryItemInfo("218d4a8f-1334-4369-9346-ffeb809b8f3a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeButton item.
            /// </summary>
            [RepositoryItem("45fb5e53-1b25-4e44-b49a-8a599668ebdf")]
            public virtual Ranorex.Button SomeButton
            {
                get
                {
                    return _somebuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SomeButton item info.
            /// </summary>
            [RepositoryItemInfo("45fb5e53-1b25-4e44-b49a-8a599668ebdf")]
            public virtual RepoItemInfo SomeButtonInfo
            {
                get
                {
                    return _somebuttonInfo;
                }
            }

            /// <summary>
            /// The SomeButton1 item.
            /// </summary>
            [RepositoryItem("1128a793-a441-4492-b810-dba70935cefa")]
            public virtual Ranorex.Button SomeButton1
            {
                get
                {
                    return _somebutton1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SomeButton1 item info.
            /// </summary>
            [RepositoryItemInfo("1128a793-a441-4492-b810-dba70935cefa")]
            public virtual RepoItemInfo SomeButton1Info
            {
                get
                {
                    return _somebutton1Info;
                }
            }

            /// <summary>
            /// The ButtonAppliquer item.
            /// </summary>
            [RepositoryItem("ec735c1d-a954-4cbe-8931-dcc2be1d9caf")]
            public virtual Ranorex.Button ButtonAppliquer
            {
                get
                {
                    return _buttonappliquerInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonAppliquer item info.
            /// </summary>
            [RepositoryItemInfo("ec735c1d-a954-4cbe-8931-dcc2be1d9caf")]
            public virtual RepoItemInfo ButtonAppliquerInfo
            {
                get
                {
                    return _buttonappliquerInfo;
                }
            }

            /// <summary>
            /// The TvCategory folder.
            /// </summary>
            [RepositoryFolder("175aed70-0f32-44f4-9421-30d07daea6ba")]
            public virtual DevAutomatisationRepositoryFolders.TvCategoryFolder TvCategory
            {
                get { return _tvcategory; }
            }

            /// <summary>
            /// The TabSheet11 folder.
            /// </summary>
            [RepositoryFolder("c5e6b3df-d70a-4ba1-a62c-3c39bb0e1482")]
            public virtual DevAutomatisationRepositoryFolders.TabSheet11Folder TabSheet11
            {
                get { return _tabsheet11; }
            }
        }

        /// <summary>
        /// The TvCategoryFolder folder.
        /// </summary>
        [RepositoryFolder("175aed70-0f32-44f4-9421-30d07daea6ba")]
        public partial class TvCategoryFolder : RepoGenBaseFolder
        {
            RepoItemInfo _collectedevenementsInfo;
            RepoItemInfo _variablesdetatsInfo;
            RepoItemInfo _lsv2Info;

            /// <summary>
            /// Creates a new TvCategory  folder.
            /// </summary>
            public TvCategoryFolder(RepoGenBaseFolder parentFolder) :
                    base("TvCategory", "?/?/tree[@name='tvCategory']", parentFolder, 30000, null, false, "175aed70-0f32-44f4-9421-30d07daea6ba", "")
            {
                _collectedevenementsInfo = new RepoItemInfo(this, "CollecteDevenements", "?/?/treeitem[@text='Collecte d''événements']", "", 30000, null, "196dcef0-96f3-422f-8885-8cbaf7169469");
                _variablesdetatsInfo = new RepoItemInfo(this, "VariablesDetats", "?/?/treeitem[@text='Variables d''états']", "", 30000, null, "e95dd45f-880f-48c6-8600-aa29d9609742");
                _lsv2Info = new RepoItemInfo(this, "LSV2", "treeitem[@text='PRODUCTION']/treeitem[@text='LSV2']", "", 30000, null, "b1807b57-1604-45f2-a597-c4b00c6bba78");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("175aed70-0f32-44f4-9421-30d07daea6ba")]
            public virtual Ranorex.Tree Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Tree>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("175aed70-0f32-44f4-9421-30d07daea6ba")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CollecteDevenements item.
            /// </summary>
            [RepositoryItem("196dcef0-96f3-422f-8885-8cbaf7169469")]
            public virtual Ranorex.TreeItem CollecteDevenements
            {
                get
                {
                    return _collectedevenementsInfo.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The CollecteDevenements item info.
            /// </summary>
            [RepositoryItemInfo("196dcef0-96f3-422f-8885-8cbaf7169469")]
            public virtual RepoItemInfo CollecteDevenementsInfo
            {
                get
                {
                    return _collectedevenementsInfo;
                }
            }

            /// <summary>
            /// The VariablesDetats item.
            /// </summary>
            [RepositoryItem("e95dd45f-880f-48c6-8600-aa29d9609742")]
            public virtual Ranorex.TreeItem VariablesDetats
            {
                get
                {
                    return _variablesdetatsInfo.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The VariablesDetats item info.
            /// </summary>
            [RepositoryItemInfo("e95dd45f-880f-48c6-8600-aa29d9609742")]
            public virtual RepoItemInfo VariablesDetatsInfo
            {
                get
                {
                    return _variablesdetatsInfo;
                }
            }

            /// <summary>
            /// The LSV2 item.
            /// </summary>
            [RepositoryItem("b1807b57-1604-45f2-a597-c4b00c6bba78")]
            public virtual Ranorex.TreeItem LSV2
            {
                get
                {
                    return _lsv2Info.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The LSV2 item info.
            /// </summary>
            [RepositoryItemInfo("b1807b57-1604-45f2-a597-c4b00c6bba78")]
            public virtual RepoItemInfo LSV2Info
            {
                get
                {
                    return _lsv2Info;
                }
            }
        }

        /// <summary>
        /// The TabSheet11Folder folder.
        /// </summary>
        [RepositoryFolder("c5e6b3df-d70a-4ba1-a62c-3c39bb0e1482")]
        public partial class TabSheet11Folder : RepoGenBaseFolder
        {
            RepoItemInfo _txtprodlsv2ipInfo;
            RepoItemInfo _activerlacollectedesalarmesInfo;
            RepoItemInfo _activerlacollectedesprogrammescouraInfo;
            RepoItemInfo _activerlacollectedesprogrammesencoInfo;
            RepoItemInfo _somebuttonInfo;

            /// <summary>
            /// Creates a new TabSheet11  folder.
            /// </summary>
            public TabSheet11Folder(RepoGenBaseFolder parentFolder) :
                    base("TabSheet11", "container[@name='ContainerPanel']/?/?/container[@name='TabSheet11']", parentFolder, 30000, null, false, "c5e6b3df-d70a-4ba1-a62c-3c39bb0e1482", "")
            {
                _txtprodlsv2ipInfo = new RepoItemInfo(this, "TxtProdLSV2ip", ".//container[@name='TabSheet6']/text[@name='txtProdLSV2ip']", "", 30000, null, "21d5894f-9a1d-4cc7-8cb0-015f8c9c9b8a");
                _activerlacollectedesalarmesInfo = new RepoItemInfo(this, "ActiverLaCollecteDesAlarmes", ".//container[@name='TabSheet8']/checkbox[@name='ckEnableAlarmCollect']", "", 30000, null, "a55a9c7f-b2a7-410c-850e-a1aed401bcc2");
                _activerlacollectedesprogrammescouraInfo = new RepoItemInfo(this, "ActiverLaCollecteDesProgrammesCoura", ".//container[@name='TabSheet8']/checkbox[@name='ckEnableProgCollect']", "", 30000, null, "7ae60e81-c8f9-4843-a0cb-366754f99982");
                _activerlacollectedesprogrammesencoInfo = new RepoItemInfo(this, "ActiverLaCollecteDesProgrammesEnCo", ".//container[@name='TabSheet8']/checkbox[@name>'ckEnableRunningProgCollec']", "", 30000, null, "dc9fe292-543f-495b-b49f-f5d2949700f0");
                _somebuttonInfo = new RepoItemInfo(this, "SomeButton", ".//container[@name='TabSheet8']/combobox[@name='cbRunningPrgMode']/button[@text='>']", "", 30000, null, "96d04dfb-ace9-4857-ab70-6fd485602f90");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c5e6b3df-d70a-4ba1-a62c-3c39bb0e1482")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c5e6b3df-d70a-4ba1-a62c-3c39bb0e1482")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TxtProdLSV2ip item.
            /// </summary>
            [RepositoryItem("21d5894f-9a1d-4cc7-8cb0-015f8c9c9b8a")]
            public virtual Ranorex.Text TxtProdLSV2ip
            {
                get
                {
                    return _txtprodlsv2ipInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtProdLSV2ip item info.
            /// </summary>
            [RepositoryItemInfo("21d5894f-9a1d-4cc7-8cb0-015f8c9c9b8a")]
            public virtual RepoItemInfo TxtProdLSV2ipInfo
            {
                get
                {
                    return _txtprodlsv2ipInfo;
                }
            }

            /// <summary>
            /// The ActiverLaCollecteDesAlarmes item.
            /// </summary>
            [RepositoryItem("a55a9c7f-b2a7-410c-850e-a1aed401bcc2")]
            public virtual Ranorex.CheckBox ActiverLaCollecteDesAlarmes
            {
                get
                {
                    return _activerlacollectedesalarmesInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The ActiverLaCollecteDesAlarmes item info.
            /// </summary>
            [RepositoryItemInfo("a55a9c7f-b2a7-410c-850e-a1aed401bcc2")]
            public virtual RepoItemInfo ActiverLaCollecteDesAlarmesInfo
            {
                get
                {
                    return _activerlacollectedesalarmesInfo;
                }
            }

            /// <summary>
            /// The ActiverLaCollecteDesProgrammesCoura item.
            /// </summary>
            [RepositoryItem("7ae60e81-c8f9-4843-a0cb-366754f99982")]
            public virtual Ranorex.CheckBox ActiverLaCollecteDesProgrammesCoura
            {
                get
                {
                    return _activerlacollectedesprogrammescouraInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The ActiverLaCollecteDesProgrammesCoura item info.
            /// </summary>
            [RepositoryItemInfo("7ae60e81-c8f9-4843-a0cb-366754f99982")]
            public virtual RepoItemInfo ActiverLaCollecteDesProgrammesCouraInfo
            {
                get
                {
                    return _activerlacollectedesprogrammescouraInfo;
                }
            }

            /// <summary>
            /// The ActiverLaCollecteDesProgrammesEnCo item.
            /// </summary>
            [RepositoryItem("dc9fe292-543f-495b-b49f-f5d2949700f0")]
            public virtual Ranorex.CheckBox ActiverLaCollecteDesProgrammesEnCo
            {
                get
                {
                    return _activerlacollectedesprogrammesencoInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The ActiverLaCollecteDesProgrammesEnCo item info.
            /// </summary>
            [RepositoryItemInfo("dc9fe292-543f-495b-b49f-f5d2949700f0")]
            public virtual RepoItemInfo ActiverLaCollecteDesProgrammesEnCoInfo
            {
                get
                {
                    return _activerlacollectedesprogrammesencoInfo;
                }
            }

            /// <summary>
            /// The SomeButton item.
            /// </summary>
            [RepositoryItem("96d04dfb-ace9-4857-ab70-6fd485602f90")]
            public virtual Ranorex.Button SomeButton
            {
                get
                {
                    return _somebuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SomeButton item info.
            /// </summary>
            [RepositoryItemInfo("96d04dfb-ace9-4857-ab70-6fd485602f90")]
            public virtual RepoItemInfo SomeButtonInfo
            {
                get
                {
                    return _somebuttonInfo;
                }
            }
        }

        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("90397706-b3cb-46a4-8f7f-3057032eef2c")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _vialsv2Info;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@controlid='1000']", parentFolder, 30000, null, true, "90397706-b3cb-46a4-8f7f-3057032eef2c", "")
            {
                _vialsv2Info = new RepoItemInfo(this, "ViaLSV2", "listitem[@text='Via LSV2']", "", 30000, null, "f4935e04-21b3-4dcc-9a3e-e42c0ffddc52");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("90397706-b3cb-46a4-8f7f-3057032eef2c")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("90397706-b3cb-46a4-8f7f-3057032eef2c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ViaLSV2 item.
            /// </summary>
            [RepositoryItem("f4935e04-21b3-4dcc-9a3e-e42c0ffddc52")]
            public virtual Ranorex.ListItem ViaLSV2
            {
                get
                {
                    return _vialsv2Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ViaLSV2 item info.
            /// </summary>
            [RepositoryItemInfo("f4935e04-21b3-4dcc-9a3e-e42c0ffddc52")]
            public virtual RepoItemInfo ViaLSV2Info
            {
                get
                {
                    return _vialsv2Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
