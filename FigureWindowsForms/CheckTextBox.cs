using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureWindowsForms
{
	static public class CheckTextBox
	{
		/// <summary>
		/// Проверка данных вводимых в textBox.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		static public void TextBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			Type dataType = textBox.Tag as Type;

			if (dataType == typeof(int))
			{
				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			else if (dataType == typeof(double))
			{
				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
					&& e.KeyChar != ',')
				{
					e.Handled = true;
				}

				if (e.KeyChar == ',' && textBox.Text.Contains(","))
				{
					e.Handled = true;
				}
			}
			if (e.KeyChar == '0' && string.IsNullOrEmpty(textBox.Text.Trim('0')))
			{
				e.Handled = true;
			}
		}
	}
}
