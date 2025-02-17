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

namespace Sprint_9_7_2
{
    public partial class CreateStatesForWeekStateDisplay
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        public void InserStatesForWeekStateDisplay(Int32 cnc)
        {
			System.DateTime CurentDate = System.DateTime.Now;
			
        	System.DateTime CurentDayDate = new System.DateTime(CurentDate.Year, CurentDate.Month,
                                                             CurentDate.Day, 0,
                                                             0, 0);
			
			int currentDayInt = (int)CurentDayDate.DayOfWeek - 1;

            System.DateTime CurentDayBeginWeekDate = CurentDayDate.AddDays(-currentDayInt);
			
        	System.DateTime FirstDay = new System.DateTime(CurentDayBeginWeekDate.Year, CurentDayBeginWeekDate.Month,
                                                             CurentDayBeginWeekDate.Day, 0,
                                                             0, 0);
			
        	CworkTestLib.AccesDatabaseMethods.OpenDatabaseConnexion();
        	CworkTestLib.AccesDatabaseMethods.ClearTopTableContents(cnc);
        	CworkTestLib.AccesDatabaseMethods.InsertTopsEventProgram(1,1,FirstDay,FirstDay,"st1");
        	CworkTestLib.AccesDatabaseMethods.InsertTopsEventProgram(1,4,FirstDay.AddHours(-1),FirstDay,"st2");
        	CworkTestLib.AccesDatabaseMethods.InsertTopsEventProgram(1,3,FirstDay.AddHours(-1).AddMinutes(-15),FirstDay.AddHours(-1),"st3");
        	CworkTestLib.AccesDatabaseMethods.CloseDatabaseConnexion();
        }

    }
}
