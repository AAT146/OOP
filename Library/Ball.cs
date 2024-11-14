using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Класс Шар.
    /// </summary>
    public class Ball : FigureBase
    {
        /// <summary>
        /// Поле радиуса шара.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Ball() 
        { }

        /// <summary>
        /// Конструктор класса Шар.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        public Ball(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Свойсвто поля радиуса шара.
        /// </summary>
        public double Radius 
        {
            get { return _radius; }
            set 
            {
                CheckNumber(value);
				_radius = value; 
            }
        }

		/// <summary>
		/// Тип фигуры.
		/// </summary>
		public override string FigureType
		{
			get
			{
				return $"Шар";
			}
		}

		/// <summary>
		/// Параметры.
		/// </summary>
		public override string Parameters
		{
			get
			{
				return $"Радиус = {Radius}";
			}
		}

		/// <summary>
		/// Расчет объма шара.
		/// </summary>
		public override double Volume()
        {
			return (4 * Math.PI * Math.Pow(Radius, 3)) / 3;
		}
	}
}
