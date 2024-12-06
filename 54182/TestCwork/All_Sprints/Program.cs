/*
 * Created by Ranorex
 * User: Dev
 * Date: 20/12/2021
 * Time: 15:29
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace All_Sprints
{
    class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            // Uncomment the following 2 lines if you want to automate Windows apps
            // by starting the test executable directly
            //if (Util.IsRestartRequiredForWinAppAccess)
            //    return Util.RestartWithUiAccess();

            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error = 0;

            try
            {
                //error = TestSuiteRunner.Run(typeof(Program), Environment.CommandLine);
                // ajouter les projets a lancer ci dessous
                // ne pas oublier de changer public class Program dans les projets concernés
                // ajouter les projet en refference dans l onglet reference
                Sprint9_5_2.Program.Main(null);
                Sprint9_5_3.Program.Main(null);
                Sprint9_6.Program.Main(null);
                Sprint9_6_1.Program.Main(null);
                Sprint_9_6_2.Program.Main(null);
                Sprint_9_6_3.Program.Main(null);
                Sprint_9_7.Program.Main(null);
                Sprint_9_7_1.Program.Main(null);
				Sprint_9_7_2.Program.Main(null);                 
            }
            catch (Exception e)
            {
                Report.Error("Unexpected exception occurred: " + e.ToString());
                error = -1;
            }
            return error;
        }
    }
}
