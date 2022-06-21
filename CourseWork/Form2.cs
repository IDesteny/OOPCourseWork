using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form2 : Form
	{
		public Form2() => InitializeComponent();

		public string GetSpeciality => Speciality2.Text;
		public string GetSubject => Subject2.Text;

		bool CheckOnCorrectTextBox(TextBox tb) => string.IsNullOrEmpty(tb.Text) || !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;

		void Subject2_Enter(object sender, EventArgs e) => (sender as TextBox).BackColor = Color.White;
		void button1_Click(object sender, EventArgs e) => DialogResult = CheckOnCorrectTextBox(Speciality2) & CheckOnCorrectTextBox(Subject2) ? DialogResult.OK : DialogResult.None;
	}
}