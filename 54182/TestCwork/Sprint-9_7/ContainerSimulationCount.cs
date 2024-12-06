/*
 * Created by Ranorex
 * User: Dev
 * Date: 19/04/2023
 * Time: 17:13
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Sprint_9_7
{
    /// <summary>
    /// Description of ContainerSimulationCount.
    /// </summary>
    [TestModule("12AA5EFC-E71D-4B07-B6A9-21EEBE2364FA", ModuleType.UserCode, 1)]
    public class ContainerSimulationCount : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ContainerSimulationCount()
        {
        	
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
           // Button fermer = "/form[@name='Simulation']/?/?/button[@accessiblename='Fermer']";
            Container scrollBox1 = "/form[@name='Simulation']/container[@name='ScrollBox1']";
            if (scrollBox1.Children.Count != 5) {
            	Report.Failure("test failed");
				Report.Log(ReportLevel.Failure, "test failed number of element counter is wrong");

            }
        }
    }
}
