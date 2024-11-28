using Library;
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

namespace FigureWindowsForms
{
	/// <summary>
	/// Класс интерфейса Пирамида.
	/// </summary>
	public partial class PyramidUserControl : UserControl, InterfaceAddFigure
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public PyramidUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Чтение данных.
		/// </summary>
		public FigureBase FigureInterface
		{
			get
			{
				return new Pyramid()
				{
					AreaOfBase = Convert.ToDouble(_textBoxAreaOfBase.Text),
					Height = Convert.ToDouble(_textBoxAreaOfBase.Text),
				};
			}
		}
	}
}
