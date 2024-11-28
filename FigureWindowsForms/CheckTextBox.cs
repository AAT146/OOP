using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureWindowsForms
{
	/// <summary>
	/// Класс для проверки вводимых пользователем данных.
	/// </summary>
	static public class CheckTextBox
	{
		/// <summary>
		/// Проверка данных вводимых в TextBox.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		static public void TextBoxCheck(object sender, KeyPressEventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
				&& e.KeyChar != ',')
			{
				e.Handled = true;
			}

			if (e.KeyChar == ',' && textBox.Text.Contains(","))
			{
				e.Handled = true;
			}

			if (e.KeyChar == '0' && string.IsNullOrEmpty(textBox.Text.Trim('0')))
			{
				e.Handled = true;
			}
		}
	}
}
