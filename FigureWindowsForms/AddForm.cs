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
		/// Словарь взаимодействия с UserControls.
		/// </summary>
		private Dictionary<RadioButton, UserControl> _figureAddableControls;

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

			_figureAddableControls = new Dictionary<RadioButton, UserControl>()
			{
				{ _radioButtonBall, _ballUserControl },
				{ _radioButtonParallelepiped , _parallelepipedUserControl },
				{ _radioButtonPyramid, _pyramidUserControl }
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
				foreach (var element in _figureAddableControls)
				{
					if (element.Value.Visible)
					{
						FigureAdded?.Invoke(this,
							new VolumeAddedEvent(((InterfaceAddFigure)element.Value).FigureInterface));
					}
				}
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
		///  Метод обработки событий от UserControl для форм.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ChangeUserControlVisibility(object sender, EventArgs e)
		{
			foreach (var element in _figureAddableControls)
			{
				element.Value.Visible = element.Key == sender;
			}
		}
	}
}
