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
	public partial class PyramidUserControl : UserControl, InterfaceAddFigure
	{
		public PyramidUserControl()
		{
			InitializeComponent();
		}

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
