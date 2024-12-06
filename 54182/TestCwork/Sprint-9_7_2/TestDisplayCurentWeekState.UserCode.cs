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
    public partial class TestDisplayCurentWeekState
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public string GetCurentDate()
        {
			System.DateTime CurentDate = System.DateTime.Now;
        	System.DateTime CurentDayDate = new System.DateTime(CurentDate.Year, CurentDate.Month,
                                                             CurentDate.Day, 0,
                                                             0, 0);
			return CurentDayDate.ToString("dd/MM/yyyy");
        }

        public string GetFirstDayOfWeek()
        {
			System.DateTime CurentDate = System.DateTime.Now;
			int currentDayInt = (int)CurentDate.DayOfWeek - 1;
        	System.DateTime FirstDayOfWeek = new System.DateTime(CurentDate.Year, CurentDate.Month,
                                                             CurentDate.Day, 0,
                                                             0, 0).AddDays(-currentDayInt);
			return FirstDayOfWeek.ToString("dd/MM/yyyy");
        }

    }
}
