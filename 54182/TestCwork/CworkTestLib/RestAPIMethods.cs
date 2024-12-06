/*
 * Created by Ranorex
 * User: Dev
 * Date: 08/09/2022
 * Time: 10:44
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

using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// voir https://celestialsys.com/blog/testing-apis-with-ranorex/ pour explication

namespace CworkTestLib
{
	/// <summary>
	/// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	[UserCodeCollection]
	public class RestAPIMethods
	{
		// You can use the "Insert New User Code Method" functionality from the context menu,
		// to add a new method with the attribute [UserCodeMethod].

		/// <summary>
		/// Generic Get Method to fetch the API Response
		/// </summary>
		/// <param name="url"></param>
		/// <param name="body"></param>
		/// <param name="usr"></param>
		/// <param name="psw"></param>
		public static IRestResponse Post(string url,string usr,string psw, object body){
			//The endpoint to which the request will be made
			RestClient client = new RestClient(url);
			// Set the Request Type: GET/POST/DELETE/PUT
			var request = new RestRequest(Method.POST);
			//Add Parameters if required
			// request.AddParameter("email",email);
			//Add Headers
			request.AddHeader("Accept","application/json+v1");
            string authHeader = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(usr + ":" + psw));
            request.AddHeader("Authorization", "Basic " + authHeader);
			request.AddJsonBody(body);
			                   
			//Execute The Request
			IRestResponse response = client.Execute(request);
			return response;
		}
		
		public static IRestResponse Get(string url,string usr,string psw, object body){
			//The endpoint to which the request will be made
			RestClient client = new RestClient(url);
			// Set the Request Type: GET/POST/DELETE/PUT
			var request = new RestRequest(Method.GET);
			//Add Parameters if required
			// request.AddParameter("email",email);
			//Add Headers
			request.AddHeader("Accept","application/json+v1");
            string authHeader = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(usr + ":" + psw));
            request.AddHeader("Authorization", "Basic " + authHeader);
            if (body!= null)
            {
            request.AddJsonBody(body);
            }
			//Execute The Request
			IRestResponse response = client.Execute(request);
			return response;
		}
		
		/// <summary>
		/// Generic Post Method to fetch the API Response
		/// </summary>
		/// <param name="url"></param>
		/// <param name="body"></param>
		/// <param name="usr"></param>
		/// <param name="psw"></param>
		[UserCodeMethod]
		public static string SendPost(string url, string usr,string psw, object body)
		{
			IRestResponse ApiRespons = Post(url, usr, psw, body);
			if (ApiRespons != null) {
				return ApiRespons.Content;
			} else {
				return "";
			}
		}
		
		
		/// <summary>
		/// Generic Get Method to fetch the API Response
		/// </summary>
		/// <param name="url"></param>
		/// <param name="body"></param>
		public static IRestResponse Post(string url,object body){
			//The endpoint to which the request will be made
			RestClient client = new RestClient(url);
			// Set the Request Type: GET/POST/DELETE/PUT
			var request = new RestRequest(Method.POST);
			//Add Parameters if required
			// request.AddParameter("email",email);
			//Add Headers
			request.AddHeader("Accept","application/json+v1");
			request.AddHeader("Authorization","Basic QWRtaW5pc3RyYXRldXI6");
			request.AddJsonBody(body);
			                   
			//Execute The Request
			IRestResponse response = client.Execute(request);
			return response;
		}

		
		/// <summary>
		/// Generic Get Method to fetch the API Response
		/// </summary>
		/// <param name="url"></param>
		public static IRestResponse Get(string url){
			//The endpoint to which the request will be made
			RestClient client = new RestClient(url);
			// Set the Request Type: GET/POST/DELETE/PUT
			var request = new RestRequest(Method.GET);
			//Add Parameters if required
			// request.AddParameter("email",email);
			//Add Headers
			request.AddHeader("Accept","application/json+v1");
			request.AddHeader("Authorization","Basic QWRtaW5pc3RyYXRldXI6");
			//Execute The Request
			IRestResponse response = client.Execute(request);
			return response;
		}
		
		/// <summary>
		/// Generic method to parse the JSON response
		/// </summary>
		/// <param name="response"></param>
		/// <param name="key"></param>
		public static String ParseJson(IRestResponse response, string key){
			string responseJson = "";
			//Verifies if the response has data
			if (response != null) {
				responseJson = response.Content;
			}
			Console.WriteLine(responseJson);
			string keyValue = "";
			//Parses the Json object from the JSON response
			JObject jsonobject = JObject.Parse(responseJson);
			//Fetches the value of the key passed
			keyValue = jsonobject.GetValue(key).ToString();
			Console.WriteLine("KeyValue is: "+keyValue);
			return keyValue;
		}
		

		
		/// <summary>
		/// Generic Get Method to fetch the API Response
		/// </summary>
		/// <param name="url"></param>
		[UserCodeMethod]
		public static string SendGet(string url)
		{
			IRestResponse ApiRespons = Get(url);
			if (ApiRespons != null) {
				return ApiRespons.Content;
			} else {
				return "";
			}
		}

		[UserCodeMethod]
		public static string SendGet(string url,string usr,string psw, object body)
		{
			IRestResponse ApiRespons = Get( url, usr, psw,  body);
			if (ApiRespons != null) {
				return ApiRespons.Content;
			} else {
				return "";
			}
		}
		
		
		
		/// <summary>
		/// Generic Post Method to fetch the API Response
		/// </summary>
		/// <param name="url"></param>
		/// <param name="body"></param>
		[UserCodeMethod]
		public static string SendPost(string url,object body)
		{
			IRestResponse ApiRespons = Post(url, body);
			if (ApiRespons != null) {
				return ApiRespons.Content;
			} else {
				return "";
			}
		}

		/// <summary>
		/// get Has_more from API Response string
		/// </summary>
		[UserCodeMethod]
		public static string ExtractAsMoreTops(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			string Has_moreString = jsonobject.GetValue("Has_more").ToString();
			return Has_moreString;
		}
		
		/// <summary>
		/// Get a json String of Tops from API Response string.
		/// </summary>
		[UserCodeMethod]
		public static String ExtractTopAsJsonString(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			string TopsString = jsonobject.GetValue("Tops").ToString();
			return TopsString;
		}

		/// <summary>
		/// Get Number of Tops from Json Tops String.
		/// </summary>
		[UserCodeMethod]
		public static int GetTopsCount(string TopsString)
		{
			//count number of tops
			dynamic jObj = JsonConvert.DeserializeObject(TopsString);
			int count=0;
			foreach (var package in jObj)
			{
				count++;
			}
			return count;
		}
		
		/// <summary>
		/// Get Start date of first top from Json Tops String.
		/// </summary>
		[UserCodeMethod]
		public static String GetFirstTopStartDate(string TopsString)
		{
			dynamic jObj = JsonConvert.DeserializeObject(TopsString);
			string topstartdatefield = jObj.First.topstartdatefield.ToString("o");
			return topstartdatefield;
		}

		/// <summary>
		/// Get Start date of Last top from Json Tops String.
		/// </summary>
		[UserCodeMethod]
		public static String GetLastTopStartDate(string TopsString)
		{
			dynamic jObj = JsonConvert.DeserializeObject(TopsString);
			string topstartdatefield = jObj.Last.topstartdatefield.ToString("o");
			return topstartdatefield;
		}
		
		/// <summary>
		/// Get comment of first top from Json Tops String.
		/// </summary>
		[UserCodeMethod]
		public static String GetFirstTopComment(string TopsString)
		{
			dynamic jObj = JsonConvert.DeserializeObject(TopsString);
			string topcommentfield = jObj.First.topcommentfield.ToString();
			return topcommentfield;
		}

		/// <summary>
		/// Get comment of Last top from Json Tops String.
		/// </summary>
		[UserCodeMethod]
		public static String GetLastTopComment(string TopsString)
		{
			dynamic jObj = JsonConvert.DeserializeObject(TopsString);
			string topcommentfield = jObj.Last.topcommentfield.ToString();
			return topcommentfield;
		}
		/// <summary>
		/// Verify content of top
		/// </summary>
		public static Boolean VerifyTopsReiceived(string ResAPICall,
		                                          string FirstTop_topstartdatefieldOkay,
		                                          string LastTop_topstartdatefieldOkay,
		                                          string FirstTop_CommentOkay,
		                                          string LastTop_CommentOkay,
		                                          string Has_more_Top,
		                                          int NumberOfTops)
		{
			Report.Log(ReportLevel.Info, "result  "+ ResAPICall);
		
			string Has_more = RestAPIMethods.ExtractAsMoreTops(ResAPICall);
			Report.Log(ReportLevel.Info, "Has_more  "+ Has_more);
			if (!Has_more.Equals(Has_more_Top))
			{
				Report.Failure("Validation","wrong Has_more : expected " + Has_more_Top +
				               " received " + Has_more);
				return false;
			}
						
			string Tops = RestAPIMethods.ExtractTopAsJsonString(ResAPICall);
			Report.Log(ReportLevel.Info, "Tops  "+ Tops);
			
			int TopCount = RestAPIMethods.GetTopsCount(Tops);
			Report.Log(ReportLevel.Info, "TopCount  "+ TopCount);
			if (TopCount != NumberOfTops)
			{
				Report.Failure("Validation","wrong number of tops : expected " + NumberOfTops.ToString() +
				               " received " + TopCount.ToString());
				return false;
			}
			
			if (NumberOfTops!=0) {
				
				string FirstTop_Comment = RestAPIMethods.GetFirstTopComment(Tops);
				Report.Log(ReportLevel.Info, "First Top comment   "+ FirstTop_Comment);
				if (!FirstTop_Comment.Equals(FirstTop_CommentOkay))
				{
					Report.Failure("Validation","wrong comment of fisrt tops : expected " + FirstTop_CommentOkay +
					               " received " + FirstTop_Comment);
					return false;
				}

				string LastTop_Comment = RestAPIMethods.GetLastTopComment(Tops);
				Report.Log(ReportLevel.Info, "Last Top comment   "+ LastTop_Comment);
				if (!LastTop_Comment.Equals(LastTop_CommentOkay))
				{
					Report.Failure("Validation","wrong comment of last tops : expected " + LastTop_CommentOkay +
					               " received " + LastTop_Comment);
					return false;
				}
				
				string FirstTopStartDateField = RestAPIMethods.GetFirstTopStartDate(Tops);
				Report.Log(ReportLevel.Info, "First Top at   "+ FirstTopStartDateField);
				if (!FirstTopStartDateField.Equals(FirstTop_topstartdatefieldOkay))
				{
					Report.Failure("Validation","wrong topstartdatefield of fisrt tops : expected " + FirstTop_topstartdatefieldOkay +
					               " received " + FirstTopStartDateField);
					return false;
				}
				
				string LastTopStartDateField = RestAPIMethods.GetLastTopStartDate(Tops);
				Report.Log(ReportLevel.Info, "Last Top at   "+ LastTopStartDateField);
				if (!LastTopStartDateField.Equals(LastTop_topstartdatefieldOkay))
				{
					Report.Failure("Validation","wrong topstartdatefield of fisrt tops : expected " + LastTop_topstartdatefieldOkay +
					               " received " + LastTopStartDateField);
					return false;
				}
				
			}
			return true;
			
		}

		/// <summary>
		/// Get a json String of State from API Response string.
		/// </summary>
		[UserCodeMethod]
		public static String ExtractStateAsJsonString(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			string StateString = jsonobject.GetValue("State").ToString();
			return StateString;
		}

		/// <summary>
		/// Get a json String of Comment from API Response string.
		/// </summary>
		[UserCodeMethod]
		public static String ExtractCommentAsJsonString(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			string CommentString = jsonobject.GetValue("Comment").ToString();
			return CommentString;
		}
		/// <summary>
		/// Get a json String of LastTop time from API Response string.
		/// </summary>
		[UserCodeMethod]
		public static String ExtractTimeAsJsonString(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			// attention LastTop est converti en date 
			// ex: "24/02/2024 00:04:00"
			string LastTopString = jsonobject.GetValue("LastTop").ToString();
			return LastTopString.Substring(LastTopString.IndexOf(":")).Remove(0, 1);
		}		
		
		/// <summary>
		/// get StateHandle from API Response string
		/// </summary>
		[UserCodeMethod]
		public static string ExtractStateHandle(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			string StateHandle = jsonobject.GetValue("Handle").ToString();
			return StateHandle;
		}

	
		/// <summary>
		/// Verify State of top
		/// </summary>
		public static Boolean VerifyStateReiceived(string ResAPICall,
		                                          int StateHandles)
		{
			string State = RestAPIMethods.ExtractStateAsJsonString(ResAPICall);
			string StateHandle = ExtractStateHandle(State);
			Report.Log(ReportLevel.Info, "StateHandle  "+ StateHandle);
			if (StateHandle != StateHandles.ToString())
			{
				Report.Failure("Validation","wrong state : expected " + StateHandle.ToString() +
				               " received " + StateHandle.ToString());
				return false;
			}			
  
			return true;
			
		}	
		/// <summary>
		/// Verify Comment of top
		/// </summary>
		public static Boolean VerifyCommentReiceived(string ResAPICall,
		                                          String Comment)
		{
			string NewComment = RestAPIMethods.ExtractCommentAsJsonString(ResAPICall);
			
			Report.Log(ReportLevel.Info, "NewComment  "+ NewComment);
			if (Comment != NewComment)
			{
				Report.Failure("Validation","wrong Comment : expected " + Comment +
				               " received " + NewComment);
				return false;
			}			
  
			return true;
			
		}
		/// <summary>
		/// Verify start date of top
		/// </summary>
		public static Boolean VerifyTopTimeReiceived(string ResAPICall,
		                                          String Time)
		{
			string NewTime = RestAPIMethods.ExtractTimeAsJsonString(ResAPICall);
			
			Report.Log(ReportLevel.Info, "NewTime  "+ NewTime);
			if (NewTime != Time)
			{
				Report.Failure("Validation","wrong Top Start : expected " + Time +
				               " received " + NewTime);
				return false;
			}			
  
			return true;
			
		}	
		/// <summary>
		/// Get a json String of Documents from API Response string.
		/// </summary>
		[UserCodeMethod]
		public static String ExtractDocumentsAsJsonString(string GetRes)
		{
			JObject jsonobject = JObject.Parse(GetRes);
			string DocumentsString = jsonobject.GetValue("Documents").ToString();
			return DocumentsString;
		}
		/// <summary>
		/// Get Number of Documents from Json Documents String.
		/// </summary>
		[UserCodeMethod]
		public static int GetDocumentsCount(string DocumentsString)
		{
			//count number of tops
			dynamic jObj = JsonConvert.DeserializeObject(DocumentsString);
			int count=0;
			foreach (var package in jObj)
			{
				count++;
			}
			return count;
		}		
		/// <summary>
		/// Get First  Document Id from Json Documents String.
		/// </summary>
		[UserCodeMethod]
		public static int GetFirstDocumentId(string DocumentsString)
		{
			dynamic jObj = JsonConvert.DeserializeObject(DocumentsString);
			int FirstDocumentId = jObj.First.DocumentId;
			return FirstDocumentId;
		}
		/// <summary>
		/// Get Last  Document Id from Json Documents String.
		/// </summary>
		[UserCodeMethod]
		public static int GetLastDocumentId(string DocumentsString)
		{
			dynamic jObj = JsonConvert.DeserializeObject(DocumentsString);
			int LastDocumentId = jObj.Last.DocumentId;
			return LastDocumentId;
		}		
		/// <summary>
		/// Verify content of Documents
		/// </summary>
		public static Boolean VerifyDocumentsReiceived(string ResAPICall,
		                                          string HasMore,
		                                          int NumberOfDocuments,
		                                         int FirstDocId,
		                                        int LastDocId)
		{
			
			//Verify AsMore
			string Has_more = RestAPIMethods.ExtractAsMoreTops(ResAPICall);
			Report.Log(ReportLevel.Info, "Has_more  "+ Has_more);
			if (!Has_more.Equals(HasMore))
			{
				Report.Failure("Validation","wrong Has_more : expected " + HasMore +
				               " received " + Has_more);
				return false;
			}	
			//Verify nb documents
			String Documents = ExtractDocumentsAsJsonString(ResAPICall);
			int NbDocuments = GetDocumentsCount(Documents);
			Report.Log(ReportLevel.Info, "NbDocuments  "+ NbDocuments.ToString());
			if (NbDocuments!=NumberOfDocuments)
			{
				Report.Failure("Validation","wrong NbDocuments : expected " + NumberOfDocuments.ToString() +
				               " received " + NbDocuments.ToString());
				return false;
			}	
			//Verify first and last Documents	
			int FirstDocumentId	= GetFirstDocumentId(Documents);
			Report.Log(ReportLevel.Info, "FirstDocumentId  "+ FirstDocumentId.ToString());
			if (FirstDocumentId != FirstDocId) {
				Report.Failure("Validation","wrong first document Id : expected " + FirstDocId.ToString() +
				               " received " + FirstDocumentId.ToString());
				return false;				
			}
			
			int LastDocumentId = GetLastDocumentId(Documents);
			Report.Log(ReportLevel.Info, "LastDocumentId  "+ LastDocumentId.ToString());
			if (LastDocumentId != LastDocId) {
				Report.Failure("Validation","wrong last document Id : expected " + LastDocId.ToString() +
				               " received " + LastDocumentId.ToString());
				return false;				
			}			
			return true;
		}
		
	}
	
}

