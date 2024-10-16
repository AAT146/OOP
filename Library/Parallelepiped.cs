using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	/// <summary>
	/// Класс Параллелепипед.
	/// </summary>
	public class Parallelepiped : FigureBase
	{
		/// <summary>
		/// Поле длины параллелепипеда.
		/// </summary>
		private double _length;

		/// <summary>
		/// Поле ширины параллелепипеда.
		/// </summary>
		private double _width;

		/// <summary>
		/// Поле высоты параллелепипеда.
		/// </summary>
		private double _height;

		/// <summary>
		/// Поле угла между длиной и шириной параллелепипеда.
		/// </summary>
		private double _angleLengthWidth;

		/// <summary>
		/// Поле угла между длиной и высотой параллелепипеда.
		/// </summary>
		private double _angleLengthHeight;

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Parallelepiped()
		{ }

		/// <summary>
		/// Конструктор класса Параллелепипед.
		/// </summary>
		/// <param name="length">Длина параллелепипеда.</param>
		/// <param name="width">Ширина параллелепипеда.</param>
		/// <param name="height">Высота параллелепипеда.</param>
		public Parallelepiped(double length, double width, double height)
		{
			_length = length;
			_width = width;
			_height = height;
		}

		/// <summary>
		/// Свойсвто поля длины параллелепипеда.
		/// </summary>
		public double Length
		{
			get { return _length; }
			set { _length = value; }
		}

		/// <summary>
		/// Свойсвто поля ширины параллелепипеда.
		/// </summary>
		public double Width
		{
			get { return _width; }
			set { _width = value; }
		}

		/// <summary>
		/// Свойсвто поля высоты параллелепипеда.
		/// </summary>
		public double Height
		{
			get { return _height; }
			set { _height = value; }
		}

		/// <summary>
		/// Свойство поля угла между длиной и шириной параллелепипеда.
		/// </summary>
		public double AngleLengthWidth
		{
			get { return _angleLengthWidth; }
			set { _angleLengthWidth = value; }
		}

		/// <summary>
		/// Свойство поля ушла между длиной и высотой парарллелепипеда.
		/// </summary>
		public double AngleLengthHeight
		{
			get { return _angleLengthHeight; }
			set { _angleLengthHeight = value; }
		}

		/// <summary>
		/// Расчет объма параллелепипеда.
		/// </summary>
		public override double Volume => Length * Width * Height * 
			Math.Sin(AngleLengthWidth * (Math.PI / 180)) * 
			Math.Sin(AngleLengthHeight * (Math.PI / 180));
	}
}
