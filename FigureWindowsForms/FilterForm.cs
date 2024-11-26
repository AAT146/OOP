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
			textBoxValue.Enabled = false;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;

			radioButtonPyramid.CheckedChanged += ActivateElements;
			radioButtonParallelepiped.CheckedChanged += ActivateElements;
			radioButtonBall.CheckedChanged += ActivateElements;
			radioButtonValue.CheckedChanged += ActivateElements;
		}

		/// <summary>
		/// Активирация или деактивация элементов управления
		/// в зависимости от состояния чекбоксов.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ActivateElements(object sender, EventArgs e)
		{
			bool activate = radioButtonPyramid.Checked
				|| radioButtonParallelepiped.Checked
				|| radioButtonBall.Checked
				|| radioButtonValue.Checked;

			textBoxValue.Enabled = activate;
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

		//TODO: RSDN
		/// <summary>
		/// Фильтрация списка.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void buttonFound_Click(object sender, EventArgs e)
		{
			_filteredCalculatedFigureList = new BindingList<FigureBase>();

			BindingList<FigureBase> tempFilteredList =
				new BindingList<FigureBase>();

			if (radioButtonBall.Checked)
			{
				FilterByType(_calculatedFigureList,
					tempFilteredList,
					typeof(Ball));
			}

			if (radioButtonParallelepiped.Checked)
			{
				FilterByType(_calculatedFigureList,
					tempFilteredList,
					typeof(Parallelepiped));
			}

			if (radioButtonPyramid.Checked)
			{
				FilterByType(_calculatedFigureList,
					tempFilteredList,
					typeof(Pyramid));
			}

			if (radioButtonValue.Checked)
			{
				if (!string.IsNullOrEmpty(textBoxValue.Text))
				{
					tempFilteredList =
						FilterByValue(tempFilteredList,
						Convert.ToDouble(textBoxValue.Text));
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
