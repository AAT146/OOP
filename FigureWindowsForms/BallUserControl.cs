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
	//TODO+: добавить интерфейс для возможности обработки этих контролов по ссылке на интерфейс
	/// <summary>
	/// Класс интерфейса Шар.
	/// </summary>
	public partial class BallUserControl : UserControl, InterfaceAddFigure
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public BallUserControl()
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
				return new Ball()
				{
					Radius = Convert.ToDouble(_textBoxRadius.Text),
				};
			}
		}
	}
}
