namespace Kosta.View
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.connectionBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.allDepsBtn = new System.Windows.Forms.Button();
			this.empsBtn = new System.Windows.Forms.Button();
			this.structCompBtn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.addEmployeeBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// connectionBtn
			// 
			this.connectionBtn.Location = new System.Drawing.Point(12, 415);
			this.connectionBtn.Name = "connectionBtn";
			this.connectionBtn.Size = new System.Drawing.Size(139, 23);
			this.connectionBtn.TabIndex = 0;
			this.connectionBtn.Text = "Подключение";
			this.connectionBtn.UseVisualStyleBackColor = true;
			this.connectionBtn.Click += new System.EventHandler(this.Button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(776, 367);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			// 
			// allDepsBtn
			// 
			this.allDepsBtn.Location = new System.Drawing.Point(157, 415);
			this.allDepsBtn.Name = "allDepsBtn";
			this.allDepsBtn.Size = new System.Drawing.Size(151, 23);
			this.allDepsBtn.TabIndex = 2;
			this.allDepsBtn.Text = "Все отделы компании";
			this.allDepsBtn.UseVisualStyleBackColor = true;
			this.allDepsBtn.Click += new System.EventHandler(this.Button2_Click);
			// 
			// empsBtn
			// 
			this.empsBtn.Location = new System.Drawing.Point(314, 415);
			this.empsBtn.Name = "empsBtn";
			this.empsBtn.Size = new System.Drawing.Size(151, 23);
			this.empsBtn.TabIndex = 3;
			this.empsBtn.Text = "Сотрудники компании";
			this.empsBtn.UseVisualStyleBackColor = true;
			this.empsBtn.Click += new System.EventHandler(this.Button3_Click);
			// 
			// structCompBtn
			// 
			this.structCompBtn.Location = new System.Drawing.Point(637, 415);
			this.structCompBtn.Name = "structCompBtn";
			this.structCompBtn.Size = new System.Drawing.Size(151, 23);
			this.structCompBtn.TabIndex = 4;
			this.structCompBtn.Text = "Cтруктура предприятия";
			this.structCompBtn.UseVisualStyleBackColor = true;
			this.structCompBtn.Click += new System.EventHandler(this.Button4_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(471, 415);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// addEmployeeBtn
			// 
			this.addEmployeeBtn.Location = new System.Drawing.Point(12, 386);
			this.addEmployeeBtn.Name = "addEmployeeBtn";
			this.addEmployeeBtn.Size = new System.Drawing.Size(139, 23);
			this.addEmployeeBtn.TabIndex = 6;
			this.addEmployeeBtn.Text = "Добавить сотрудника";
			this.addEmployeeBtn.UseVisualStyleBackColor = true;
			this.addEmployeeBtn.Click += new System.EventHandler(this.Button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addEmployeeBtn);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.structCompBtn);
			this.Controls.Add(this.empsBtn);
			this.Controls.Add(this.allDepsBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.connectionBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button connectionBtn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button allDepsBtn;
		private System.Windows.Forms.Button empsBtn;
		private System.Windows.Forms.Button structCompBtn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button addEmployeeBtn;
	}
}

