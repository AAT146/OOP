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
	public partial class ParallelepipedUserControl : UserControl, InterfaceAddFigure
	{
		public ParallelepipedUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Свойство для получения фигуры.
		/// </summary>
		public Parallelepiped Parallelepiped { get; }


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
