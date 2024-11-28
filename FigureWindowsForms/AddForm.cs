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
	/// <summary>
	/// Форма Добавить Фигуру.
	/// </summary>
	public partial class AddForm : Form
	{
		/// <summary>
		/// Поле для обработки события добавления.
		/// </summary>
		public EventHandler FigureAdded;

		/// <summary>
		/// Список UserControls.
		/// </summary>
		private List<InterfaceAddFigure> _figureAddUserControls;

		/// <summary>
		/// Конструктор AddForm.
		/// </summary>
		public AddForm()
		{
			InitializeComponent();
			BackColor = Color.Honeydew;
			StartPosition = FormStartPosition.CenterScreen;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;

			_ballUserControl._textBoxRadius.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_parallelepipedUserControl._textBoxLength.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_parallelepipedUserControl._textBoxWidth.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_parallelepipedUserControl._textBoxHeight.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_parallelepipedUserControl._textBoxAngleLengthWidth.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_parallelepipedUserControl._textBoxAngleLengthHeight.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_pyramidUserControl._textBoxAreaOfBase.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_pyramidUserControl._textBoxPyramidHeight.KeyPress += new
				KeyPressEventHandler(CheckTextBox.TextBoxCheck);

			_figureAddUserControls = new List<InterfaceAddFigure>()
			{
				_ballUserControl,
				_parallelepipedUserControl,
				_pyramidUserControl,
			};
		}

		/// <summary>
		/// Кнопка Добавить объём фигуры.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ButtonClick(object sender, EventArgs e)
		{
			try
			{
				FigureBase figureBase = null;
				
				foreach (var userControl in _figureAddUserControls)
				{
					if (((UserControl)userControl).Visible)
					{
						figureBase = userControl.FigureInterface;
					}
				}

				FigureAdded?.Invoke(this, new VolumeAddedEvent(figureBase));
			}
			catch (ArgumentException exeption)
			{
				MessageBox.Show($"{exeption.Message}", "Ошибка ввода",
					MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch
			{
				MessageBox.Show("Введите данные.", "Предупреждение",
					MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// Загрузка формы данных Шар.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void RadioButtonCheckedChanged(object sender, EventArgs e)
		{
			_ballUserControl.Visible = true;
			_parallelepipedUserControl.Visible = false;
			_pyramidUserControl.Visible = false;
		}

		/// <summary>
		/// Загрузка формы данных Параллелепипед.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void RadioButtonParallelepipedCheckedChanged(object sender, EventArgs e)
		{
			_ballUserControl.Visible = false;
			_parallelepipedUserControl.Visible = true;
			_pyramidUserControl.Visible = false;
		}

		/// <summary>
		/// Загрузка формы данных Пирамида.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void RadioButtonPyramidaCheckedChanged(object sender, EventArgs e)
		{
			_ballUserControl.Visible = false;
			_parallelepipedUserControl.Visible = false;
			_pyramidUserControl.Visible = true;
		}
	}
}
