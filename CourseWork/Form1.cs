using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;

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

		async void WriteParticipant(Participant participant)
		{
			List<Participant> participants;

			using (var streamReader = new StreamReader(FILENAME))
			{
				participants = await Task.Run(() => JsonConvert.DeserializeObject<List<Participant>>(streamReader.ReadToEnd()) ?? new List<Participant>());
			}

			participants.Add(participant);

			using (var streamWriter = new StreamWriter(FILENAME))
			{
				await streamWriter.WriteAsync(JsonConvert.SerializeObject(participants));
			}
		}

		async Task<List<Participant>> ReadParticipant()
		{
			using (var streamReader = new StreamReader(FILENAME))
			{
				return await Task.Run(() => JsonConvert.DeserializeObject<List<Participant>>(streamReader.ReadToEnd()) ?? new List<Participant>());
			}
		}

		bool CheckOnCorrectTextBox(TextBox tb) => Regex.IsMatch(tb.Text, @"^\s*$") || !Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") ? (tb.BackColor = Color.Red) != Color.Red : true;

		bool CheckOnCorrectComboBox(ComboBox cb) => cb.SelectedItem is null ? (cb.BackColor = Color.Red) != Color.Red : true;

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

		void button1_Click(object sender, EventArgs e)
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

			WriteParticipant(participant);

			MessageBox.Show("Участник зарегистрирован");

			ClearAllField();
		}

		void DisplayData(List<Participant> participants)
		{
			Display.Items.Clear();

			foreach (var participant in participants)
			{
				var listViewItem = new ListViewItem(participant.name);
				listViewItem.SubItems.Add(participant.surname);
				listViewItem.SubItems.Add(participant.lastname);
				listViewItem.SubItems.Add(participant.speciality);
				listViewItem.SubItems.Add(participant.subject);
				listViewItem.SubItems.Add(participant.position);
				listViewItem.SubItems.Add(participant.rank);

				Display.Items.Add(listViewItem);
			}
		}

		async void Display_SelectedIndexChanged(object sender, EventArgs e) => DisplayData(await ReadParticipant());

		async void Display_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			using (var form2 = new Form2())
			{
				if (form2.ShowDialog() == DialogResult.OK)
				{
					var queryResult =
						from participant in await ReadParticipant()
						where !string.IsNullOrEmpty(form2.GetSpeciality) ? participant.speciality == form2.GetSpeciality : true && !string.IsNullOrEmpty(form2.GetSubject) ? participant.subject == form2.GetSubject : true
						select participant;

					DisplayData(queryResult.ToList());
				
				}
			}
		}

		void TextBox_Click(object sender, EventArgs e) => ((Control)sender).BackColor = Color.White;
	}
}
