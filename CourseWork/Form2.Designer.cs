
namespace CourseWork
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.Speciality2 = new System.Windows.Forms.TextBox();
			this.Subject2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Speciality2
			// 
			this.Speciality2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Speciality2.Location = new System.Drawing.Point(129, 22);
			this.Speciality2.Name = "Speciality2";
			this.Speciality2.Size = new System.Drawing.Size(162, 20);
			this.Speciality2.TabIndex = 0;
			this.Speciality2.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// Subject2
			// 
			this.Subject2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Subject2.Location = new System.Drawing.Point(129, 48);
			this.Subject2.Name = "Subject2";
			this.Subject2.Size = new System.Drawing.Size(162, 20);
			this.Subject2.TabIndex = 1;
			this.Subject2.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Location = new System.Drawing.Point(41, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(250, 28);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Специальность";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Тематика";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(357, 120);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Subject2);
			this.Controls.Add(this.Speciality2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(373, 159);
			this.Name = "Form2";
			this.Text = "Фильтрация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Speciality2;
		private System.Windows.Forms.TextBox Subject2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
	}
}