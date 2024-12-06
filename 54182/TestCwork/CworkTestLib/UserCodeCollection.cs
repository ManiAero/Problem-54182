/*
 * Created by Ranorex
 * User: Dev
 * Date: 03/05/2021
 * Time: 12:04
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

using System.Diagnostics;

using System.IO;

namespace CworkTestLib
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollection
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static int GetLastYear()
        {
        	return 2023;
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        // to add a new method with the attribute [UserCodeMethod].
        [UserCodeMethod]
        public static void RunProgramAndWait(string path, string args, int waitSeconds)
        {
        	string projectDirectory = TestSuite.WorkingDirectory.ToString() + "\\..\\..\\";
        	Directory.SetCurrentDirectory(projectDirectory);
        	path = projectDirectory + "..\\..\\" + path;
        	Report.Log(ReportLevel.Info, "UserCode", "Run RunProgramAndWait " +  path, new RecordItemIndex(1));
    		Process process = new Process();    // Configure the process using the StartInfo properties.
			process.StartInfo.FileName = path;
			process.StartInfo.Arguments = args;
			if (!process.Start())
				throw new RanorexException("Could not create process '" + path + "'");
			if (!process.WaitForExit(waitSeconds * 1000))
				throw new RanorexException("Process '" + path + "' failed to terminate within " + waitSeconds.ToString() + " seconds");
        }

        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void EnableDelphiPlugin()
        {
        	 Ranorex.Core.Configuration.Current["plugin.delphi.enabled"] = true;
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void DisableDelphiPlugin()
        {
        	Ranorex.Core.Configuration.Current["plugin.delphi.enabled"] = false;
        }
        
        
    }
    
}
