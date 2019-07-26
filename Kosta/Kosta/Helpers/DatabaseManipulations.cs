using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosta.Helpers
{
	public class DatabaseManipulations
	{
		public static SQLConnect _connect;


		public DataTable SqlCommand(string commandtext)
		{
			DataTable dataTable = new DataTable();
			try
			{
				using (SqlConnection connection = _connect.ConnectionOpen())
				{
					if (connection.State != ConnectionState.Open)
					{
						connection.Open();
					}
					SqlDataAdapter adapter = new SqlDataAdapter();
					SqlCommand command = new SqlCommand(commandtext,
						connection);
					adapter.SelectCommand = command;
					adapter.Fill(dataTable);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dataTable;
		}

		public DataTable departmentsSelectAll()
		{
			DataTable dataTable = SqlCommand("SELECT * FROM[TestDB].[dbo].[Department]");
			return dataTable;
		}
		public DataTable employeesSelectAll()
		{
			DataTable dataTable = SqlCommand("SELECT e.*,DATEDIFF(yy,e.DateOfBirth,GETDATE())  as 'Возраст' FROM[TestDB].[dbo].[Empoyee] e");
			return dataTable;
		}
		public DataTable employeesSelect(string dep)
		{
			DataTable dataTable = SqlCommand("SELECT e.*,DATEDIFF(yy,e.DateOfBirth,GETDATE())  as 'Возраст' FROM[TestDB].[dbo].[Empoyee] e WHERE e.DepartmentID='"+dep+"'");
			return dataTable;
		}
		public DataTable StructureOfCompany()
		{
			DataTable dataTable = SqlCommand(" WITH DepsRank AS "+
											"( "+
											"SELECT *, "+
											"ROW_NUMBER() OVER(PARTITION BY ParentDepartmentID ORDER BY ID) AS n "+
											"FROM[TestDB].[dbo].[Department] "+
											"), "+
											"DepsPath "+
											"AS "+
											"( "+
											"SELECT ID, Name, Code, 0 AS lvl, "+
											"CAST(0x AS VARBINARY(MAX)) AS sortpath "+
											"FROM[TestDB].[dbo].[Department] "+
											" WHERE ParentDepartmentID IS NULL "+

											" UNION ALL "+

											"SELECT C.ID, C.NAME, C.Code, P.lvl + 1, P.sortpath + CAST(n AS BINARY(2)) "+
											"FROM DepsPath AS P "+

											"JOIN DepsRank AS C "+

											"ON C.ParentDepartmentID = P.ID "+
											") "+
											"SELECT REPLICATE(' _ ', lvl) + Name AS depsname,ID "+
											"FROM DepsPath "+
											"ORDER BY sortpath; ");
			return dataTable;
		}
		public string SelectDepName(string depID)
		{
			DataTable dataTable = SqlCommand(" SELECT Name From [TestDB].[dbo].[Department] WHERE ID='" + depID + "'");
			return dataTable.Rows[0].ItemArray[0].ToString();
		}
		public void UpdateEmployee(Employee emp)
		{
			SqlCommand(	 "BEGIN TRANSACTION;"+
						 "UPDATE [TestDB].[dbo].[Empoyee] "+
						 "SET "+
						 "FirstName='"+emp.FirstName+"'"+
						 ",SurName='"+emp.Surname +"'"+
						 ",Patronymic='"+emp.Patronymic+"'"+
						 ",DateOfBirth='"+emp.DateOfBirth.ToString()+"'"+
						 ",DocSeries='"+emp.DocSeries+"'"+
						 ",DocNumber='"+emp.DocNumber+"'"+
						 ",Position='"+emp.Position+"'"+
						 ",DepartmentID='"+emp.DepartmentID+"' "+
						 "WHERE ID="+emp.ID+";"+
						 "COMMIT TRANSACTION;");
		}
		public void InsertEmployee(Employee emp)
		{
			SqlCommand("BEGIN TRANSACTION;" +
						 "INSERT INTO [TestDB].[dbo].[Empoyee] " +
						 "( FirstName,SurName,Patronymic,DateOfBirth,DocSeries,DocNumber,Position,DepartmentID)" +
						"VALUES('"+ emp.FirstName + "'," +
						 "'" + emp.Surname + "'" +
						 ",'" + emp.Patronymic + "'" +
						 ",'" + emp.DateOfBirth.ToString() + "'" +
						 ",'" + emp.DocSeries + "'" +
						 ",'" + emp.DocNumber + "'" +
						 ",'" + emp.Position + "'" +
						 ",'" + emp.DepartmentID + "'); " +
						 "COMMIT TRANSACTION;");
		}
		public DataTable SelectEmployee(int id)
		{
			return SqlCommand("SELECT * FROM [TestDB].[dbo].[Empoyee] WHERE ID=" + id + ";");
		}
	}
}
