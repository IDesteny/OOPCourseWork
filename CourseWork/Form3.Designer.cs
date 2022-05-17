
namespace CourseWork
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.DelIndex = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DelIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// DelIndex
			// 
			this.DelIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DelIndex.Location = new System.Drawing.Point(110, 38);
			this.DelIndex.Name = "DelIndex";
			this.DelIndex.Size = new System.Drawing.Size(134, 20);
			this.DelIndex.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(110, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(107, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите ID пользователя";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(357, 120);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DelIndex);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Удаление";
			((System.ComponentModel.ISupportInitialize)(this.DelIndex)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown DelIndex;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}