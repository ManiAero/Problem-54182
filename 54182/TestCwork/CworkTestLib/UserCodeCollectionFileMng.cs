/*
 * Created by Ranorex
 * User: Dev
 * Date: 04/11/2021
 * Time: 15:17
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

using System.IO;

namespace CworkTestLib
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    /// 
    

    [UserCodeCollection]
    public class UserCodeCollectionFileMng
    {
		private const string newLineRegexPattern = "(\r\n)|(\n)|(\r)";    	
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].

        /// <summary>
        /// Repeatedly checks if directory exist.
        /// </summary>
        /// <param name="path">The relative or absolute path to search</param>
        /// <param name="duration">Defines the search timeout in milliseconds</param>
        /// <param name="interval">Sets the interval in milliseconds at which the files are checked for the pattern</param>
        [UserCodeMethod]
        public static void WaitForFolder(string path, int duration, int interval)
        {
            var bFound = Directory.Exists(path);
            var start = System.DateTime.Now;
            
            while (!bFound && (System.DateTime.Now < start + TimeSpan.FromMilliseconds(duration)))
            {

                bFound = Directory.Exists(path);

                if (bFound)
                {
                    break;
                }

                Delay.Duration(Duration.FromMilliseconds(interval), false);
            }

            if (bFound)
            {
                Report.Success("Validation",  "' Find directory '" + path + "'.");
            }
            else
            {
                Report.Failure("Validation",  "' NOT Find directory '" + path + "'.");
            }            
            
        }
        
	    /// <summary>
	    /// Checks if directory not exist.
	    /// </summary>
	    /// <param name="path">The relative or absolute path for the folder</param>       
        [UserCodeMethod]
        public static void CheckFolderNotExist(string path)
        {
        	Report.Info("Check if '" + path + " does not exist");
        	Validate.IsFalse(Directory.Exists(path));
        }
        
        
        /// <summary>
        /// Check if file do not contains the text
	    /// </summary>
        /// <param name="FileToScanPath">The relative or absolute path to search</param>
        /// <param name="textNotTofind">Text that should de not prsent/</param>
        [UserCodeMethod]
        public static void CheckIfFileNotContainText(string FileToScanPath, string textNotTofind)
        {
        	try
        	{
        		var textFound = false;

        		if (Regex.IsMatch(textNotTofind, newLineRegexPattern))
        		{
        			if (File.ReadAllText(FileToScanPath).Contains(textNotTofind))
        			{
        				Report.Log(ReportLevel.Info, "Text '" + textNotTofind + "' was found in file " + FileToScanPath + "'.");
        				textFound = true;
        			}
        		}
        		else
        		{
        			using (StreamReader sr = new StreamReader(FileToScanPath))
        			{
        				var line = "";
        				var i = 1;

        				while ((line = sr.ReadLine()) != null)
        				{
        					if (line.IndexOf(textNotTofind, StringComparison.OrdinalIgnoreCase) != -1)
        					{
        						Report.Log(ReportLevel.Info, "Text '" + textNotTofind + "' was found on line " + i + ": '" + line + "'.");
        						textFound = true;
        					}

        					++i;
        				}
        			}
        		}

        		if (!textFound)
        		{
        			Report.Success("Validation",  "File " + FileToScanPath + " do not contains "+ textNotTofind);
        		}else
        		{
        			Report.Failure("Validation",  "File " + FileToScanPath + " contains "+ textNotTofind);;
        		}
        	}
        	catch (Exception ex)
        	{
        		Report.Failure("exception :"+ex.ToString());
        	}

        }
    }
}
