
namespace CourseWork
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.RegistrationOfParticipants = new System.Windows.Forms.TabPage();
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ListOfAllParticipants = new System.Windows.Forms.TabPage();
			this.Display = new System.Windows.Forms.ListView();
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.RegistrationOfParticipants.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.ListOfAllParticipants.SuspendLayout();
			this.SuspendLayout();
			// 
			// RegistrationOfParticipants
			// 
			this.RegistrationOfParticipants.Controls.Add(this.label7);
			this.RegistrationOfParticipants.Controls.Add(this.label5);
			this.RegistrationOfParticipants.Controls.Add(this.Category);
			this.RegistrationOfParticipants.Controls.Add(this.button1);
			this.RegistrationOfParticipants.Controls.Add(this.label6);
			this.RegistrationOfParticipants.Controls.Add(this.label3);
			this.RegistrationOfParticipants.Controls.Add(this.label4);
			this.RegistrationOfParticipants.Controls.Add(this.label2);
			this.RegistrationOfParticipants.Controls.Add(this.label1);
			this.RegistrationOfParticipants.Controls.Add(this.Post);
			this.RegistrationOfParticipants.Controls.Add(this.Subject);
			this.RegistrationOfParticipants.Controls.Add(this.Speciality);
			this.RegistrationOfParticipants.Controls.Add(this.Lastname);
			this.RegistrationOfParticipants.Controls.Add(this.Surname);
			this.RegistrationOfParticipants.Controls.Add(this.Firstname);
			this.RegistrationOfParticipants.Location = new System.Drawing.Point(4, 22);
			this.RegistrationOfParticipants.Name = "RegistrationOfParticipants";
			this.RegistrationOfParticipants.Padding = new System.Windows.Forms.Padding(3);
			this.RegistrationOfParticipants.Size = new System.Drawing.Size(807, 440);
			this.RegistrationOfParticipants.TabIndex = 3;
			this.RegistrationOfParticipants.Text = "Регистрация";
			this.RegistrationOfParticipants.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(252, 277);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Категория";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(248, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 15);
			this.label5.TabIndex = 13;
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
			this.Category.Location = new System.Drawing.Point(320, 275);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(170, 23);
			this.Category.TabIndex = 11;
			this.Category.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(320, 300);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 26);
			this.button1.TabIndex = 12;
			this.button1.Text = "Зарегистрироваться";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(257, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "Тематика";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(228, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Специальность";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(257, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(259, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Фамилия";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(285, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 15);
			this.label1.TabIndex = 6;
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
			this.Post.Location = new System.Drawing.Point(320, 248);
			this.Post.Name = "Post";
			this.Post.Size = new System.Drawing.Size(170, 23);
			this.Post.TabIndex = 5;
			this.Post.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// Subject
			// 
			this.Subject.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Subject.Location = new System.Drawing.Point(320, 222);
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(170, 23);
			this.Subject.TabIndex = 4;
			this.Subject.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// Speciality
			// 
			this.Speciality.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Speciality.Location = new System.Drawing.Point(320, 196);
			this.Speciality.Name = "Speciality";
			this.Speciality.Size = new System.Drawing.Size(170, 23);
			this.Speciality.TabIndex = 3;
			this.Speciality.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// Lastname
			// 
			this.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Lastname.Location = new System.Drawing.Point(320, 170);
			this.Lastname.Name = "Lastname";
			this.Lastname.Size = new System.Drawing.Size(170, 23);
			this.Lastname.TabIndex = 2;
			this.Lastname.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// Surname
			// 
			this.Surname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Surname.Location = new System.Drawing.Point(320, 144);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(170, 23);
			this.Surname.TabIndex = 1;
			this.Surname.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// Firstname
			// 
			this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Firstname.Location = new System.Drawing.Point(320, 118);
			this.Firstname.Name = "Firstname";
			this.Firstname.Size = new System.Drawing.Size(170, 23);
			this.Firstname.TabIndex = 0;
			this.Firstname.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.RegistrationOfParticipants);
			this.tabControl1.Controls.Add(this.ListOfAllParticipants);
			this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.ItemSize = new System.Drawing.Size(77, 18);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(815, 466);
			this.tabControl1.TabIndex = 0;
			// 
			// ListOfAllParticipants
			// 
			this.ListOfAllParticipants.Controls.Add(this.Display);
			this.ListOfAllParticipants.Location = new System.Drawing.Point(4, 22);
			this.ListOfAllParticipants.Name = "ListOfAllParticipants";
			this.ListOfAllParticipants.Padding = new System.Windows.Forms.Padding(3);
			this.ListOfAllParticipants.Size = new System.Drawing.Size(807, 440);
			this.ListOfAllParticipants.TabIndex = 4;
			this.ListOfAllParticipants.Text = "Список всех участников";
			this.ListOfAllParticipants.UseVisualStyleBackColor = true;
			// 
			// Display
			// 
			this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
			this.Display.HideSelection = false;
			this.Display.Location = new System.Drawing.Point(6, 6);
			this.Display.Name = "Display";
			this.Display.Size = new System.Drawing.Size(795, 428);
			this.Display.TabIndex = 0;
			this.Display.UseCompatibleStateImageBehavior = false;
			this.Display.View = System.Windows.Forms.View.Details;
			this.Display.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Display_ColumnClick);
			this.Display.VisibleChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "ID";
			this.columnHeader8.Width = 27;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Имя";
			this.columnHeader1.Width = 56;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Фамилия";
			this.columnHeader2.Width = 77;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Отчество";
			this.columnHeader3.Width = 77;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Специальность";
			this.columnHeader5.Width = 108;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Тематика";
			this.columnHeader4.Width = 96;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Должность";
			this.columnHeader6.Width = 90;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Категория";
			this.columnHeader7.Width = 103;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(839, 490);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Конференция";
			this.RegistrationOfParticipants.ResumeLayout(false);
			this.RegistrationOfParticipants.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ListOfAllParticipants.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage RegistrationOfParticipants;
		private System.Windows.Forms.ComboBox Post;
		private System.Windows.Forms.TextBox Subject;
		private System.Windows.Forms.TextBox Speciality;
		private System.Windows.Forms.TextBox Lastname;
		private System.Windows.Forms.TextBox Surname;
		private System.Windows.Forms.TextBox Firstname;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Category;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage ListOfAllParticipants;
		private System.Windows.Forms.ListView Display;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
	}
}

