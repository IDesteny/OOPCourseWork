using Newtonsoft.Json;

using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CourseWork
{
	/// <summary>
	/// Класс мэйн формы
	/// </summary>
	public partial class Form1 : Form
	{
		/// <summary>
		/// Имя "бд"
		/// </summary>
		const string FILENAME = "Participants.json";
		
		public struct Participant
		{
			public string name;			// Имя
			public string surname;		// Фамилия
			public string lastname;		// Отчество 
			public string speciality;	// Специальность
			public string subject;		// Тематика
			public string position;		// Должность
			public string rank;           // Категория
		}

		public Form1()
		{
			// Создать бд если ее нет
			Task.Run(() => File.Open(FILENAME, FileMode.OpenOrCreate).Close());

			// Показать превью
			using (var form4 = new Form4())
			{
				form4.ShowDialog();
			}

			InitializeComponent();
		}

		/// <summary>
		/// Записать данные в файл
		/// </summary>
		/// <typeparam name="T"> Тип хранящийся в списке </typeparam>
		/// <param name="data"> Данные для занесения </param>
		/// <returns> Таск </returns>
		async Task WriteToFile<T>(List<T> data)
		{
			using (var streamWriter = new StreamWriter(FILENAME, false))
			{
				await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
			}	
		}

		/// <summary>
		/// Прочитать данные из файла
		/// </summary>
		/// <typeparam name="T"> Тип хранящийся в списке </typeparam>
		/// <returns> Полученные данные </returns>
		async Task<List<T>> ReadFromFile<T>()
		{
			using (var streamReader = new StreamReader(FILENAME))
			{
				return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
			}
		}

		/// <summary>
		/// Добавить в файл
		/// </summary>
		/// <typeparam name="T"> Тип данных для занесения </typeparam>
		/// <param name="data"> Данные для занесения </param>
		/// <returns> Таск </returns>
		async Task AddToFile<T>(T data)
		{
			var datas = await ReadFromFile<T>();
			datas.Add(data);
			await WriteToFile(datas);
		}

		/// <summary>
		/// Удалить из файла по индексу
		/// </summary>
		/// <typeparam name="T"> Тип удаляемых данных </typeparam>
		/// <param name="index"> Индекс в списке </param>
		/// <returns> Таск </returns>
		async Task DeleteFromFileAt<T>(int index)
		{
			var datas = await ReadFromFile<T>();
			datas.RemoveAt(index);
			await WriteToFile(datas);
		}

		/// <summary>
		/// Проверка на корректность TextBox поля
		/// </summary>
		/// <param name="tb"> TextBox поле </param>
		/// <returns> true - если корректный, иначе false </returns>
		bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;

		/// <summary>
		/// Проверка на корректность ComboBox поля
		/// </summary>
		/// <param name="cb"> ComboBox поле </param>
		/// <returns> true - если корректный, иначе false </returns>
		bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.Red) != Color.Red;

		/// <summary>
		/// Проверка на корректность всех полей
		/// </summary>
		bool CheckOnCorrectFields =>
			CheckOnCorrectTextBox(Firstname) &
			CheckOnCorrectTextBox(Surname) &
			CheckOnCorrectTextBox(Lastname) &
			CheckOnCorrectTextBox(Speciality) &
			CheckOnCorrectTextBox(Subject) &
			CheckOnCorrectComboBox(Category) &
			CheckOnCorrectComboBox(Post);

		/// <summary>
		/// Очистить все поля
		/// </summary>
		void ClearAllField()
		{
			Firstname.Text = Surname.Text = Lastname.Text = Speciality.Text = Subject.Text = default;
			Category.SelectedIndex = Post.SelectedIndex = -1;
		}

		/// <summary>
		/// Колбэк добавления данных в файл
		/// </summary>
		/// <param name="sender"> Объект вызвавший колбэк </param>
		/// <param name="e"> Событие при котором было вызванно </param>
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

		/// <summary>
		/// Отобразать всё содержимое в Display
		/// </summary>
		/// <param name="participants"> Учасники для отображения </param>
		void DisplayData(List<Participant> participants)
		{
			Display.Items.Clear();

			var i = 0; // ID
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

		/// <summary>
		/// Отображение данных из бд
		/// </summary>
		async void UpdateData()
		{
			DisplayData(await ReadFromFile<Participant>());
		}

		/// <summary>
		/// Отобразить всё содержимое при открытии Display
		/// </summary>
		/// <param name="sender"> Объект вызвавший колбэк </param>
		/// <param name="e"> Событие при котором было вызванно </param>
		void Display_VisibleChanged(object sender, EventArgs e) => UpdateData();

		/// <summary>
		/// Компоратор для сортировки полей Display
		/// </summary>
		class ListViewItemComparer : IComparer
		{
			/// <summary>
			/// ID сортируемой колонки
			/// </summary>
			public int column;

			/// <summary>
			/// Компоратор
			/// </summary>
			/// <param name="x"></param>
			/// <param name="y"></param>
			/// <returns></returns>
			public int Compare(object x, object y) => string.Compare((x as ListViewItem).SubItems[column].Text, (y as ListViewItem).SubItems[column].Text);
		}

		/// <summary>
		/// Отсортировать по нажатой колонке
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Display_ColumnClick(object sender, ColumnClickEventArgs e) => Display.ListViewItemSorter = new ListViewItemComparer { column = e.Column };

		/// <summary>
		/// Отобразить форму фильтрации
		/// </summary>
		async void ShowFilter()
		{
			using (var form2 = new Form2())
			{
				if (form2.ShowDialog() == DialogResult.OK)
				{
					var queryResult =
						from participant in await ReadFromFile<Participant>()
						where string.IsNullOrEmpty(form2.GetSpeciality) || participant.speciality == form2.GetSpeciality
						where string.IsNullOrEmpty(form2.GetSubject) || participant.subject == form2.GetSubject
						select participant;

					// Обновить содержимое
					DisplayData(queryResult.ToList());
				}
			}
		}

		/// <summary>
		/// Отобразить форму удаления
		/// </summary>
		async void ShowDelete()
		{
			using (var form3 = new Form3())
			{
				if (form3.ShowDialog() == DialogResult.OK)
				{
					try
					{
						await DeleteFromFileAt<Participant>(form3.GetDelIndex);

						UpdateData();
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Пользователя с таким ID не существует");
					}
				}
			}
		}

		/// <summary>
		/// Отобразить форму поиска
		/// </summary>
		async void ShowSearch()
		{
			using (var form5 = new Form5())
			{
				if (form5.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Создать список из одного эл-та
						DisplayData(new List<Participant> { (await ReadFromFile<Participant>()).ElementAt(form5.GetSearchIndex) });
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Пользователя с таким ID не существует");
					}
				}
			}
		}

		/// <summary>
		/// Отобразить форму редактирования
		/// </summary>
		async void ShowEditing()
		{
			using (var form6 = new Form6())
			{
				if (form6.ShowDialog() == DialogResult.OK)
				{
					var participant = await ReadFromFile<Participant>();
					var delIndex = form6.GetEditIndex;

					try
					{
						participant.RemoveAt(delIndex);
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Пользователя с таким ID не существует");
						return;
					}

					participant.Insert(delIndex, new Participant
					{
						name = form6.GetFirstname,
						surname = form6.GetSurname,
						lastname = form6.GetLastname,
						speciality = form6.GetSpeciality,
						subject = form6.GetSubject,
						position = form6.GetPost,
						rank = form6.GetCategory
					});

					await WriteToFile(participant);
					UpdateData();
				}
			}
		}

		/// <summary>
		/// Отобразить модальное окно на подтверждение удаления данных из бд
		/// </summary>
		async void ShowRemove()
		{
			if (MessageBox.Show("Вы действительно хотите удалить всю информацию из базы данных?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				await WriteToFile<Participant>(null);
				UpdateData();
			}
		}

		/// <summary>
		/// Колбэк на нажатия
		/// </summary>
		/// <param name="message"></param>
		/// <param name="keys"></param>
		/// <returns></returns>
		protected override bool ProcessCmdKey(ref Message message, Keys keys)
		{
			if (tabControl1.SelectedTab == ListOfAllParticipants) // Если выбрана нужная вкладка
			{
				switch (keys)
				{
					case Keys.Control | Keys.F:
						ShowFilter();
						return true;

					case Keys.Control | Keys.D:
						ShowDelete();
						return true;

					case Keys.Control | Keys.S:
						ShowSearch();
						return true;

					case Keys.Control | Keys.E:
						ShowEditing();
						return true;

					case Keys.Control | Keys.R:
						ShowRemove();
						return true;
				}
			}

			return base.ProcessCmdKey(ref message, keys);
		}

		/// <summary>
		/// Очистка контрола от красного цвета
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Category_Enter(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;
	}
}