/*
 * Created by Ranorex
 * User: Dev
 * Date: 12/08/2024
 * Time: 14:07
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

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace CworkTestLib
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollectionProgramCwork
    {
    	[UserCodeMethod]
    	public static int GetDocId(int CncId, string Reference ,string usr ,string psw)
    	{
    		Report.Log(ReportLevel.Info,"Start méthode GetDocId");
        	//http://localhost:4445/CAPI/REST/documents?station=1
			string station = CncId.ToString();
			string EndPoint = "documents?station="+station;			
			string url = " http://localhost:4445/CAPI/REST/"+EndPoint;
			string ResAPICall = RestAPIMethods.SendGet(url,usr, psw, null);
			Report.Log(ReportLevel.Info, "Query  "+ url + " usr:"+usr+" psw:"+psw);
			Report.Log(ReportLevel.Info, "ResAPICall  "+ ResAPICall);	
			
			//extract document id
			JObject jsonObject = JObject.Parse(ResAPICall);
			JArray documents = (JArray)jsonObject["Documents"];

			foreach (var document in documents)
			{
				if (document["Reference"].ToString() == Reference)
				{
					int documentId = (int)document["DocumentId"];
					Report.Log(ReportLevel.Info, "DocumentId returned for reference " + Reference+ " is: "+documentId.ToString());
					return documentId;
				}
			}
 			
    		return 0;
    	}
    	[UserCodeMethod]
      	public static int GetfirstVer(int CncId, int _docId, string usr, string psw)
    	{
      		Report.Log(ReportLevel.Info,"Start méthode GetfirstVer");
      		//http://localhost:4445/CAPI/REST/documents/1/versions
      		string DocumentIdStr = _docId.ToString();
			string url = " http://localhost:4445/CAPI/REST/documents/"+DocumentIdStr+"/versions";
			string ResAPICall = RestAPIMethods.SendGet(url,usr, psw, null);
			Report.Log(ReportLevel.Info, "Query  "+ url + " usr:"+usr+" psw:"+psw);
			Report.Log(ReportLevel.Info, "ResAPICall  "+ ResAPICall);
			
			dynamic jObj = JsonConvert.DeserializeObject(ResAPICall);
			int FirstVersionId = jObj.First.VersionId;
			Report.Log(ReportLevel.Info,"First version id returned is : "+ FirstVersionId.ToString());
			return FirstVersionId;    		
    		
    		
    	}  
    	[UserCodeMethod]
      	public static int GetlasttVer(int CncId, int _docId, string usr, string psw)
    	{
      		Report.Log(ReportLevel.Info,"Start méthode GetlasttVer");
      		//http://localhost:4445/CAPI/REST/documents/1/versions
      		string DocumentIdStr = _docId.ToString();
			string url = " http://localhost:4445/CAPI/REST/documents/"+DocumentIdStr+"/versions";
			string ResAPICall = RestAPIMethods.SendGet(url,usr, psw, null);
			Report.Log(ReportLevel.Info, "Query  "+ url + " usr:"+usr+" psw:"+psw);
			Report.Log(ReportLevel.Info, "ResAPICall  "+ ResAPICall);
			
			dynamic jObj = JsonConvert.DeserializeObject(ResAPICall);
			int LastVersionId = jObj.Last.VersionId;
			Report.Log(ReportLevel.Info,"Last version id returned is : "+ LastVersionId.ToString());
			return LastVersionId;    		
    		
    		
    	}  
		 [UserCodeMethod]
		 public static int IncVersionId(int VersionId, int Inc)
		 {
		 	Report.Log(ReportLevel.Info,"Start méthode IncVersionId");
		 	Report.Log(ReportLevel.Info,"Version is : "+ VersionId.ToString()+ " Inc is "+Inc.ToString());
		 	return (VersionId+Inc);
		 }
		[UserCodeMethod]		 
    	public static int Certify(int CncId,string NewStatus, int DocId, int FirstVersionId, string Comment, string usr, string psw)
    	{
    		Report.Log(ReportLevel.Info,"Start méthode Certify");
    		//post http://localhost:4445/CAPI/REST/documents/1/versions/1/certify
    		string DocumentIdStr = DocId.ToString();
    		string versionIdStr = FirstVersionId.ToString();
    		string url = " http://localhost:4445/CAPI/REST/documents/"+DocumentIdStr+"/versions/"+versionIdStr+"/certify";
    		Report.Log(ReportLevel.Info, "Query  "+ url + " usr:"+usr+" psw:"+psw);
    		
    		object body;
    		body = new {
    			Comments=Comment,
    			NewStatus=NewStatus
    		};
 
			string ResAPICall = RestAPIMethods.SendPost(url, usr, psw, body);
			
			Report.Log(ReportLevel.Info, "ResAPICall  "+ ResAPICall);   		
		    		
	        // Parse the JSON string into a JObject
	        JObject jsonObject = JObject.Parse(ResAPICall);
	
	        // Extract the value of VersionId
	        int versionId = (int)jsonObject["VersionId"];		
			
	        Report.Log(ReportLevel.Info, "Version Id reported by Certify API call  "+ versionId);
	        
			return versionId;
			
		
    	}
		[UserCodeMethod]		 
    	public static void Certify(int CncId,string NewStatus, int DocId, int FirstVersionId, string Comment,
		                             string usr, string psw, string ExpectedRes)
    	{
    		Report.Log(ReportLevel.Info,"Start méthode Certify");
			//post http://localhost:4445/CAPI/REST/documents/1/versions/1/certify
    		string DocumentIdStr = DocId.ToString();
    		string versionIdStr = FirstVersionId.ToString();
    		string url = " http://localhost:4445/CAPI/REST/documents/"+DocumentIdStr+"/versions/"+versionIdStr+"/certify";
    		Report.Log(ReportLevel.Info, "Query  "+ url + " usr:"+usr+" psw:"+psw);
    		
    		object body;
    		body = new {
    			Comments=Comment,
    			NewStatus=NewStatus
    		};
 
			string ResAPICall = RestAPIMethods.SendPost(url, usr, psw, body);
			
			Report.Log(ReportLevel.Info, "ResAPICall  "+ ResAPICall); 
			
			if (ResAPICall.Contains(ExpectedRes))
			{
				Report.Success ("Validation", "ResAPICall contain "+ExpectedRes);
			}
			else{
				Report.Failure("Validation", "ResAPICall do no contain "+ExpectedRes);
			}
		
    	}    	
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CertifyProgramLastVersion(int CncId, string Reference, string NewStatus, string Comment, int ExpectedVersionId, string usr, string psw)
        {
        	Report.Log(ReportLevel.Info,"Start méthode CertifyProgramLastVersion");
        	int _docId = GetDocId(CncId, Reference, usr, psw);
        	int  _firstVersionId = GetfirstVer(CncId, _docId, usr, psw);
        	int _NewVersionId = Certify(CncId, NewStatus, _docId, _firstVersionId, Comment, usr, psw );
        	//check version Id
        	if(_NewVersionId.Equals(ExpectedVersionId))
        	{
        		
        	}
        	else
        	{
        		Report.Failure("Validation", "Wrong version id, expected : "+ExpectedVersionId.ToString()+ " recieved : "+_NewVersionId.ToString());
        	}
        }
    }
}
