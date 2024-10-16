using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab3
{
	/// <summary>
	/// Класс чтения параметров с консоли
	/// </summary>
	public class ReaderFromConcole
	{
		/// <summary>
		/// Метод формирования объекта класса Шар.
		/// </summary>
		/// <returns>Объект класса Шар.</returns>
		public static Ball GetVolumeBall()
		{
			Ball ball = new Ball();
			var actions = new List<Action>()
			{
				() =>
				{
					Console.Write("\tВведите радиус шара: ");
					ball.Radius = Convert.ToDouble(Console.ReadLine());
				},
			};

			ActionHandler(actions);
			return ball;
		}

		/// <summary>
		/// Метод формирование объекта класса Пирамида.
		/// </summary>
		/// <returns>Объект класса Пирамида</returns>
		public static Pyramid GetVolumePyramid() 
		{
			Pyramid pyramid = new Pyramid();
			var actions = new List<Action>()
			{
				() =>
				{
					Console.Write("\tВведите площадь основания пирамиды: ");
					pyramid.AreaOfBase = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("\tВведите высоту пирамиды: ");
					pyramid.Height = Convert.ToDouble(Console.ReadLine());
				},
			};

			ActionHandler(actions);
			return pyramid;
		}

		/// <summary>
		/// Метод формирования объекта класса Параллелепипед.
		/// </summary>
		/// <returns>Объект класса Паралллелепипед.</returns>
		public static Parallelepiped GetVolumeParallelepiped() 
		{
			Parallelepiped parallelepiped = new Parallelepiped();
			var actions = new List<Action>()
			{
				() =>
				{
					Console.Write("\tВведите длину параллелепипеда: ");
					parallelepiped.Length = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("\tВведите ширину параллелепипеда: ");
					parallelepiped.Width = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("\tВведите высоту параллелепипеда: ");
					parallelepiped.Height = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("\tВведите угол между длиной и шириной параллелепипеда: ");
					parallelepiped.AngleLengthWidth = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("\tВведите угол между длиной и высотой параллелепипеда: ");
					parallelepiped.AngleLengthHeight = Convert.ToDouble(Console.ReadLine());
				},
			};

			ActionHandler(actions);
			return parallelepiped;
		}

		/// <summary>
		/// Метод определения объма фигуры.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static FigureBase GetVolumeFigure() 
		{
			FigureBase volume = new Ball();

			var actions = new List<Action>()
			{
				() =>
				{
					Console.WriteLine(
						"\n\tВыберите позицию:\n" +
						"\t1 - Расчет объема шара\n" +
						"\t2 - Расчет объема пирамиды\n" +
						"\t3 - Расчет объема параллелепипеда\n");
				},

				() =>
				{
					ConsoleKeyInfo number = Console.ReadKey();
					switch (number.KeyChar)
					{
						case '1':
						{
							Console.WriteLine("\tРасчет объема шара: ");
							volume = GetVolumeBall();
							break;
						}

						case '2':
						{
							Console.WriteLine("\tРасчет объема пирамиды: ");
							volume = GetVolumePyramid();
							break;
						}

						case '3':
						{
							Console.WriteLine("\tРасчет объема параллелепипеда: ");
							volume = GetVolumeParallelepiped();
							break;
						}

						default:
						{
							throw new ArgumentException(
								"\n\tВыберите для какой фигуры нужно расчитать объем.");
						}
					}
				},
			};

			ActionHandler(actions);

			return volume;
		}

		private static void ActionHandler(List<Action> actions)
		{
			foreach (var action in actions)
			{
				while (true)
				{
					try
					{
						action.Invoke();
						break; 
					}
					catch (FormatException ex)
					{
						HandleFormatException(ex); 
						break; 
					}
					catch (ArgumentException ex)
					{
						HandleArgumentException(ex); 
						break; 
					}
					catch (Exception ex)
					{
						HandleGenericException(ex); 
						break; 
					}
				}
			}
		}

		private static void HandleFormatException(FormatException ex)
		{
			Console.WriteLine("\tНекорректный формат ввода. " + ex.Message);
		}

		private static void HandleArgumentException(ArgumentException ex)
		{
			Console.WriteLine("\tНеверный аргумент. " + ex.Message);
		}

		private static void HandleGenericException(Exception ex)
		{
			Console.WriteLine("\tПроизошла ошибка. " + ex.Message);
		}
	}
}
