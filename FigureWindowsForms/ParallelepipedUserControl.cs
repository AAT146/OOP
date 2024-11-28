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
	/// Класс интерфейса Параллелепипед.
	/// </summary>
	public partial class ParallelepipedUserControl : UserControl, InterfaceAddFigure
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public ParallelepipedUserControl()
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
				return new Parallelepiped()
				{
					Length = Convert.ToDouble(_textBoxLength.Text),
					Width = Convert.ToDouble(_textBoxWidth.Text),
					Height = Convert.ToDouble(_textBoxHeight.Text),
					AngleLengthWidth = Convert.ToDouble(_textBoxAngleLengthWidth.Text),
					AngleLengthHeight = Convert.ToDouble(_textBoxAngleLengthHeight.Text),
				};
			}
		}
	}
}
