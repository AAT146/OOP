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

namespace FigureWindowsForms
{
	public partial class FilterForm : Form
	{
		/// <summary>
		/// Исходный список расчитанных фигур.
		/// </summary>
		private readonly BindingList<FigureBase> _calculatedFigureList;

		/// <summary>
		/// Отфильтрованный список расчитанных фигур.
		/// </summary>
		private BindingList<FigureBase> _filteredCalculatedFigureList;

		/// <summary>
		/// Событие на фильтрацию списка.
		/// </summary>
		public EventHandler FigureFiltered;

		/// <summary>
		/// Конструктор FilterFigure.
		/// </summary>
		/// <param name="figureList">Список объемов фигур для фильтрации.</param>
		public FilterForm(BindingList<FigureBase> figureList)
		{
			InitializeComponent();
			_calculatedFigureList = figureList;
			BackColor = Color.Honeydew;
			StartPosition = FormStartPosition.CenterScreen;
			_textBoxValue.Enabled = false;

			_textBoxValue.KeyPress += new KeyPressEventHandler(
				CheckTextBox.TextBoxCheck);

			DeactivateElements();

			_checkBoxPyramid.CheckedChanged += UpdateFilterState;
			_checkBoxParallelepiped.CheckedChanged += UpdateFilterState;
			_checkBoxBall.CheckedChanged += UpdateFilterState;
			_checkBoxVolume.CheckedChanged += ToggleTextBox;
		}

		/// <summary>
		/// Активирация или деактивация элементов управления
		/// в зависимости от состояния чекбоксов.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void UpdateFilterState(object sender, EventArgs e)
		{
			// Проверяем, выбран ли хотя бы один CheckBox
			bool anyChecked = _checkBoxPyramid.Checked
							  || _checkBoxParallelepiped.Checked
							  || _checkBoxBall.Checked
							  || _checkBoxVolume.Checked;
		}

		/// <summary>
		/// Деактивация всех элементов управления на форме.
		/// </summary>
		private void DeactivateElements()
		{
			_checkBoxVolume.Enabled = true;
			_textBoxValue.Enabled = false;
		}

		/// <summary>
		/// Включение/выключение TextBox для ввода значения.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ToggleTextBox(object sender, EventArgs e)
		{
			_textBoxValue.Enabled = _checkBoxVolume.Checked;
		}

		/// <summary>
		/// Фильтрация списка по основному условию.
		/// </summary>
		/// <param name="figureList">Лист подлежащий фильтрации.</param>
		/// <param name="filteredFigureList">Список, в который будут добавлены
		/// отфильтрованные значения.</param>
		/// <param name="figureType">Тип отфильтрованных значений.</param>
		private static void FilterByType(
			BindingList<FigureBase> figureList,
			BindingList<FigureBase> filteredFigureList,
			Type figureType)
		{
			foreach (var figure in figureList)
			{
				if (figureType == figure.GetType())
				{
					filteredFigureList.Add(figure);
				}
			}
		}

		/// <summary>
		/// Фильтрация списка по дополнительному условию.
		/// </summary>
		/// <param name="filteredFigureList">Лист подлежащий фильтрации.</param>
		/// <param name="initialValue">Значение объема фигуры.</param>
		/// <returns>Отфильтрованный список.</returns>
		private static BindingList<FigureBase> FilterByValue(
			BindingList<FigureBase> filteredFigureList, double initialValue)
		{
			BindingList<FigureBase> filteredList = new BindingList<FigureBase>();
			foreach (var item in filteredFigureList)
			{
				if (item.Volume == initialValue)
				{
					filteredList.Add(item);
				}
			}
			return filteredList;
		}

		/// <summary>
		/// Фильтрация списка.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ButtonFoundClick(object sender, EventArgs e)
		{
			_filteredCalculatedFigureList = new BindingList<FigureBase>();

			BindingList<FigureBase> tempFilteredList =
				new BindingList<FigureBase>();

			if (_checkBoxBall.Checked)
			{
				FilterByType(_calculatedFigureList,
					tempFilteredList,
					typeof(Ball));
			}

			if (_checkBoxParallelepiped.Checked)
			{
				FilterByType(_calculatedFigureList,
					tempFilteredList,
					typeof(Parallelepiped));
			}

			if (_checkBoxPyramid.Checked)
			{
				FilterByType(_calculatedFigureList,
					tempFilteredList,
					typeof(Pyramid));
			}

			if (_checkBoxVolume.Checked)
			{
				if (!string.IsNullOrEmpty(_textBoxValue.Text))
				{
					tempFilteredList =
						FilterByValue(tempFilteredList,
						Convert.ToDouble(_textBoxValue.Text));
				}
				else
				{
					MessageBox.Show("Введите значение объёма фигуры, см^3.", "Предупреждение",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			foreach (var salary in _calculatedFigureList)
			{
				if (tempFilteredList.Contains(salary))
				{
					_filteredCalculatedFigureList.Add(salary);
				}
			}

			if (_filteredCalculatedFigureList.Count == 0
				|| _filteredCalculatedFigureList is null)
			{
				MessageBox.Show("Совпадений не найдено.", "Информация",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			FigureFiltered?.Invoke(this, new FigureFilteredEvent(
				_filteredCalculatedFigureList));
		}
	}
}
