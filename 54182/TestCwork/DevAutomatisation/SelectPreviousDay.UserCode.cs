﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DevAutomatisation
{
    public partial class SelectPreviousDay
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_date(RepoItemInfo rawtextInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'rawtextInfo' at Center.", rawtextInfo);
            rawtextInfo.FindAdapter<RawText>().Click();
        }

        public void Mouse_Click_date1(RepoItemInfo rawtextInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'rawtextInfo' at Center.", rawtextInfo);
            rawtextInfo.FindAdapter<RawText>().Click();
        }

        public string GetDayBeforToday()
        {
        	string MaDateYesterday= System.DateTime.Now.AddDays(-1).Day.ToString();;
            
            Report.Log(ReportLevel.Info, "NumDay = "+ MaDateYesterday);
            return MaDateYesterday;

        }

    }
}
