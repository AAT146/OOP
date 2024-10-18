using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	/// <summary>
	/// Абстрактный класс
	/// </summary>
	public abstract class FigureBase
	{
		/// <summary>
		/// Метод расчета объема фигуры.
		/// </summary>
		public abstract double Volume();

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
