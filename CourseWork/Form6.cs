using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form6 : Form
	{
		public string GetFirstname => Firstname.Text;
		public string GetSurname => Surname.Text;
		public string GetLastname => Lastname.Text;
		public string GetSpeciality => Speciality.Text;
		public string GetSubject => Subject.Text;
		public string GetCategory => Category.SelectedItem as string;
		public string GetPost => Post.SelectedItem as string;

		public int GetEditIndex => (int)numericUpDown1.Value;

		public Form6() => InitializeComponent();

		bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;
		bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.Red) != Color.Red;

		bool CheckOnCorrectFields =>
			CheckOnCorrectTextBox(Firstname) &
			CheckOnCorrectTextBox(Surname) &
			CheckOnCorrectTextBox(Lastname) &
			CheckOnCorrectTextBox(Speciality) &
			CheckOnCorrectTextBox(Subject) &
			CheckOnCorrectComboBox(Category) &
			CheckOnCorrectComboBox(Post);

		void button1_Click(object sender, EventArgs e) => DialogResult = CheckOnCorrectFields ? DialogResult.OK : DialogResult.None & MessageBox.Show("Введите корректные данные");
		void Category_Enter(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;
	}
}
