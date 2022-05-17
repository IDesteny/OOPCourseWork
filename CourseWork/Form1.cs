using System;
using System.IO;
using System.Linq;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CourseWork
{
	public partial class Form1 : Form
	{
		const string FILENAME = "Participants.json";
		
		struct Participant
		{
			public string name;
			public string surname;
			public string lastname;
			public string speciality;
			public string subject;
			public string position;
			public string rank;
		}

		public Form1() => InitializeComponent();

		async Task WriteParticipants(List<Participant> participants)
		{
			using (var streamWriter = new StreamWriter(FILENAME, false))
			{
				await streamWriter.WriteAsync(JsonConvert.SerializeObject(participants));
			}	
		}

		async Task<List<Participant>> ReadParticipants()
		{
			using (var streamReader = new StreamReader(FILENAME))
			{
				return await Task.Run(async () => JsonConvert.DeserializeObject<List<Participant>>(await streamReader.ReadToEndAsync()) ?? new List<Participant>());
			}
		}

		async Task AddParticipants(Participant participant)
		{
			var participants = await ReadParticipants();
			participants.Add(participant);
			await WriteParticipants(participants);
		}

		async Task DeleteParticipantsAt(int index)
		{
			var participants = await ReadParticipants();
			participants.RemoveAt(index);
			await WriteParticipants(participants);
		}

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

		void ClearAllField()
		{
			Firstname.Text = null;
			Surname.Text = null;
			Lastname.Text = null;
			Speciality.Text = null;
			Subject.Text = null;
			Category.SelectedIndex = -1;
			Post.SelectedIndex = -1;
		}

		async void button1_Click(object sender, EventArgs e)
		{
			if (!CheckOnCorrectFields)
			{
				MessageBox.Show("Введите корректные данные");
				return;
			}

			Participant participant;
			participant.name = Firstname.Text;
			participant.surname = Surname.Text;
			participant.lastname = Lastname.Text;
			participant.speciality = Speciality.Text;
			participant.subject = Subject.Text;
			participant.position = Post.SelectedItem.ToString();
			participant.rank = Category.SelectedItem.ToString();

			await AddParticipants(participant);

			MessageBox.Show("Пользователь зарегистрирован");

			ClearAllField();
		}

		void DisplayData(List<Participant> participants)
		{
			Display.Items.Clear();
			var i = 0;

			foreach (var participant in participants)
			{
				var listViewItem = new ListViewItem(i.ToString());
				listViewItem.SubItems.Add(participant.name);
				listViewItem.SubItems.Add(participant.surname);
				listViewItem.SubItems.Add(participant.lastname);
				listViewItem.SubItems.Add(participant.speciality);
				listViewItem.SubItems.Add(participant.subject);
				listViewItem.SubItems.Add(participant.position);
				listViewItem.SubItems.Add(participant.rank);

				Display.Items.Add(listViewItem);
				++i;
			}
		}

		async void Display_SelectedIndexChanged(object sender, EventArgs e) => DisplayData(await ReadParticipants());

		class ListViewItemComparer : IComparer
		{
			readonly int col;

			public ListViewItemComparer(int column) => col = column;

			public int Compare(object x, object y) => string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
		}

		void Display_ColumnClick(object sender, ColumnClickEventArgs e) => Display.ListViewItemSorter = new ListViewItemComparer(e.Column);

		async void ShowFilter()
		{
			using (var form2 = new Form2())
			{
				if (form2.ShowDialog() == DialogResult.OK)
				{
					var queryResult =
						from participant in await ReadParticipants()
						where
							!string.IsNullOrEmpty(form2.GetSpeciality) ? participant.speciality == form2.GetSpeciality : false ||
							string.IsNullOrEmpty(form2.GetSubject) || participant.subject == form2.GetSubject
						select participant;

					DisplayData(queryResult.ToList());
				}
			}
		}

		async void ShowDelete()
		{
			using (var form3 = new Form3())
			{
				if (form3.ShowDialog() == DialogResult.OK)
				{
					try
					{
						await DeleteParticipantsAt(form3.GetDelIndex);
						DisplayData(await ReadParticipants());
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Пользователя с таким ID не существует");
					}
				}
			}
		}

		protected override bool ProcessCmdKey(ref Message message, Keys keys)
		{
			if (tabControl1.SelectedIndex == 1)
			{
				switch (keys)
				{
					case Keys.Control | Keys.F:
						ShowFilter();
						return true;

					case Keys.Control | Keys.D:
						ShowDelete();
						return true;
				}
			}

			return base.ProcessCmdKey(ref message, keys);
		}

		void TextBox_Click(object sender, EventArgs e) => ((Control)sender).BackColor = Color.White;
	}
}
