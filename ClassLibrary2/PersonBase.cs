using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryPerson
{
	/// <summary>
	/// Класс Персона.
	/// </summary>
	public abstract class PersonBase
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
			set 
			{
				_surname = ConvertRegister(CheckStringSurname(value));
			}
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
			set 
			{
                _name = ConvertRegister(CheckStringName(value));
				CheckLanguageLastFirstName(value, _surname);
			}
		}

		/// <summary>
		/// Возраст персоны.
		/// </summary>
		private int _age;

		/// <summary>
		/// Минимальный возраст персоны.
		/// 
		/// </summary>
		public virtual int MinAge { get; } = 1;
		
		/// <summary>
		/// Максимальный возраст персоны.
		/// </summary>
		public virtual int MaxAge { get; } = 90;

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
		/// Свойство для считывания полня _gender класса Gender.
		/// </summary>
		/// Перенести данную проверку в Консоль
		public Gender Gender { get; set; }

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public PersonBase() : this("Фамилия", "Имя", 1, Gender.Female)
		{ }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="surname">Фамилия персоны.</param>
		/// <param name="name">Имя персоны.</param>
		/// <param name="age">Возраст персоны.</param>
		/// <param name="gender">Пол персоны.</param>
		public PersonBase(string surname, string name, int age, Gender gender)
		{
			_surname = surname;
			_name = name;
			_age = age;
			Gender = gender;
		}

		/// <summary>
		/// Метод: возврат информации об объекте класса Person.
		/// </summary>
		/// <returns>Строка с данными полей.</returns>
		public virtual string GetInfo() 
		{
			return ($"Фамилия: {Surname}, Имя: {Name}, Возраст: {Age}, Пол: {Gender}.\n");
		}

		/// <summary>
		/// Метод: проверка на пустую строку.
		/// </summary>
		/// <param surname="value">Имя или фамилия персоны.</param>
		/// <returns>Имя или фамилия.</returns>
		/// <exception cref="ArgumentException">Исключение при
		/// null, пустой строке и не допустимых знаках.</exception>
		public static string CheckStringSurname(string value) 
		{
			Regex rg1 = new Regex(@"(^[а-яА-Я\-]+$)");
			Regex rg2 = new Regex(@"(^[a-zA-Z\-]+$)");

			if (string.IsNullOrEmpty(value)) 
			{
				throw new ArgumentException("Ошибка! Заполните параметр.");
			}
			if (!rg1.IsMatch(value) && !rg2.IsMatch(value))
			{
				throw new ArgumentException("Не верно! Используйте только буквы " +
					"одного языка или буквы одного языка и знак -.");
			}

			return value;
		}

		/// <summary>
		/// Метод: проверка на пустую строку.
		/// </summary>
		/// <param name="value">Имя персоны.</param>
		/// <returns>Имя или фамилия.</returns>
		/// <exception cref="ArgumentException">Исключение при
		/// null, пустой строке и не допустимых знаках.</exception>
		public static string CheckStringName(string value)
		{
			Regex rg1 = new Regex(@"(^[а-яА-Я]+$)");
			Regex rg2 = new Regex(@"(^[a-zA-Z]+$)");

			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Ошибка! Заполните параметр.");
			}
			if (!rg1.IsMatch(value) && !rg2.IsMatch(value))
			{
				throw new ArgumentException("Не верно! Используйте только буквы " +
					"одного языка.");
			}

			return value;
		}

		/// <summary>
		/// Метод: преобразование регистров с учетом двойной фамилии.
		/// </summary>
		/// <param name="value">Фамилия.</param>
		/// <returns>Фамилия с правильными регистрами.</returns>
		public static string ConvertRegister(string surname) 
		{
			Regex regex = new Regex(@"[-]");
			if (regex.IsMatch(surname))
			{
				string[] partsurName = surname.Split('-');
				string part1 = partsurName[0];
				string part2 = partsurName[1];
				part1 = char.ToUpper(part1[0]) + part1.Substring(1).ToLower();
				part2 = char.ToUpper(part2[0]) + part2.Substring(1).ToLower();
				surname = part1 + "-" + part2;
			}
			else 
			{
				surname = char.ToUpper(surname[0]) + surname.Substring(1).ToLower();
			}

			return surname;
		}

		/// <summary>
		/// Метод: Проверка слов на язык.
		/// </summary>
		/// <param name="word">Слово.</param>
		/// <returns>Возврат используемого языка.</returns>
		/// <exception cref="ArgumentException">Возврат сообщения
		/// об ошибке.</exception>
		public static Language CheckLanguage(string word)
		{
			Regex russian = new Regex(@"[а-яА-Я]");
			Regex english = new Regex(@"[a-zA-Z]");

			if (russian.IsMatch(word)) 
			{
				return Language.Russian;
			}
			else if (english.IsMatch(word))
			{
				return Language.English;
			}
			else 
			{
				throw new ArgumentException("Ошибка! Введите в поле Имя и Фамилия" +
					" только английские или русские буквы.");
			}
		}

		/// <summary>
		/// Метод: проверка на совпадение языка фамилии и имени.
		/// </summary>
		/// <param name="surname">Фамилия.</param>
		/// <param name="name">Имя.</param>
		/// <exception cref="ArgumentException">Возврат сообщения
		/// о не совпадении языков.</exception>
		public static void CheckLanguageLastFirstName(string surname, string name)
		{
			Language surnameLanguage = CheckLanguage(surname);
			Language nameLanguage = CheckLanguage(name);

			if (nameLanguage != surnameLanguage) 
			{
				throw new ArgumentException("Ошибка! Язык имени и фамилии" +
					" должен совпадать.");
			}
		}
	}
}
