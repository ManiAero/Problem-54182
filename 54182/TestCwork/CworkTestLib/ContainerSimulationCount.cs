/*
 * Created by Ranorex
 * User: Dev
 * Date: 20/04/2023
 * Time: 09:06
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

namespace CworkTestLib
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class ContainerSimulationCount : ITestModule
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
         void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Container scrollBox1 = "/form[@name='Simulation']/container[@name='ScrollBox1']";
            if (scrollBox1.Children.Count != 5) {
            	Report.Failure("test failed");
				Report.Log(ReportLevel.Failure, "test failed number of element counter is wrong");

            }
         }
    }
}
