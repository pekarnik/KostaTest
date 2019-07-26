using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kosta.Helpers;

namespace Kosta.View
{
	public partial class Form3 : Form
	{
		DatabaseManipulations _dbm;
		Employee emp;
		public Form3(Employee empin=null)
		{
			_dbm = new DatabaseManipulations();
			emp = empin;
			InitializeComponent();
			if (empin != null)
			{
				surnameBox.Text = empin.Surname;
				firstnameBox.Text = empin.FirstName;
				patronymicBox.Text = empin.Patronymic;
				DataTable departs = _dbm.StructureOfCompany();
				CurDep(departs, empin.DepartmentID);
				dateOfBirthBox.Text = empin.DateOfBirth.ToString().Split(' ')[0];
				positionBox.Text = empin.Position;
				seriesPasBox.Text = empin.DocSeries;
				numberOfPasport.Text = empin.DocNumber;
				ageBox.Text = empin.Age.ToString();
				addEmployeeButton.Enabled = false;
			}
			else
			{
				changeEmployeeButton.Enabled = false;
				DataTable departs = _dbm.StructureOfCompany();
				CurDep(departs);
			}
		}

		private void CurDep(DataTable departs,string depID=null)
		{
			List<string> deps = new List<string>();
			foreach (DataRow row in departs.Rows)
			{
				string dep = (row[0].ToString() + "," + row[1].ToString()).Trim('_', ' ');
				deps.Add(dep);
			}
			departmentIDBox.DataSource = deps;
			if (depID != null)
			{
				int idx = departmentIDBox.Items.IndexOf(_dbm.SelectDepName(depID) + "," + depID);
				departmentIDBox.SelectedItem = departmentIDBox.Items[idx];
			}
		}

		private void ChangeEmployeeButton_Click(object sender, EventArgs e)
		{
			string firstname = firstnameBox.Text.Trim(' ');
			string surname = surnameBox.Text.Trim(' ');
			string patronymic = patronymicBox.Text.Trim(' ');
			string date = dateOfBirthBox.Text.Trim(' ');
			DateTime dateOfBirth;
			try
			{
				dateOfBirth = DateTime.Parse(date);
			}
			catch
			{
				MessageBox.Show("Неправильно задана дата!");
				return;
			}
			string docseries = seriesPasBox.Text.Trim(' ');
			string docNumber = numberOfPasport.Text.Trim(' ');
			string position = positionBox.Text.Trim(' ');
			string departmentID = departmentIDBox.SelectedItem.ToString().Split(',')[1].Trim(' ');
			Employee newEmp = new Employee(id: emp.ID, depID: departmentID, surname: surname, firstname: firstname, dateOfBirth: dateOfBirth, position: position, age: emp.Age, patronymic: patronymic, docseries: docseries, docnumber: docNumber);
			if (firstname == "" || surname == "" || dateOfBirth.ToString() == "" || position == "" || departmentID == "")
			{
				MessageBox.Show("Не задан один или более параметров!");
				return;
			}
			_dbm.UpdateEmployee(newEmp);
			this.Close();
		}

		private void AddEmployeeButton_Click(object sender, EventArgs e)
		{
			string firstname = firstnameBox.Text.Trim(' ');
			string surname = surnameBox.Text.Trim(' ');
			string patronymic = patronymicBox.Text.Trim(' ');
			string date = dateOfBirthBox.Text.Trim(' ');
			DateTime dateOfBirth;
			try
			{
				dateOfBirth = DateTime.Parse(date);
			}
			catch
			{
				MessageBox.Show("Неправильно задана дата!");
				return;
			}
			string docseries = seriesPasBox.Text.Trim(' ');
			string docNumber = numberOfPasport.Text.Trim(' ');
			string position = positionBox.Text.Trim(' ');
			string departmentID = departmentIDBox.SelectedItem.ToString().Split(',')[1].Trim(' ');
			Employee newEmp = new Employee(id: 0, depID: departmentID, surname: surname, firstname: firstname, dateOfBirth: dateOfBirth, position: position, age: 0, patronymic: patronymic, docseries: docseries, docnumber: docNumber);
			if (firstname == "" || surname == "" || dateOfBirth.ToString() == "" || position == "" || departmentID == "")
			{
				MessageBox.Show("Не задан один или более параметров!");
				return;
			}
			_dbm.InsertEmployee(newEmp);
			this.Close();
		}
	}
}
