using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FigureWindowsForms
{
	//TODO: XML
	public partial class MainForm : Form
	{
		/// <summary>
		/// Список объемов фигур.
		/// </summary>
		private BindingList<FigureBase> _volumeFigureList = new BindingList<FigureBase>();

		/// <summary>
		/// Список отфильтрованных объемов фигур.
		/// </summary>
		private BindingList<FigureBase> _filterVolumeFigureList = new BindingList<FigureBase>();

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
		public MainForm()
		{
			InitializeComponent();
			BackColor = Color.Honeydew;
			dataGridView.BackgroundColor = Color.AliceBlue;
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
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void LoadMainForm(object sender, EventArgs e)
		{
			_volumeFigureList = new BindingList<FigureBase>();
			CreateTable(_volumeFigureList, dataGridView);
		}

		/// <summary>
		/// Метод для работы кнопки Добавить фигуру.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddFigure addFigure = new AddFigure();
			addFigure.FigureAdded += AddedFigure;
			addFigure.Show();
		}

		///// <summary>
		///// Метод обновления состояний кнопок.
		///// </summary>
		//private void UpdatingStatusButtons()
		//{
		//	buttonAdd.Enabled = !_isFilterFormOpen &&
		//		!_isFilter && !_isAddFormOpen;
		//
		//	buttonFilter.Enabled = !_isAddFormOpen &&
		//		!_isFilterFormOpen;
		//
		//	toolStripDropDownButton.Enabled = !_isFilter;
		//	buttonRandomList.Enabled = toolStripDropDownButton.Enabled;
		//}

		/// <summary>
		/// Метод добавления данных в лист.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="salaryBase">Объект класса FigureBase.</param>
		private void AddedFigure(object sender, EventArgs salaryBase)
		{
			VolumeAddedEvent addedEventArgs =
				salaryBase as VolumeAddedEvent;

			_volumeFigureList.Add(addedEventArgs?.FigureBase);
		}

		/// <summary>
		/// Метод для работы кнопки Удалить фигуру.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedCells.Count != 0)
			{
				foreach (DataGridViewRow row in
					dataGridView.SelectedRows)
				{
					if (row.DataBoundItem is FigureBase figure)
					{
						_volumeFigureList.Remove(figure);
						//if (_listSalaryFilter != null
						//	&& _listSalaryFilter.Count > 0)
						//{
						//	_listSalaryFilter.Remove(figure);
						//}
					}
				}
			}
		}


		/// <summary>
		/// Метод для работы кнопки Фильтр.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonFilter_Click(object sender, EventArgs e)
		{
			FilterFigure filterFigure = new FilterFigure(_volumeFigureList);
			filterFigure.FigureFiltered += FilteredFigure;
			filterFigure.Show();
		}

		/// <summary>
		/// Обработчик фильтрации данных.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="figureList">Список ифгур в таблице.</param>
		private void FilteredFigure(object sender, EventArgs figureList)
		{
			FigureFilteredEvent filterEventArgs =
				 figureList as FigureFilteredEvent;
			_filterVolumeFigureList = filterEventArgs?.FilteredValueList;
			_isFilter = true;
			//UpdatingStatusButtons();
			CreateTable(_filterVolumeFigureList, dataGridView);
		}

		/// <summary>
		/// Метод для работы кнопки Очистить список.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDeleteList_Click(object sender, EventArgs e)
		{
			dataGridView.ClearSelection();
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				row.Selected = true;
			}
			foreach (DataGridViewRow row in
					dataGridView.SelectedRows)
			{
				if (row.DataBoundItem is FigureBase salary)
				{
					_volumeFigureList.Remove(salary);
					if (_filterVolumeFigureList != null
						&& _filterVolumeFigureList.Count > 0)
					{
						_filterVolumeFigureList.Remove(salary);
					}
				}
			}
		}

		/// <summary>
		/// Добавление расчета по случайной фигуре.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void buttonRandomList_Click(object sender, EventArgs e)
		{
			_volumeFigureList.Add(RandomFigure.GetRandomFigure());
		}

		/// <summary>
		/// Метод для сброса наcтроек фильтра.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void buttonResertFilter_Click(object sender, EventArgs e)
		{
			CreateTable(_volumeFigureList, dataGridView);
			_isFilter = false;
		}
	}
}
