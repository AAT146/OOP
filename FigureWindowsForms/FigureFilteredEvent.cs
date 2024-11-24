using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureWindowsForms
{
	/// <summary>
	/// Класс отдает данные событию при фильтрации фигуры.
	/// </summary>
	internal class FigureFilteredEvent : EventArgs
	{
		/// <summary>
		/// Свойство для получения отфильтрованного списка.
		/// </summary>
		public BindingList<FigureBase> FilteredValueList { get; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="filterValueList">Отфильтрованный список.</param>
		/// <exception cref="ArgumentNullException">Проверка списка
		/// на null</exception>
		public FigureFilteredEvent(BindingList<FigureBase>
			filterValueList)
		{
			if (filterValueList == null)
			{
				throw new ArgumentNullException();
			}

			FilteredValueList = filterValueList;
		}
	}
}
