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
					Console.Write("Введите радиус шара: ");
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
					Console.Write("Введите площадь основания пирамиды: ");
					pyramid.AreaOfBase = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("Введите высоту пирамиды: ");
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
					Console.Write("Введите длину параллелепипеда: ");
					parallelepiped.Length = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("Введите ширину параллелепипеда: ");
					parallelepiped.Width = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("Введите высоту параллелепипеда: ");
					parallelepiped.Height = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("Введите угол между длиной и шириной параллелепипеда: ");
					parallelepiped.AngleLengthWidth = Convert.ToDouble(Console.ReadLine());
				},

				() =>
				{
					Console.Write("Введите угол между длиной и высотой параллелепипеда: ");
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
						"Выберите позицию:\n" +
						"1 - Расчет объема шара\n" +
						"2 - Расчет объема пирамиды\n" +
						"3 - Расчет объема параллелепипеда\n");
				},

				() =>
				{
					ConsoleKeyInfo number = Console.ReadKey();
					switch (number.KeyChar)
					{
						case '1':
						{
							Console.WriteLine("\t\nРасчет объема шара: ");
							volume = GetVolumeBall();
							break;
						}

						case '2':
						{
							Console.WriteLine("\t\nРасчет объема пирамиды: ");
							volume = GetVolumePyramid();
							break;
						}

						case '3':
						{
							Console.WriteLine("\t\nРасчет объема параллелепипеда: ");
							volume = GetVolumeParallelepiped();
							break;
						}

						default:
						{
							throw new ArgumentException(
								"\nВыберите для какой фигуры нужно расчитать объем.");
						}
					}
				},
			};

			ActionHandler(actions);

			return volume;
		}

		private static void ActionHandler(List<Action> actions)
		{
			// Перебираем все действия
			foreach (var action in actions)
			{
				// Бесконечно пытаемся выполнить действие, пока не удастся
				while (true)
				{
					try
					{
						// Выполняем действие
						action.Invoke();
						break; // Если успешно, выходим из цикла
					}
					catch (FormatException ex)
					{
						HandleFormatException(ex); // Обработка исключения формата
						break; // После обработки ошибки выходим из цикла
					}
					catch (ArgumentException ex)
					{
						HandleArgumentException(ex); // Обработка исключения аргумента
						break; // После обработки ошибки выходим из цикла
					}
					catch (Exception ex)
					{
						HandleGenericException(ex); // Обработка других исключений
						break; // После обработки ошибки выходим из цикла
					}
				}
			}
		}

		private static void HandleFormatException(FormatException ex)
		{
			Console.WriteLine("Некорректный формат ввода: " + ex.Message);
		}

		private static void HandleArgumentException(ArgumentException ex)
		{
			Console.WriteLine("Неверный аргумент: " + ex.Message);
		}

		private static void HandleGenericException(Exception ex)
		{
			Console.WriteLine("Произошла ошибка: " + ex.Message);
		}
	}
}
