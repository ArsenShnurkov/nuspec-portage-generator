using System;
using System.Data;
using System.Data.Common;
using System.Data.Hsql;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsGUI
{
	public class EbuildPropertiesSettings
	{
		public EbuildPropertiesSettings ()
		{
		}

		public void LoadFromDisk()
		{
			DbProviderFactory factory = null;
			try
			{
				factory = DbProviderFactories.GetFactory ("System.Data.SharpHSQL");
			}
			catch (System.Configuration.ConfigurationErrorsException ex)
			{
				Trace.WriteLine (ex.ToString ());
				DataTable table_DbProviderFactories = DbProviderFactories.GetFactoryClasses ();
				foreach (DataRow row in table_DbProviderFactories.Rows)
				{
					Trace.WriteLine (row ["InvariantName"].ToString());
				}
			}
			using (DbConnection conn = factory.CreateConnection ())
			{
				conn.ConnectionString = "database=test;user id=sa;password=;";
				conn.Open ();
				DbCommand cmd = conn.CreateCommand ();
				cmd.CommandText = "SHOW TABLES;";
				cmd.CommandType = CommandType.Text;
				int tableCount = 0;
				using (DbDataReader reader = cmd.ExecuteReader ())
				{
					while (reader.Read ())
					{
						tableCount++;
						Trace.WriteLine (reader [0].ToString ());
					}
				}
				if (tableCount == 0)
				{
					CreateDatabaseStructure (conn, null);
				}
			}
		}

		public void SaveToDisk()
		{
		}

		public void CreateDatabaseStructure (IDbConnection conn, IDbTransaction tran)
		{
			using (IDbCommand cmd = conn.CreateCommand ()) {
				cmd.CommandText = "CREATE TABLE test (MyId  int )";
				int res = cmd.ExecuteNonQuery ();
				Trace.WriteLine (res);
			}
		}
	}
}

