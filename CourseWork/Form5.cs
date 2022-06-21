using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form5 : Form
	{
		public Form5() => InitializeComponent();

		public int GetSearchIndex => (int)SearchIndex.Value;
	}
}
