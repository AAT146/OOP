using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureWindowsForms
{
	/// <summary>
	/// Класс отдаёт данные событию при добавлении фигуры.
	/// </summary>
	internal class VolumeAddedEvent : EventArgs
	{
		/// <summary>
		/// Свойство для получения добавленной ЗП.
		/// </summary>
		public FigureBase FigureBase { get; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="figureBase">Добавленная фигура.</param>
		/// <exception cref="ArgumentNullException">Проверка фигуры
		/// на null.</exception>
		public VolumeAddedEvent(FigureBase figureBase)
		{
			if (figureBase == null)
			{
				throw new ArgumentNullException();
			}

			FigureBase = figureBase;
		}
	}
}
