﻿using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab3
{
	/// <summary>
	/// Главный класс программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод программы.
		/// </summary>
		public static void Main()
		{
			while (true) 
			{
				Console.WriteLine("Панель управления программой:\n" +
					"Для начала работы нажмите 1\nДля выходя из программы нажмите 2");
				ConsoleKeyInfo number = Console.ReadKey(true);

				switch (number.KeyChar)
				{
					case '1':
						{
							break;
						}
					case '2':
						{ 
							return; 
						}
					default:
						{
							Console.WriteLine("Ошибка! Введите цифру 1 или 2\n");
							break;
						}
				}

				FigureBase volume = ReaderFromConcole.GetVolumeFigure();
				Console.WriteLine($"Объем выбранной фигуры: " +
					$"{Math.Round(volume.Volume(), 2)}\n");
			}
		}
	}
}
