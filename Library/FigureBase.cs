using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library
{
	/// <summary>
	/// Абстрактный класс
	/// </summary>
	/// [XmlInclude(typeof(Circle))]
	[XmlInclude(typeof(Ball))]
	[XmlInclude(typeof(Parallelepiped))]
	[XmlInclude(typeof(Pyramid))]
	public abstract class FigureBase
	{
		/// <summary>
		/// Тип фигуры.
		/// </summary>
		[DisplayName("Тип фигуры")]
		public virtual string FigureType { get; }

		/// <summary>
		/// Параметры фигуры.
		/// </summary>
		[DisplayName("Заданные параметры")]
		public virtual string Parameters { get; }

		/// <summary>
		/// Метод расчёта объема фигуры.
		/// </summary>
		/// <returns>Объем.</returns>
		[DisplayName("Объем фигуры, м^3")]
		public abstract double Volume { get; }

		/// <summary>
		/// Метод проверки заданного числа.
		/// </summary>
		/// <param name="number">Заданное число.</param>
		/// <returns>Проверенное число.</returns>
		/// <exception cref="ArgumentException">Исключение,
		/// если заданое число отрицательное</exception>
		protected static double CheckNumber(double number)
		{
			if (number <= 0)
			{
				throw new ArgumentException("Аргумент должен быть положительным.");
			}
			else
			{
				return number;
			}
		}

		/// <summary>
		/// Метод проверки заданного числа.
		/// </summary>
		/// <param name="number">Значение угла.</param>
		/// <returns>Проверенное число.</returns>
		/// <exception cref="ArgumentException">Исключение,
		/// если заданное число не входит в диапазон.</exception>
		protected static double CheckNumberAngle(double number)
		{
			if (number <= 0 || number >= 180)
			{
				throw new ArgumentException("Аргумент должет быть больше 0, но меньше 180.");
			}
			else
			{
				return number;
			}
		}
	}
}
