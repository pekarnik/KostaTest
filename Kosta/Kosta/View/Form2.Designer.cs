namespace Kosta.View
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.hostnameText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.databaseText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.userText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// hostnameText
			// 
			this.hostnameText.Location = new System.Drawing.Point(12, 88);
			this.hostnameText.Name = "hostnameText";
			this.hostnameText.Size = new System.Drawing.Size(196, 20);
			this.hostnameText.TabIndex = 0;
			this.hostnameText.Text = "DESKTOP-SMHS2FC\\SQLEXPRESS";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hostname";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Database";
			// 
			// databaseText
			// 
			this.databaseText.Location = new System.Drawing.Point(12, 132);
			this.databaseText.Name = "databaseText";
			this.databaseText.Size = new System.Drawing.Size(196, 20);
			this.databaseText.TabIndex = 3;
			this.databaseText.Text = "TestDB";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "User";
			// 
			// userText
			// 
			this.userText.Location = new System.Drawing.Point(12, 176);
			this.userText.Name = "userText";
			this.userText.Size = new System.Drawing.Size(196, 20);
			this.userText.TabIndex = 5;
			this.userText.Text = "DESKTOP-SMHS2FC\\Pekarnik";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(12, 220);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(196, 20);
			this.passwordText.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 281);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Подключить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(226, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.userText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.databaseText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hostnameText);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox hostnameText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox databaseText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox userText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Button button1;
	}
}