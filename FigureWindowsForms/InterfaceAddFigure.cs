using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureWindowsForms
{
	/// <summary>
	/// Интерфейс для взаимодействия с UserControl.
	/// </summary>
	internal interface InterfaceAddFigure
	{
		//TODO+: XML
		/// <summary>
		/// Свойство, предоставляющее интерфейс.
		/// </summary>
		FigureBase FigureInterface { get; }
	}
}
