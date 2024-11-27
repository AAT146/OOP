using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	/// <summary>
	/// Класс для генерации случайного расчета объема фигуры.
	/// </summary>
	public static class RandomFigure
	{
		/// <summary>
		/// Рандомайзер.
		/// </summary>
		private static Random _random = new Random();

		/// <summary>
		/// Генерация случайного числа double через int.
		/// </summary>
		/// <param name="minValue">Минимальное значение.</param>
		/// <param name="maxValue">Максимальное значение.</param>
		/// <returns>Сгенерированное число типа double.</returns>
		public static double GetRandomDouble(int minValue, int maxValue)
		{
			var randomValue = Convert.ToDouble(
				_random.Next(minValue, maxValue));
			return randomValue;
		}

		/// <summary>
		/// Генерация случайной фигуры Шар.
		/// </summary>
		/// <returns>Параметры расчета фигуры.</returns>
		public static FigureBase RandomBall()
		{
			Ball ball = new Ball
			{
				Radius = GetRandomDouble(1, 100),
			};
			return ball;
		}

		/// <summary>
		/// Генерация случайной фигуры Параллелепипед.
		/// </summary>
		/// <returns>Параметры расчета фигуры.</returns>
		public static FigureBase RandomParallelepiped()
		{
			Parallelepiped parallelepiped = new Parallelepiped
			{
				Length = GetRandomDouble(1, 300),
				Width = GetRandomDouble(1, 200),
				Height = GetRandomDouble(1, 150),
				AngleLengthWidth = GetRandomDouble(1, 179),
				AngleLengthHeight = GetRandomDouble(1, 179)
			};
			return parallelepiped;
		}

		/// <summary>
		/// Генерация случайной фигуры Пирамида.
		/// </summary>
		/// <returns>Параметры расчета фигуры.</returns>
		public static FigureBase RandomPyramid()
		{
			Pyramid pyramid = new Pyramid
			{
				AreaOfBase = GetRandomDouble(1, 30),
				Height = GetRandomDouble(1, 200)
			};
			return pyramid;
		}

		/// <summary>
		/// Генерация случайного расчета объема.
		/// </summary>
		/// <returns></returns>
		public static FigureBase GetRandomFigure()
		{
			switch (_random.Next(0, 3))
			{
				case 0:
				{
					return RandomBall();
				}
				case 1:
				{
					return RandomParallelepiped();
				}
				default:
				{
					return RandomPyramid();
				}
			}
		}
	}
}
