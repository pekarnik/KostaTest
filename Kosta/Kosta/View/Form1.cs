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
using Kosta.Presenter;
namespace Kosta.View
{
	public partial class Form1 : Form
	{
		StateOfDataGrid state;
		Company _company;
		DatabaseManipulations _dbM;
		public Form1()
		{
			InitializeComponent();
			SetActiveButton(false);
		}
		private void SetActiveButton(bool set)
		{
			addEmployeeBtn.Enabled = set;
			allDepsBtn.Enabled = set;
			empsBtn.Enabled = set;
			structCompBtn.Enabled = set;
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Enabled = true;
			if(DatabaseManipulations._connect!=null&&DatabaseManipulations._connect.Connection)
			{
				_company = new Company();
				dataGridView1.DataSource = _company._departmentsTable;
				List<string> deps=new List<string>();
				_dbM = new DatabaseManipulations();
				DataTable departs = _dbM.StructureOfCompany();
				deps.Add("Все департаменты");
				foreach (DataRow row in departs.Rows)
				{
					string dep = (row[0].ToString() + "," + row[1].ToString()).Trim('_',' ');
					deps.Add(dep);
				}
				comboBox1.DataSource = deps;
				state = StateOfDataGrid.Departments;
				SetActiveButton(true);
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Form2 form2;
			form2 = new Form2();
			form2.FormClosed += Form2_FormClosed;
			form2.Show();
			this.Enabled = false;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.DataSource = _company._departmentsTable;
				state = StateOfDataGrid.Departments;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable emps;
				if (comboBox1.SelectedItem.ToString()=="Все департаменты")
				{
					emps=_dbM.employeesSelectAll();
				}
				else
				{
					string search=comboBox1.SelectedItem.ToString().Trim('_',' ').Split(',')[1];
					emps=_dbM.employeesSelect(search);
				}
				state = StateOfDataGrid.Employees;

				dataGridView1.DataSource = emps;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.DataSource = _dbM.StructureOfCompany();
				state = StateOfDataGrid.StructureOfCompany;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (state == StateOfDataGrid.Departments)
				{
					string search = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
					dataGridView1.DataSource = _dbM.employeesSelect(search);
					state = StateOfDataGrid.Employees;
				}
				else if(state==StateOfDataGrid.StructureOfCompany)
				{
					string search = dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
					dataGridView1.DataSource = _dbM.employeesSelect(search);
					state = StateOfDataGrid.Employees;
				}
				else if(state==StateOfDataGrid.Employees)
				{
					int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
					Employee emp=_company._employees.Find(x=>x.ID==id);
					OpenFormEmployee(emp);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void OpenFormEmployee(Employee emp=null)
		{
			Form3 form3 = new Form3(emp);
			form3.FormClosed += Form3_FormClosed;
			this.Enabled = false;
			form3.Show();
		}

		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Enabled = true;
			dataGridView1.DataSource = _dbM.employeesSelectAll();
			state = StateOfDataGrid.Employees;
			_company.Update();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.FormClosed += Form3_FormClosed;
			this.Enabled = false;
			form3.Show();
		}
	}
}
