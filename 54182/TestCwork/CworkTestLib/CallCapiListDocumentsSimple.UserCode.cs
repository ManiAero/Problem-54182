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

namespace CworkTestLib
{
    public partial class CallCapiListDocumentsSimple
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void GetAllDocs(int expectedItems, string reference, string binBehavior)
        {
        
			string EndPoint = "documents?";
			if (reference.Length > 0) {
				EndPoint += "reference=" + reference + "&";
			}
			if (binBehavior.Length > 0) {
				EndPoint += "recycle_bin=" + binBehavior;
			}
			string url = " http://localhost:4445/CAPI/REST/"+EndPoint;
			string ResAPICall = RestAPIMethods.SendGet(url);
			Report.Log(ReportLevel.Info, "Query  "+ url);
			Report.Log(ReportLevel.Info, "ResAPICall  "+ ResAPICall);	
			
			String Documents = RestAPIMethods.ExtractDocumentsAsJsonString(ResAPICall);
			int NbDocuments = RestAPIMethods.GetDocumentsCount(Documents);
			//Verify Docs
	    	if (NbDocuments == expectedItems)
	    	{
	    		Report.Success("Validation", "GetAllDocs Okay");
	    	} else {
	    		Report.Failure("Echec !", "GetAllDocs wrong number of documents received");
	    	}
        }

    }
}
