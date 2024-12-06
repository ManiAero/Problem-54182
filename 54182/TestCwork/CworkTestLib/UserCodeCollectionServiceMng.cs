/*
 * Created by Ranorex
 * User: Dev
 * Date: 25/04/2023
 * Time: 17:35
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

using System.ServiceProcess;

namespace CworkTestLib
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollectionServiceMng
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// Start Windows service
        /// </summary>
        [UserCodeMethod]
        public static void StartWindowsService(string ServiceName)
        {
			try
			{
				ServiceController sc  = new ServiceController();
				sc.ServiceName = ServiceName;
				if (sc.Status == ServiceControllerStatus.Running)
				{
					Report.Success("Validation",  "service " + ServiceName + " Started");
				}else if (sc.Status == ServiceControllerStatus.Stopped)
				{
					// Start the service, and wait until its status is "Running".
					sc.Start();
					sc.WaitForStatus(ServiceControllerStatus.Running);
					Report.Success("Validation",  "service " + ServiceName + " Started");
				} else
				{
					Report.Failure("Validation",  "Could not start "+ ServiceName +" service.");
				}
			}
			catch (Exception e)
			{
				Report.Error("Unexpected exception occurred: " + e.ToString());
			}        	
        }
        
        /// <summary>
        /// Start Windows service
        /// </summary>
        [UserCodeMethod]
        public static void StopWindowsService(string ServiceName)
        {
			try
			{
				ServiceController sc  = new ServiceController();
				sc.ServiceName = ServiceName;
				if (sc.Status == ServiceControllerStatus.Stopped)
				{
					Report.Success("Validation",  "service " + ServiceName + " Stopped");
				}else if (sc.Status == ServiceControllerStatus.Running)
				{
					// Start the service, and wait until its status is "Running".
					sc.Stop();
					sc.WaitForStatus(ServiceControllerStatus.Stopped);
					Report.Success("Validation",  "service " + ServiceName + " Stopped");
				} else
				{
					Report.Failure("Validation",  "Could not stop "+ ServiceName +" service.");
				}
			}
			catch (Exception e)
			{
				Report.Error("Unexpected exception occurred: " + e.ToString());
			}        	
        }        
    }
}
