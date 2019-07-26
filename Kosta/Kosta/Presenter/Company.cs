using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kosta.Helpers;
namespace Kosta.Presenter
{
	public class Company
	{
		public List<Employee> _employees { get; private set; }
		public List<Department> _departments { get; private set; }
		public DataTable _departmentsTable { get; private set; }
		public DataTable _employeesTable { get; private set; }
		DatabaseManipulations _bd;
		public Company()
		{
			try
			{
				_bd = new DatabaseManipulations();
				_departmentsTable = _bd.departmentsSelectAll();
				_employeesTable = _bd.employeesSelectAll();
				LoadEmployees();
				LoadDepartments();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void Update()
		{
			_departmentsTable = _bd.departmentsSelectAll();
			_employeesTable = _bd.employeesSelectAll();
			LoadEmployees();
			LoadDepartments();
		}
		private void LoadEmployees()
		{
			_employees = new List<Employee>();
			foreach (DataRow row in _employeesTable.Rows)
			{
				int id = Convert.ToInt32(row["ID"].ToString());
				string departmentID = row["DepartmentID"].ToString();
				string surname = row["SurName"].ToString();
				string firstname = row["FirstName"].ToString();
				DateTime dateOfBirth = DateTime.Parse(row["DateOfBirth"].ToString());
				string position = row["Position"].ToString();
				string patronymic = row["Patronymic"].ToString();
				string docseries = row["DocSeries"].ToString();
				string docnumber = row["DocNumber"].ToString();
				int age = Convert.ToInt32(row["Возраст"].ToString());
				Employee emp = new Employee(id: id,
					depID: departmentID, surname: surname,
					firstname: firstname, dateOfBirth: dateOfBirth,
					position: position, patronymic: patronymic,
					docseries: docseries, docnumber: docnumber,age:age);
				_employees.Add(emp);
			}
		
		}
		private void LoadDepartments()
		{
			_departments = new List<Department>();
			foreach(DataRow row in _departmentsTable.Rows)
			{
				string id = row["ID"].ToString();
				string name = row["Name"].ToString();
				string parentDepartmentID = row["ParentDepartmentID"].ToString();
				string code = row["Code"].ToString();
				Department dep = new Department(id: id,
					name: name, parentDepartmentID: parentDepartmentID, code: code);
				_departments.Add(dep);
			}
		}
	}
}
