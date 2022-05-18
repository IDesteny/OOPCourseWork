using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form4 : Form
	{
		public Form4() => InitializeComponent();
		protected override bool ProcessCmdKey(ref Message message, Keys keys) => (DialogResult = DialogResult.OK) == DialogResult.OK;
	}
}
