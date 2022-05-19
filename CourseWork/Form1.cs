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

		public Form1()
		{
			Task.Run(() =>
			{
				if (!File.Exists(FILENAME))
				{
					File.Create(FILENAME);
				}
			});

			using (var form4 = new Form4())
			{
				form4.ShowDialog();
			}

			InitializeComponent();
		}

		async Task WriteToFile<T>(List<T> data)
		{
			using (var streamWriter = new StreamWriter(FILENAME, false))
			{
				await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
			}	
		}

		async Task<List<T>> ReadFromFile<T>()
		{
			using (var streamReader = new StreamReader(FILENAME))
			{
				return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
			}
		}

		async Task AddToFile<T>(T data)
		{
			var datas = await ReadFromFile<T>();
			datas.Add(data);
			await WriteToFile(datas);
		}

		async Task DeleteFromFileAt<T>(int index)
		{
			var datas = await ReadFromFile<T>();
			datas.RemoveAt(index);
			await WriteToFile(datas);
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
			Firstname.Text = Surname.Text = Lastname.Text = Speciality.Text = Subject.Text = null;
			Category.SelectedIndex = Post.SelectedIndex = -1;
		}

		async void Button1_Click(object sender, EventArgs e)
		{
			if (CheckOnCorrectFields)
			{
				await AddToFile(new Participant
				{
					name = Firstname.Text,
					surname = Surname.Text,
					lastname = Lastname.Text,
					speciality = Speciality.Text,
					subject = Subject.Text,
					position = Post.SelectedItem as string,
					rank = Category.SelectedItem as string
				});

				ClearAllField();

				MessageBox.Show("Пользователь зарегистрирован");
				return;
			}

			MessageBox.Show("Введите корректные данные");
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

		async void Display_SelectedIndexChanged(object sender, EventArgs e) => DisplayData(await ReadFromFile<Participant>());

		class ListViewItemComparer : IComparer
		{
			public int column;
			public int Compare(object x, object y) => string.Compare((x as ListViewItem).SubItems[column].Text, (y as ListViewItem).SubItems[column].Text);
		}

		void Display_ColumnClick(object sender, ColumnClickEventArgs e) => Display.ListViewItemSorter = new ListViewItemComparer { column = e.Column };

		async void ShowFilter()
		{
			using (var form2 = new Form2())
			{
				if (form2.ShowDialog() == DialogResult.OK)
				{
					var queryResult =
						from participant in await ReadFromFile<Participant>()
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
						await DeleteFromFileAt<Participant>(form3.GetDelIndex);
						DisplayData(await ReadFromFile<Participant>());
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
			if (tabControl1.SelectedTab == ListOfAllParticipants)
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

		void TextBox_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;
	}
}