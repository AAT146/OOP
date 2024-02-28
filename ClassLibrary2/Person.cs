using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	/// <summary>
	/// Класс Персона.
	/// </summary>
	public class Person
	{
		/// <summary>
		/// Фамилия персоны.
		/// </summary>
		private string _surname;

		/// <summary>
		/// Имя персоны.
		/// </summary>
		private string _name;

		/// <summary>
		/// Возраст прсоны.
		/// </summary>
		private int _age;

		/// <summary>
		/// Пол персоны.
		/// </summary>
		private Gender _gender;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="surname">Фамилия персоны.</param>
		/// <param name="name">Имя персоны.</param>
		/// <param name="age">Возраст персоны.</param>
		/// <param name="gender">Пол персоны.</param>
		public Person(string surname, string name, int age, Gender gender)
		{
			_surname = surname;
			_name = name;
			_age = age;
			_gender = gender;
		}
	}
}
