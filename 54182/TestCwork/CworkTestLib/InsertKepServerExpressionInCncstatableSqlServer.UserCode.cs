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

using System.Data;
using System.Data.OleDb;

namespace CworkTestLib
{
    public partial class InsertKepServerExpressionInCncstatableSqlServer
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

		private void ClearCncStaTableTableContents(Int32 cnc)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=sqloledb;Data Source=localhost\SQLEXPRESS;Initial Catalog=RanorexTestCworkDb;User ID=RanorexTestCwork;Password=RanorexTestCwork;");
			try {
				conn.Open();
				// delete entry in table
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
//				maCommande.CommandText = "DELETE FROM cncstatable WHERE cncstahandlecnc = @cnc";
				maCommande.CommandText = "DELETE FROM cncstatable WHERE cncstahandlecnc = ?";
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);
				
				maCommande.ExecuteNonQuery();

			} catch (Exception e) {
				throw new Ranorex.ValidationException("cncstatable could not be Deleted ", e);             }
			finally {
				conn.Close();
			}
		}
		/// <summary>
		/// This method insert an Expression in cncstatable.
		/// </summary>
		private void InsertIntoCncsStaTable(Int32 cnc, Int32 state, string expression)
		{
			// TODO: Replace the following line with your code implementation.
			//throw new NotImplementedException();
			OleDbConnection conn = new OleDbConnection(@"Provider=sqloledb;Data Source=localhost\SQLEXPRESS;Initial Catalog=RanorexTestCworkDb;User ID=RanorexTestCwork;Password=RanorexTestCwork;");
			try {
				conn.Open();
				OleDbCommand  maCommande = conn.CreateCommand();
				maCommande.CommandType = CommandType.Text;
//				maCommande.CommandText = "INSERT INTO cncstatable(cncstahandlecnc,cncstahandlestate,cncstaexpression)" +
//					"VALUES(@cncstahandlecnc,@cncstahandlestate,@cncstaexpression)";
				maCommande.CommandText = "INSERT INTO cncstatable(cncstahandlecnc,cncstahandlestate,cncstaexpression)" +
					"VALUES(?,?,?)";
				
				// CNC parameter
				OleDbParameter paramCnc = new OleDbParameter();
				paramCnc.ParameterName = "@cncstahandlecnc";
				paramCnc.DbType = DbType.Int32;
				paramCnc.Direction = ParameterDirection.Input;
				paramCnc.Value = cnc;
				maCommande.Parameters.Add(paramCnc);

				// state parameter
				OleDbParameter paramState = new OleDbParameter();
				paramState.ParameterName = "@cncstahandlestate";
				paramState.DbType = DbType.Int32;
				paramState.Direction = ParameterDirection.Input;
				paramState.Value = state;
				maCommande.Parameters.Add(paramState);

				//comment cncstaexpression
				OleDbParameter paramComment = new OleDbParameter();
				paramComment.ParameterName = "@cncstaexpression";
				paramComment.DbType = DbType.String;
				paramComment.Direction = ParameterDirection.Input;
				paramComment.Value = expression;
				maCommande.Parameters.Add(paramComment);
				
				

				maCommande.ExecuteNonQuery();
				
			} catch (Exception e) {
				throw new Ranorex.ValidationException("Expression could not be created ", e);             }
			finally {
				conn.Close();
			}
		}
		
		public void InsertKepServerExpressionSqlServer(int CncId)
		{
			ClearCncStaTableTableContents(CncId);
			InsertIntoCncsStaTable(CncId,0,"{@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} < -400");
			InsertIntoCncsStaTable(CncId,1,"({@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} > -400) AND ({@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} < 0)");
			InsertIntoCncsStaTable(CncId,2,"({@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} > 0) AND ({@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} < 400)");
			InsertIntoCncsStaTable(CncId,3,"({@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} > 400) AND ({@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} < 600)");
			InsertIntoCncsStaTable(CncId,4,"{@OPCDA|INT|localhost&Kepware.KEPServerEX.V6&Simulation Examples.Functions.Random4@} > 600");
		}
    }
}
