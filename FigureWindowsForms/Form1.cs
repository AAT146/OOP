using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Library;

namespace FigureWindowsForms
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Список фигур.
		/// </summary>
		private BindingList<FigureBase> _figureList = new BindingList<FigureBase>();

		/// <summary>
		/// Отфильтрованный список.
		/// </summary>
		private BindingList<FigureBase> _filteredList = new BindingList<FigureBase>();

		/// <summary>
		/// Для файлов.
		/// </summary>
		private readonly XmlSerializer _serializer =
			new XmlSerializer(typeof(BindingList<FigureBase>));

		/// <summary>
		/// Поле для хранения состояния формы добавления.
		/// </summary>
		private bool _isAddFormOpen = false;

		/// <summary>
		/// Поле для хранения состояния формы фильтра.
		/// </summary>
		private bool _isFilterFormOpen = false;

		/// <summary>
		/// Поле для хранения состояния фильтрации.
		/// </summary>
		private bool _isFilter = false;

		/// <summary>
		/// Конструктор MainForm.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			BackColor = Color.AliceBlue;
			dataGridViewSpace.BackgroundColor = Color.LightGray;
			StartPosition = FormStartPosition.CenterScreen;
		}

		/// <summary>
		/// Создание таблицы DataGrid.
		/// </summary>
		/// <param name="figure">Список фигур.</param>
		/// <param name="dataGridView">Сетка.</param>
		public static void CreateTable(BindingList<FigureBase> figure,
			  DataGridView dataGridView)
		{
			dataGridView.RowHeadersVisible = false;
			var source = new BindingSource(figure, null);
			dataGridView.DataSource = source;

			dataGridView.DefaultCellStyle.Alignment =
				DataGridViewContentAlignment.MiddleCenter;
			dataGridView.AllowUserToResizeColumns = false;
			dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
				DataGridViewContentAlignment.MiddleCenter;
			dataGridView.AutoSizeRowsMode =
				DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView.AutoSizeColumnsMode =
				DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.DefaultCellStyle.WrapMode =
				DataGridViewTriState.True;
			dataGridView.SelectionMode =
				DataGridViewSelectionMode.FullRowSelect;
		}

		/// <summary>
		/// Переход в форму добавления новой зарплаты.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickВuttonAdd(object sender, EventArgs e)
		{
			if (_isAddFormOpen == false && _isFilter == false)
			{
				_isAddFormOpen = true;

				AddSalary addSalary = new AddSalary();
				addSalary.FormClosed += (s, args) =>
				{ _isAddFormOpen = false; };
				addSalary.SalaryAdded += AddedSalary;
				addSalary.Show();
			}
		}

		/// <summary>
		/// Переход в форму фильтрации.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickВuttonFilter(object sender, EventArgs e)
		{
			if (!_isFilterFormOpen)
			{
				_isFilterFormOpen = true;
				buttonAdd.Enabled = false;
				FilterSalary filterSalary = new FilterSalary(_salaryList);
				filterSalary.FormClosed += (s, args) =>
				{ _isFilterFormOpen = false; };
				filterSalary.SalaryFiltered += FilteredSalary;
				filterSalary.Show();
			}
		}

		/// <summary>
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void LoadMainForm(object sender, EventArgs e)
		{
			_salaryList = new BindingList<SalaryBase>();
			CreateTable(_salaryList, dataGridViewSpace);
		}

		/// <summary>
		/// Добавление в список случайной зарплаты.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickВuttonRandomSalary(object sender, EventArgs e)
		{
			_salaryList.Add(RandomSalary.GetRandomSalary());
		}

		/// <summary>
		/// Очистить список.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickВuttonCleanList(object sender, EventArgs e)
		{
			_salaryList.Clear();
		}

		/// <summary>
		/// Удаление позиции.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickВuttonDelete(object sender, EventArgs e)
		{
			if (dataGridViewSpace.SelectedCells.Count != 0)
			{
				foreach (DataGridViewRow row in dataGridViewSpace.SelectedRows)
				{
					_salaryList.Remove(row.DataBoundItem as SalaryBase);
					_listSalaryFilter.Remove(row.DataBoundItem as SalaryBase);
				}
			}
		}

		/// <summary>
		/// Сброс наcтроек фильтра.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickВuttonResetFilter(object sender, EventArgs e)
		{
			CreateTable(_salaryList, dataGridViewSpace);
			_isFilter = false;
			buttonAdd.Enabled = true;
		}

		/// <summary>
		/// Сохранение списка в файл.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickSaveToolStripMenuItem(object sender, EventArgs e)
		{
			if (_salaryList.Count == 0)
			{
				MessageBox.Show("Отсутствуют данные для сохранения.",
					"Данные не сохранены",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var saveFileDialog = new SaveFileDialog
			{
				Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				var path = saveFileDialog.FileName.ToString();
				using (FileStream file = File.Create(path))
				{
					_serializer.Serialize(file, _salaryList);
				}
				MessageBox.Show("Файл успешно сохранён.",
					"Сохранение завершено",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		/// <summary>
		/// Открытие файла со списком.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickOpenToolStripMenuItem(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
			};

			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

			var path = openFileDialog.FileName.ToString();
			try
			{
				using (var file = new StreamReader(path))
				{
					_salaryList = (BindingList<SalaryBase>)
						_serializer.Deserialize(file);
				}

				dataGridViewSpace.DataSource = _salaryList;
				dataGridViewSpace.CurrentCell = null;
				MessageBox.Show("Файл успешно загружен.",
					"Загрузка завершена",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Не удалось загрузить файл.\n" +
					"Файл повреждён или не соответствует формату.",
					$"Ошибка:  {ex.Message}",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Обработчик добавления данных в лист.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="salaryBase">Объект класса SalaryBase.</param>
		private void AddedSalary(object sender, EventArgs salaryBase)
		{
			SalaryAddedEvent addedEventArgs =
				salaryBase as SalaryAddedEvent;

			_salaryList.Add(addedEventArgs?.SalaryBase);
		}

		/// <summary>
		/// Обработчик фильтрации данных.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="salaryList">Список зарплат.</param>
		private void FilteredSalary(object sender, EventArgs salaryList)
		{
			SalaryFilterEvent filterEventArgs =
				salaryList as SalaryFilterEvent;

			_listSalaryFilter = filterEventArgs?.FilteredSalaryList;
			_isFilter = true;
			CreateTable(_listSalaryFilter, dataGridViewSpace);
		}

		private void dataGridViewSpace_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStripDropDownButton_Click(object sender, EventArgs e)
		{

		}
	}
}