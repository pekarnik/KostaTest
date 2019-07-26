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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}


		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DatabaseManipulations._connect = new SQLConnect(hostname: hostnameText.Text, database: databaseText.Text, user: userText.Text, password: passwordText.Text);
				DatabaseManipulations._connect.ConnectionOpen();
			}
			catch
			{
				MessageBox.Show("Не удалось установить соединение");
			}
			if (DatabaseManipulations._connect.Connection)
			{
				this.Close();				
			}
		}
		
	}
}
