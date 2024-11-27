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
	public partial class BallUserControl : UserControl, InterfaceAddFigure
	{
		public BallUserControl()
		{
			InitializeComponent();
		}

		public FigureBase FigureInterface
		{
			get
			{
				return new Ball()
				{
					Radius = Convert.ToDouble(textBoxRadius.Text),
				};
			}
		}
	}
}
