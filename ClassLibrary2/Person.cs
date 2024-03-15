using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryPerson
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
		/// Свойство для считывания полня _surname класса Person.
		/// </summary>
		public string Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}

		/// <summary>
		/// Имя персоны.
		/// </summary>
		private string _name;

		/// <summary>
		/// Свойство для считывания полня _name класса Person.
		/// </summary>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Возраст персоны.
		/// </summary>
		private int _age;

		/// <summary>
		/// Минимальный возраст персоны.
		/// </summary>
		public const int MinAge = 1;
		
		/// <summary>
		/// Максимальный возраст персоны.
		/// </summary>
		public const int MaxAge = 90;

		/// <summary>
		/// Свойство для считывания полня _age класса Persom.
		/// </summary>
		public int Age 
		{
			get { return _age; }
			set 
			{
				if (value < MinAge || value > MaxAge) 
				{
					throw new ArgumentException("Ошибка!" + 
						$" Возраст от {MinAge} до {MaxAge}");
				}
				_age = value;
			} 
		}

		/// <summary>
		/// Пол персоны.
		/// </summary>
		private Gender _gender;

		/// <summary>
		/// Свойство для считывания полня _gender класса Gender.
		/// </summary>
		/// Перенести данную проверку в Консоль
		public Gender Gender { get; set; }

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Person() : this("Фамилия", "Имя", MinAge, Gender.Female)
		{ }

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

		/// <summary>
		/// Метод: возврат информации об объекте класса Person.
		/// </summary>
		/// <returns>Строка с данными полей.</returns>
		public string GetInfo() 
		{
			return ($"Фамилия: {Surname}, Имя: {Name}, Возраст: {Age}, Пол: {Gender}.\n");
		}

		//TODO + : Вынести в отдельный класс генерацию случайной персоны

		

		//TODO + : RSDN
		/// <summary>
		/// Метод: проверка на пустую строну.
		/// </summary>
		/// <param name="value">Имя или фамилия персоны.</param>
		/// <returns>Имя или фамилия.</returns>
		/// <exception cref="ArgumentException">Исключение при
		/// null или пустой строке.</exception>
		public static string CheckString(string value) 
		{
			//TODO + : RSDN
			if (string.IsNullOrEmpty(value)) 
			{
				throw new ArgumentException("Ошибка! Заполните параметр.");
			}
			return value;
		}

		//TODO + : rename
		/// <summary>
		/// Метод: преобразование регистров с учетом двойного 
		/// имени (фамилии).
		/// </summary>
		/// <param name="value">Имя или фамилия.</param>
		/// <returns>Скоректированное имя (фамилия)</returns>
		public static string ConvertRegister(string value) 
		{
			Regex regex = new Regex(@"[-]");
			if (regex.IsMatch(value))
			{
				//TODO + : rename
				string[] arrValue = value.Split('-');
				string value1 = arrValue[0];
				string value2 = arrValue[1];
				value1 = char.ToUpper(value1[0]) + value1.Substring(1).ToLower();
				value2 = char.ToUpper(value2[0]) + value2.Substring(1).ToLower();
				value = value1 + "-" + value2;
			}
			else 
			{
				//TODO + : {}
				value = char.ToUpper(value[0]) + value.Substring(1).ToLower();
			}
			return value;
		}
	}
}
