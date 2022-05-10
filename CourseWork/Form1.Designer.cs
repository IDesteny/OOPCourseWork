
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Display = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.RegistrationOfParticipants.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
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
			this.RegistrationOfParticipants.Size = new System.Drawing.Size(836, 373);
			this.RegistrationOfParticipants.TabIndex = 3;
			this.RegistrationOfParticipants.Text = "Регистрация";
			this.RegistrationOfParticipants.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(260, 234);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Категория";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(260, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Должность";
			// 
			// Category
			// 
			this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Category.FormattingEnabled = true;
			this.Category.Items.AddRange(new object[] {
            "Участник",
            "Гость"});
			this.Category.Location = new System.Drawing.Point(352, 234);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(170, 21);
			this.Category.TabIndex = 12;
			this.Category.Click += new System.EventHandler(this.Category_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.PeachPuff;
			this.button1.Location = new System.Drawing.Point(263, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(259, 26);
			this.button1.TabIndex = 11;
			this.button1.Text = "Зарегистрироваться";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(260, 181);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Тематика";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(260, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Специальность";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(260, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Фамилия";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(260, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Имя";
			// 
			// Post
			// 
			this.Post.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Post.FormattingEnabled = true;
			this.Post.Items.AddRange(new object[] {
            "Студент",
            "Преподаватель",
            "Аспирант"});
			this.Post.Location = new System.Drawing.Point(352, 207);
			this.Post.Name = "Post";
			this.Post.Size = new System.Drawing.Size(170, 21);
			this.Post.TabIndex = 5;
			this.Post.Click += new System.EventHandler(this.Category_Click);
			// 
			// Subject
			// 
			this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Subject.Location = new System.Drawing.Point(352, 181);
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(170, 20);
			this.Subject.TabIndex = 4;
			this.Subject.Click += new System.EventHandler(this.Category_Click);
			// 
			// Speciality
			// 
			this.Speciality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Speciality.Location = new System.Drawing.Point(352, 155);
			this.Speciality.Name = "Speciality";
			this.Speciality.Size = new System.Drawing.Size(170, 20);
			this.Speciality.TabIndex = 3;
			this.Speciality.Click += new System.EventHandler(this.Category_Click);
			// 
			// Lastname
			// 
			this.Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Lastname.Location = new System.Drawing.Point(352, 129);
			this.Lastname.Name = "Lastname";
			this.Lastname.Size = new System.Drawing.Size(170, 20);
			this.Lastname.TabIndex = 2;
			this.Lastname.Click += new System.EventHandler(this.Category_Click);
			// 
			// Surname
			// 
			this.Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Surname.Location = new System.Drawing.Point(352, 103);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(170, 20);
			this.Surname.TabIndex = 1;
			this.Surname.Click += new System.EventHandler(this.Category_Click);
			// 
			// Firstname
			// 
			this.Firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Firstname.Location = new System.Drawing.Point(352, 77);
			this.Firstname.Name = "Firstname";
			this.Firstname.Size = new System.Drawing.Size(170, 20);
			this.Firstname.TabIndex = 0;
			this.Firstname.Click += new System.EventHandler(this.Category_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.RegistrationOfParticipants);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(844, 399);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.Display);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(836, 373);
			this.tabPage1.TabIndex = 4;
			this.tabPage1.Text = "Список всех участников";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Display
			// 
			this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.Display.HideSelection = false;
			this.Display.Location = new System.Drawing.Point(3, 6);
			this.Display.Name = "Display";
			this.Display.Size = new System.Drawing.Size(827, 361);
			this.Display.TabIndex = 0;
			this.Display.UseCompatibleStateImageBehavior = false;
			this.Display.View = System.Windows.Forms.View.Details;
			this.Display.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Display_ColumnClick);
			this.Display.VisibleChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
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
			// columnHeader4
			// 
			this.columnHeader4.Text = "Тематика";
			this.columnHeader4.Width = 98;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Специальность";
			this.columnHeader5.Width = 137;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Должность";
			this.columnHeader6.Width = 101;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Категория";
			this.columnHeader7.Width = 143;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(868, 423);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Конференция";
			this.RegistrationOfParticipants.ResumeLayout(false);
			this.RegistrationOfParticipants.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
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
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView Display;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}

