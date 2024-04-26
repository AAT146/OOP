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
			set 
			{
				//TODO +: проверка на допустимые символы
				_surname = Check2SurName(ConvertRegister(CheckStringSurname(value)));
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
                //TODO +: проверка на допустимые символы
                _name = ConvertRegister(CheckStringName(value));
				CheckLangSurName(value, _surname);
			}
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
			Gender = gender;
		}

		/// <summary>
		/// Метод: возврат информации об объекте класса Person.
		/// </summary>
		/// <returns>Строка с данными полей.</returns>
		public string GetInfo() 
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
			Regex rg1 = new Regex(@"(^[а-яА-Яa-zA-Z\-]+$)");

			if (string.IsNullOrEmpty(value)) 
			{
				throw new ArgumentException("Ошибка! Заполните параметр.");
			}
			if (!rg1.IsMatch(value))
			{
				throw new ArgumentException("Не верно! Используйте только буквы " +
					"или буквы и знак -.");
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
			Regex rg1 = new Regex(@"(^[а-яА-Яa-zA-Z]+$)");

			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Ошибка! Заполните параметр.");
			}
			if (!rg1.IsMatch(value))
			{
				throw new ArgumentException("Внимание! Имя состоит только из букв " +
					"и не может быть составным.");
			}

			return value;
		}

		//TODO +: 
		/// <summary>
		/// Метод: преобразование регистров с учетом двойного 
		/// имени (фамилии).
		/// </summary>
		/// <param name="surName">Имя или фамилия.</param>
		/// <returns>Скоректированное имя (фамилия)</returns>
		public static string ConvertRegister(string surName) 
		{
			Regex regex = new Regex(@"[-]");
			if (regex.IsMatch(surName))
			{
				string[] partsurName = surName.Split('-');
				string part1 = partsurName[0];
				string part2 = partsurName[1];
				part1 = char.ToUpper(part1[0]) + part1.Substring(1).ToLower();
				part2 = char.ToUpper(part2[0]) + part2.Substring(1).ToLower();
				surName = part1 + "-" + part2;
			}
			else 
			{
				surName = char.ToUpper(surName[0]) + surName.Substring(1).ToLower();
			}

			return surName;
		}

		/// <summary>
		/// Метод: Проверка слов на язык.
		/// </summary>
		/// <param name="word">Слово.</param>
		/// <returns>Возврат используемого языка.</returns>
		/// <exception cref="ArgumentException">Возврат сообщения
		/// об ошибке.</exception>
		public static Language CheckLang(string word)
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
		public static void CheckLangSurName(string surname, string name)
		{
			Language surnameLang = CheckLang(surname);
			Language nameLang = CheckLang(name);

			if (nameLang != surnameLang) 
			{
				throw new ArgumentException("Ошибка! Язык имени и фамилии" +
					" должен совпадать.");
			}
		}

		/// <summary>
		/// Метод: проверка составного имени (фамилии) на один язык.
		/// </summary>
		/// <param name="surname">Фамилия.</param>
		/// <returns>Возврат верно введенного значения.</returns>
		/// <exception cref="ArgumentException">Возврат сообщения
		/// об ошибке.</exception>
		public static string Check2SurName(string surname) 
		{
			Regex rgxRus = new Regex(@"(^[а-яА-Я]+-?[а-яА-Я]+$)");
			Regex rgxEng = new Regex(@"(^[a-zA-Z]+-?[a-zA-Z]+$)");

            if (!rgxRus.IsMatch(surname) && !rgxEng.IsMatch(surname))
			{
				throw new ArgumentException("Ошибка! Составные части фамилии" +
					" должны быть написаны на одном языке.");
			}
			return surname;
		}
	}
}
