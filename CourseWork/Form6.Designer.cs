
namespace CourseWork
{
	partial class Form6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Category = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Post = new System.Windows.Forms.ComboBox();
			this.Subject = new System.Windows.Forms.TextBox();
			this.Speciality = new System.Windows.Forms.TextBox();
			this.Lastname = new System.Windows.Forms.TextBox();
			this.Surname = new System.Windows.Forms.TextBox();
			this.Firstname = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(32, 203);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 15);
			this.label7.TabIndex = 29;
			this.label7.Text = "Категория";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(28, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 15);
			this.label5.TabIndex = 28;
			this.label5.Text = "Должность";
			// 
			// Category
			// 
			this.Category.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Category.FormattingEnabled = true;
			this.Category.Items.AddRange(new object[] {
            "Участник",
            "Гость"});
			this.Category.Location = new System.Drawing.Point(100, 201);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(170, 21);
			this.Category.TabIndex = 26;
			this.Category.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.CadetBlue;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(100, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 26);
			this.button1.TabIndex = 27;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(37, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 15);
			this.label6.TabIndex = 25;
			this.label6.Text = "Тематика";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(8, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 15);
			this.label3.TabIndex = 24;
			this.label3.Text = "Специальность";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(37, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 15);
			this.label4.TabIndex = 23;
			this.label4.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(39, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 22;
			this.label2.Text = "Фамилия";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(65, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 15);
			this.label1.TabIndex = 21;
			this.label1.Text = "Имя";
			// 
			// Post
			// 
			this.Post.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Post.FormattingEnabled = true;
			this.Post.Items.AddRange(new object[] {
            "Студент",
            "Преподаватель",
            "Аспирант"});
			this.Post.Location = new System.Drawing.Point(100, 174);
			this.Post.Name = "Post";
			this.Post.Size = new System.Drawing.Size(170, 21);
			this.Post.TabIndex = 20;
			this.Post.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// Subject
			// 
			this.Subject.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Subject.Location = new System.Drawing.Point(100, 148);
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(170, 20);
			this.Subject.TabIndex = 19;
			this.Subject.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// Speciality
			// 
			this.Speciality.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Speciality.Location = new System.Drawing.Point(100, 122);
			this.Speciality.Name = "Speciality";
			this.Speciality.Size = new System.Drawing.Size(170, 20);
			this.Speciality.TabIndex = 18;
			this.Speciality.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// Lastname
			// 
			this.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Lastname.Location = new System.Drawing.Point(100, 96);
			this.Lastname.Name = "Lastname";
			this.Lastname.Size = new System.Drawing.Size(170, 20);
			this.Lastname.TabIndex = 17;
			this.Lastname.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// Surname
			// 
			this.Surname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Surname.Location = new System.Drawing.Point(100, 70);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(170, 20);
			this.Surname.TabIndex = 16;
			this.Surname.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// Firstname
			// 
			this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Firstname.Location = new System.Drawing.Point(100, 44);
			this.Firstname.Name = "Firstname";
			this.Firstname.Size = new System.Drawing.Size(170, 20);
			this.Firstname.TabIndex = 15;
			this.Firstname.Enter += new System.EventHandler(this.Category_Enter);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.numericUpDown1.Location = new System.Drawing.Point(131, 18);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 30;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(104, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 15);
			this.label8.TabIndex = 31;
			this.label8.Text = "ID";
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(335, 269);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Category);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Post);
			this.Controls.Add(this.Subject);
			this.Controls.Add(this.Speciality);
			this.Controls.Add(this.Lastname);
			this.Controls.Add(this.Surname);
			this.Controls.Add(this.Firstname);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(351, 308);
			this.Name = "Form6";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Редактирование";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Category;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Post;
		private System.Windows.Forms.TextBox Subject;
		private System.Windows.Forms.TextBox Speciality;
		private System.Windows.Forms.TextBox Lastname;
		private System.Windows.Forms.TextBox Surname;
		private System.Windows.Forms.TextBox Firstname;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label8;
	}
}