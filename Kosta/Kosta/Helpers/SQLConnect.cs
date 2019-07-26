using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kosta.Helpers
{
	public class SQLConnect
	{
		public string Hostname { get; private set; }
		public string Database { get; private set; }
		public  string User { get; private set; }
		public string Password { get; private set; }
		private bool _connection = false;
		public bool Connection { get { return _connection; } private set { _connection = value; } }
		public SQLConnect(string hostname, string database, string user, string password)
		{
			Hostname = hostname;
			Database = database;
			User = user;
			Password = password;
		}
		public SqlConnection ConnectionOpen() //Метод для открытия соединения
		{
			SqlConnection conn = new SqlConnection();
			try
			{
				
				string conString = @"Data Source=" + Hostname + ";Initial Catalog=" + Database + ";integrated security=False;User ID=" + User + ";Password=" + Password;
				conn = new SqlConnection(conString);
				if (conn.State != ConnectionState.Open)
				{
					conn.Open();// Открываем соединиение
					Connection = true;
				}
			}
			catch (Exception ex)
			{
				Connection = false;
				MessageBox.Show("Error to establish the MSsql Connection: " + ex.Message);
			}
			return conn;
		}
	}
}
