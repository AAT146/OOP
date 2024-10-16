﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	/// <summary>
	/// Класс Пирамида.
	/// </summary>
	public class Pyramid : FigureBase
	{
		/// <summary>
		/// Поле площади основания пирамиды.
		/// </summary>
		private double _areaOfBase;

		/// <summary>
		/// Поле высаты пирамиды.
		/// </summary>
		private double _height;

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Pyramid()
		{ }

		/// <summary>
		/// Конструктор класса Шар.
		/// </summary>
		/// <param name="radius">Радиус шара.</param>
		public Pyramid(double areaOfBase, double height)
		{
			_areaOfBase = areaOfBase;
			_height = height;
		}

		/// <summary>
		/// Свойсвто поля площади основания пирамиды.
		/// </summary>
		public double AreaOfBase
		{
			get { return _areaOfBase; }
			set { _areaOfBase = value; }
		}

		/// <summary>
		/// Свойсвто поля высоты пирамиды.
		/// </summary>
		public double Height
		{
			get { return _height; }
			set { _height = value; }
		}

		/// <summary>
		/// Расчет объма пирамиды.
		/// </summary>
		public override double Volume => (1 / 3) * AreaOfBase * Height;
	}
}
