/*
 * Created by Ranorex
 * User: Dev
 * Date: 02/06/2022
 * Time: 12:08
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


using System.Data;
using System.Data.OleDb;

namespace CworkTestLib
{
	/// <summary>
	/// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	[UserCodeCollection]
	public class AccesDatabaseMethods
	{
		// You can use the "Insert New User Code Method" functionality from the context menu,
		// to add a new method with the attribute [UserCodeMethod].
		private
			static OleDbConnection conn;


		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void CheckLogTableContents(string logSender, string logAction, string logDocName )
		{

			
			try {
				object  resSql;
				
				Report.Log(ReportLevel.Info, "cworklogtable Check for " + logSender + " "+logAction+" "+logDocName );
				
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				maCommande.CommandText = "SELECT logaction FROM cworklogtable Where logdocnamefield =?";

				// logdocnamefield parameter
				OleDbParameter paramLogDocNameField= new OleDbParameter();
				paramLogDocNameField.ParameterName = "@logdocnamefield";
				paramLogDocNameField.DbType = DbType.AnsiString;
				paramLogDocNameField.Direction = ParameterDirection.Input;
				paramLogDocNameField.Value = logDocName;
				maCommande.Parameters.Add(paramLogDocNameField);			
				
				resSql =  maCommande.ExecuteScalar();
			
				if( !logAction.Equals((string) resSql)){
					
					Report.Failure("logAction validation error: Expected: " + logAction +" but received: "+(string) resSql );
					return;
				}

				OleDbCommand  maCommande2 = conn.CreateCommand();
				maCommande2.CommandType = CommandType.Text;
				maCommande2.CommandText = "SELECT logsender FROM cworklogtable Where logdocnamefield =?";

					
				// logdocnamefield parameter
				OleDbParameter paramLogDocNameField2= new OleDbParameter();
				paramLogDocNameField2.ParameterName = "@logdocnamefield";
				paramLogDocNameField2.DbType = DbType.AnsiString;
				paramLogDocNameField2.Direction = ParameterDirection.Input;
				paramLogDocNameField2.Value = logDocName;
				maCommande2.Parameters.Add(paramLogDocNameField2);			
						
				
				resSql =  maCommande2.ExecuteScalar();

				if( !logSender.Equals((string) resSql)){
					
					Report.Failure("logSender validation error: Expected: " + logSender +" but received: "+(string) resSql );
					return;
				}
								
				

			} catch (Exception e) {
				throw new Ranorex.ValidationException("exception CheckLogTableContents ", e);
			}
			
		}			

		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void ClearCworkLogTableContents()
		{
			try {
				// delete entry in table
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				maCommande.CommandText = "DELETE FROM cworklogtable";

				maCommande.ExecuteNonQuery();				

			} catch (Exception e) {
				throw new Ranorex.ValidationException("exception ClearCworkLogTableContents ", e);
			}
			
		}		
		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void ClearProdEventTableContents(Int32 cnc)
		{
			try {
				// delete entry in table
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				maCommande.CommandText = "DELETE FROM prodeventtable WHERE prodeventhandlecnc = @cnc";
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);
				
				maCommande.ExecuteNonQuery();

			} catch (Exception e) {
				throw new Ranorex.ValidationException("Tops could not be StatesTables ", e);
			}
			
		}
		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void ClearTopTableContents(Int32 cnc)
		{
			try {
				// delete entry in table
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				//maCommande.CommandText = "DELETE FROM cworktopstable WHERE topcnchandlefield = @cnc ";
				maCommande.CommandText = "DELETE FROM cworktopstable WHERE topcnchandlefield = ? ";
			
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);
				
				maCommande.ExecuteNonQuery();

			} catch (Exception e) {

				throw new Ranorex.ValidationException("Tops could not be cworktopstable ", e);
			}
			
		}
		/// <summary>
		/// Open access database conxexion
		/// </summary>
		[UserCodeMethod]
		public static void OpenDatabaseConnexionSql()
		{
			conn = new OleDbConnection(@"Provider=sqloledb;Data Source=localhost\SQLEXPRESS;Initial Catalog=RanorexTestCworkDb;User ID=RanorexTestCwork;Password=RanorexTestCwork;");
			try {
				conn.Open();
			} catch (Exception e) {
				throw new Ranorex.ValidationException("Database could not be opened ", e);
			}
			
		}		
		/// <summary>
		/// Open access database conxexion
		/// </summary>
		[UserCodeMethod]
		public static void OpenDatabaseConnexion()
		{
			conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CworkTestAuto\Database\dnc.mdb");
			try {
				conn.Open();
			} catch (Exception e) {
				throw new Ranorex.ValidationException("Database could not be opened ", e);
			}
			
		}
		/// <summary>
		/// Close Access Db connexion
		/// </summary>
		[UserCodeMethod]
		public static void CloseDatabaseConnexion()
		{
			conn.Close();
		}
		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void InsertProdEventProgram(Int32 cnc, String  prodeventprognam, System.DateTime startDate, System.DateTime EndDate )
		{
			try {
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				maCommande.CommandText = "INSERT INTO prodeventtable(prodeventnature,prodeventstart,prodeventend," +
					"prodeventhandlecnc," +
					"prodeventprogname)"+
					"VALUES(@nature,@startDate,@endDate," +
					"@cnc," +
					"@progname)";
				
				// nature parameter
				OleDbParameter paramNature = new OleDbParameter();
				paramNature.ParameterName = "@nature";
				paramNature.DbType = DbType.Int32;
				paramNature.Direction = ParameterDirection.Input;
				paramNature.Value = 1;
				maCommande.Parameters.Add(paramNature);
				
				// startDate parameter
				// On tronque les ms car acces ne les supporte pas.
				System.DateTime MaDateStartDateTronque = new System.DateTime(startDate.Year, startDate.Month,
				                                                             startDate.Day, startDate.Hour,
				                                                             startDate.Minute, startDate.Second);
				OleDbParameter paramStartDate = new OleDbParameter();
				paramStartDate.ParameterName = "@startDate";
				paramStartDate.DbType = DbType.DateTime;
				paramStartDate.Direction = ParameterDirection.Input;
				paramStartDate.Value = MaDateStartDateTronque;
				maCommande.Parameters.Add(paramStartDate);
				
				// endDate parameter
				// On tronque les ms car acces ne les supporte pas.
				System.DateTime MaDateEndDateTronque = new System.DateTime(EndDate.Year, EndDate.Month,
				                                                           EndDate.Day, EndDate.Hour,
				                                                           EndDate.Minute, EndDate.Second);
				OleDbParameter paramEndDate = new OleDbParameter();
				paramEndDate.ParameterName = "@endDate";
				paramEndDate.DbType = DbType.DateTime;
				paramEndDate.Direction = ParameterDirection.Input;
				paramEndDate.Value = MaDateEndDateTronque;
				maCommande.Parameters.Add(paramEndDate);
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);
				
				// progname parameter
				OleDbParameter paramPrograme= new OleDbParameter();
				paramPrograme.ParameterName = "@progname";
				paramPrograme.DbType = DbType.AnsiString;
				paramPrograme.Direction = ParameterDirection.Input;
				paramPrograme.Value = prodeventprognam;
				maCommande.Parameters.Add(paramPrograme);
				
				maCommande.ExecuteNonQuery();
			} catch (Exception e) {
				throw new Ranorex.ValidationException("ProdEventProgram could not be created ", e);             }
		}

		[UserCodeMethod]
		public static void InsertTopsEventProgram(Int32 cnc, Int32 State, System.DateTime startDate, System.DateTime EndDate, string comment = "Test Auto")
		{
			Int32 diffTemps = (Int32)(EndDate - startDate).TotalSeconds;

			try {
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
//				maCommande.CommandText ="INSERT INTO cworktopstable(topcnchandlefield,	topstatehandlefield, topstartdatefield, topcommentfield,topenddatefield,topdurationfield) " +
//					"VALUES (@cnc,@State,@startDate,@comment,@endDate,@duration)";
				maCommande.CommandText ="INSERT INTO cworktopstable(topcnchandlefield,	topstatehandlefield, topstartdatefield, topcommentfield,topenddatefield,topdurationfield) " +
					"VALUES (?,?,?,?,?,?)";
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);

				// Handle parameter
				OleDbParameter paramCncState = new OleDbParameter();
				paramCncState.ParameterName = "@State";
				paramCncState.DbType = DbType.Int32;
				paramCncState.Direction = ParameterDirection.Input;
				paramCncState.Value = State;
				maCommande.Parameters.Add(paramCncState);
								
				// startDate parameter
				// On tronque les ms car acces ne les supporte pas.
				System.DateTime MaDateStartDateTronque = new System.DateTime(startDate.Year, startDate.Month,
				                                                             startDate.Day, startDate.Hour,
				                                                             startDate.Minute, startDate.Second);
				OleDbParameter paramStartDate = new OleDbParameter();
				paramStartDate.ParameterName = "@startDate";
				paramStartDate.DbType = DbType.DateTime;
				paramStartDate.Direction = ParameterDirection.Input;
				paramStartDate.Value = MaDateStartDateTronque;
				maCommande.Parameters.Add(paramStartDate);
	
				//comment parameter
				OleDbParameter paramComment = new OleDbParameter();
				paramComment.ParameterName = "@comment";
				paramComment.DbType = DbType.String;
				paramComment.Direction = ParameterDirection.Input;
				paramComment.Value = comment;
				maCommande.Parameters.Add(paramComment);	
				
				// endDate parameter
				// On tronque les ms car acces ne les supporte pas.
				System.DateTime MaDateEndDateTronque = new System.DateTime(EndDate.Year, EndDate.Month,
				                                                           EndDate.Day, EndDate.Hour,
				                                                           EndDate.Minute, EndDate.Second);
				OleDbParameter paramEndDate = new OleDbParameter();
				paramEndDate.ParameterName = "@endDate";
				paramEndDate.DbType = DbType.DateTime;
				paramEndDate.Direction = ParameterDirection.Input;
				paramEndDate.Value = MaDateEndDateTronque;
				maCommande.Parameters.Add(paramEndDate);

				// duration parameter
				OleDbParameter paramDateDuration = new OleDbParameter();
				paramDateDuration.ParameterName = "@duration";
				paramDateDuration.DbType = DbType.Int32;
				paramDateDuration.Direction = ParameterDirection.Input;
				paramDateDuration.Value = diffTemps;
				maCommande.Parameters.Add(paramDateDuration);
				
				
				maCommande.ExecuteNonQuery();
			} catch (Exception e) {
				throw new Ranorex.ValidationException("ProdEventProgram could not be created ", e);             }
		}

		/// <summary>
		/// This is a placeholder text. Please describe the purpose of the
		/// user code method here. The method is published to the user code library
		/// within a user code collection.
		/// </summary>
		[UserCodeMethod]
		public static void InsertSeveralProdEventProgram(Int32 cnc, Int32 nbEvents)
		{
			System.DateTime MaDateStartDateTronque;
			System.DateTime MaDateEndDateTronque;
			int i;
			MaDateStartDateTronque = new System.DateTime(1, 1, 1, 0, 0, 0);
			MaDateEndDateTronque = new System.DateTime(1, 1, 1, 0, 0, 1);
			
			for (i = 0; i < nbEvents; i++)
			{	
				MaDateStartDateTronque = MaDateStartDateTronque.AddSeconds(1);
				MaDateEndDateTronque = MaDateEndDateTronque.AddSeconds(1);
				InsertProdEventProgram(cnc, "prog"+i.ToString(),MaDateStartDateTronque,MaDateEndDateTronque);
			}
			InsertProdEventProgram(cnc, "prog"+i.ToString(),MaDateStartDateTronque.AddSeconds(1),MaDateStartDateTronque.AddSeconds(1));
		}
		
		[UserCodeMethod]
		public static void insertLotOfstatesInTops(Int32 cnc){
			Int32 states = 0;
			 
			int year = System.DateTime.Now.Year;
				System.DateTime StartDate = new System.DateTime(year, 1, 1);
				System.DateTime EndDate = new System.DateTime(year, 1, 31);
			
			 System.DateTime curentEndPeriodeCursor = StartDate;
			 
			 System.DateTime curentEnd =StartDate.AddSeconds(1260);
			
			for(var day = StartDate.Date; day.Date <= EndDate.Date; day = day.AddMinutes(21)){
				
			 		curentEnd = day.AddMinutes(21);
			 		InsertTopsEventProgram(cnc, states ,day,curentEnd );
			 		if (states < 4){
			 			states++;
			 		}else{
			 			states = 0;
			 		}
				
			};
		}

		[UserCodeMethod]
		public static void insertLotOfstatesInTops2(Int32 cnc){
			Int32 states = 0;
			int I = 0; 
			int year = System.DateTime.Now.Year;
			System.DateTime StartDate = new System.DateTime(year-1, 1, 1);
			System.DateTime EndDate = new System.DateTime(year-1, 12, 31);
			
			System.DateTime curentEndPeriodeCursor = StartDate;
			 
			System.DateTime curentEnd =StartDate.AddSeconds(60);
			
			Report.Log(ReportLevel.Info, "Start insert top loop from   "+ StartDate.ToString() +" to " +EndDate.ToString());
			for(var day = StartDate.Date; day.Date <= EndDate.Date; day = day.AddSeconds(60)){
				
			 		curentEnd = day.AddSeconds(60);
			 		InsertTopsEventProgram(cnc, states ,day,curentEnd, "TOP "+I.ToString() );
			 		if (states < 4){
			 			states++;
			 		}else{
			 			states = 0;
			 		}
			 		I++;
				
			};
			// état courant
			Report.Log(ReportLevel.Info, I.ToString() + " Tops inserted, now insert last top ");
			InsertTopsEventProgram(cnc, states ,curentEnd,curentEnd, "TOP "+I.ToString() );
			//update cworkstatestable with curent state
			UpdateCworkStatesTable(cnc, states, curentEnd);
			Report.Log(ReportLevel.Info, "End insert top loop from   ");
		}


		[UserCodeMethod]
		public static void insertFiveStatesInTopsToday(Int32 cnc){
			Int32 states = 0;
			int I;

			System.DateTime StartDate = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day);
			
			System.DateTime curentEnd =StartDate.AddSeconds(60);
			
			Report.Log(ReportLevel.Info, "Start insert 5 top loop from   "+ StartDate.ToString() );
			
			
			for (I = 0; I < 4; I++) {
				curentEnd = StartDate.AddSeconds(60);
				InsertTopsEventProgram(cnc, states ,StartDate,curentEnd, "TOP "+I.ToString() );
				if (states < 4){
					states++;
				}else{
					states = 0;
				}
				StartDate = StartDate.AddSeconds(60);
			}

			// état courant
			Report.Log(ReportLevel.Info, I.ToString() + " Tops inserted, now insert last top ");
			InsertTopsEventProgram(cnc, states ,curentEnd,curentEnd, "TOP "+I.ToString() );
			//update cworkstatestable with curent state
			UpdateCworkStatesTable(cnc, states, curentEnd);
			Report.Log(ReportLevel.Info, "End insert top loop ");
		}
		
		[UserCodeMethod]
		public static string GetStateLabel(Int32 State){
			try {
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				maCommande.CommandText = "SELECT stadefname FROM stadeftable Where stadefhandle = ?";
				
				//stadefhandle
				OleDbParameter paramStateHandle = new OleDbParameter();
				paramStateHandle.ParameterName = "@stateHandle";
				paramStateHandle.DbType = DbType.Int32;
				paramStateHandle.Direction = ParameterDirection.Input;
				paramStateHandle.Value = State;
				maCommande.Parameters.Add(paramStateHandle);

				return (string) maCommande.ExecuteScalar();
				
				} catch (Exception e) {
	
					throw new Ranorex.ValidationException("GetStateLabel err ", e);
				}
		}
		
		[UserCodeMethod]
		public static void UpdateCworkStatesTable(Int32 cnc, Int32 State,System.DateTime TopDate){	
			string StateLabel =  GetStateLabel(State);
			
			try {
				// delete entry in table
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;

				maCommande.CommandText = "UPDATE cworkstatestable SET stastatehandlefield = ?, statoptimefield = ?, stastatefield = ?, stadatefield = ? WHERE stastationhandlefield = ? ";
	
				//stastatehandlefield
				OleDbParameter paramStateHandle = new OleDbParameter();
				paramStateHandle.ParameterName = "@stateHandle";
				paramStateHandle.DbType = DbType.Int32;
				paramStateHandle.Direction = ParameterDirection.Input;
				paramStateHandle.Value = State;
				maCommande.Parameters.Add(paramStateHandle);
				
				// TopDate parameter
				// On tronque les ms car acces ne les supporte pas.
				System.DateTime MaDateTopDateTronque = new System.DateTime(TopDate.Year, TopDate.Month,
				                                                           TopDate.Day, TopDate.Hour,
				                                                           TopDate.Minute, TopDate.Second);
				OleDbParameter paramTopDate = new OleDbParameter();
				paramTopDate.ParameterName = "@topDate";
				paramTopDate.DbType = DbType.DateTime;
				paramTopDate.Direction = ParameterDirection.Input;
				paramTopDate.Value = MaDateTopDateTronque;
				maCommande.Parameters.Add(paramTopDate);
				
				// stastatefield parameter
				OleDbParameter paramStateLabel = new OleDbParameter();
				paramStateLabel.ParameterName = "@State";
				paramStateLabel.DbType = DbType.String;
				paramStateLabel.Direction = ParameterDirection.Input;
				paramStateLabel.Value = StateLabel;
				maCommande.Parameters.Add(paramStateLabel);	
				
				// stadatefield  
				OleDbParameter paramTopDateString = new OleDbParameter();
				paramTopDateString.ParameterName = "@staDate";
				paramTopDateString.DbType = DbType.String;
				paramTopDateString.Direction = ParameterDirection.Input;
				paramTopDateString.Value = MaDateTopDateTronque.ToString("dd/MM/yyy HH:mm");
				maCommande.Parameters.Add(paramTopDateString);				
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);

				maCommande.ExecuteNonQuery();

				} catch (Exception e) {
	
					throw new Ranorex.ValidationException("cworkstatetable update err ", e);
				}
			
			
		}
		
		[UserCodeMethod]
		public static void insertLotOfstatesInTops3(Int32 cnc){
			Int32 states = 0;
			int I = 0; 
			int year = System.DateTime.Now.Year;
			System.DateTime StartDate = new System.DateTime(year-1, 1, 1);
			System.DateTime EndDate = new System.DateTime(year-1, 12, 31);
			
			System.DateTime curentEndPeriodeCursor = StartDate;
			 
			System.DateTime curentEnd =StartDate.AddSeconds(20);
			
			Report.Log(ReportLevel.Info, "Start insert top loop from   "+ StartDate.ToString() +" to " +EndDate.ToString());
			for(var day = StartDate.Date; day.Date <= EndDate.Date; day = day.AddSeconds(20)){
				
			 		curentEnd = day.AddSeconds(20);
			 		InsertTopsEventProgram(cnc, states ,day,curentEnd, "TOP "+I.ToString() );
			 		if (states < 4){
			 			states++;
			 		}else{
			 			states = 0;
			 		}
			 		I++;
				
			};
			// état courant
			Report.Log(ReportLevel.Info, I.ToString() + " Tops inserted, now insert last top ");
			InsertTopsEventProgram(cnc, states ,curentEnd,curentEnd, "TOP "+I.ToString() );
			Report.Log(ReportLevel.Info, "End insert top loop from   ");
		}

		[UserCodeMethod]
		public static void insertLotOfstatesInTops4(Int32 cnc){
			Int32 states = 0;
			int I = 0; 
			int year = System.DateTime.Now.Year;
			System.DateTime StartDate = new System.DateTime(year-1, 1, 1);
			System.DateTime EndDate = new System.DateTime(year-1, 1, 31);
			
			System.DateTime curentEndPeriodeCursor = StartDate;
			 
			System.DateTime curentEnd =StartDate.AddSeconds(60);
			
			Report.Log(ReportLevel.Info, "Start insert top loop from   "+ StartDate.ToString() +" to " +EndDate.ToString());
			for(var day = StartDate.Date; day.Date <= EndDate.Date; day = day.AddSeconds(60)){
				
			 		curentEnd = day.AddSeconds(60);
			 		InsertTopsEventProgram(cnc, states ,day,curentEnd, "TOP "+I.ToString() );
			 		if (states < 4){
			 			states++;
			 		}else{
			 			states = 0;
			 		}
			 		I++;
				
			};
			// état courant
			Report.Log(ReportLevel.Info, I.ToString() + " Tops inserted, now insert last top ");
			InsertTopsEventProgram(cnc, states ,curentEnd,curentEnd, "TOP "+I.ToString() );
			Report.Log(ReportLevel.Info, "End insert top loop from   ");
		}		
		
		[UserCodeMethod]
		public static void insertOnestatesInTops(Int32 cnc){
			
			int year = System.DateTime.Now.Year;
				System.DateTime StartDate = new System.DateTime(year, 1, 1);
				System.DateTime EndDate = new System.DateTime(year, 1, 31);
			
			InsertTopsEventProgram(cnc, 1 ,StartDate,EndDate );
			
		}
		[UserCodeMethod]
		// Modify first record to overlap 1 second the folowing
		public static void CreateOverlapOnFirstTopFirstDayLastYear(Int32 cnc){
			
			int year = System.DateTime.Now.Year;
				System.DateTime EndDate = new System.DateTime(year-1, 1, 1);
				//overlap
				EndDate=EndDate.AddSeconds(61); // le deuxieme top commence a 0h0m1s
			try {
				// delete entry in table
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
				//maCommande.CommandText = "DELETE FROM cworktopstable WHERE topcnchandlefield = @cnc ";
				//maCommande.CommandText = "DELETE FROM cworktopstable WHERE topcnchandlefield = ? ";
				
				maCommande.CommandText = "UPDATE cworktopstable SET topenddatefield = ? WHERE topcnchandlefield = ? AND topcommentfield = 'TOP 0'";
			

				// endDate parameter
				// On tronque les ms car acces ne les supporte pas.
				System.DateTime MaDateEndDateTronque = new System.DateTime(EndDate.Year, EndDate.Month,
				                                                           EndDate.Day, EndDate.Hour,
				                                                           EndDate.Minute, EndDate.Second);
				OleDbParameter paramEndDate = new OleDbParameter();
				paramEndDate.ParameterName = "@endDate";
				paramEndDate.DbType = DbType.DateTime;
				paramEndDate.Direction = ParameterDirection.Input;
				paramEndDate.Value = MaDateEndDateTronque;
				maCommande.Parameters.Add(paramEndDate);
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);
				


				maCommande.ExecuteNonQuery();

			} catch (Exception e) {

				throw new Ranorex.ValidationException("Tops update err ", e);
			}
			
			
		}		
		
	}
}
