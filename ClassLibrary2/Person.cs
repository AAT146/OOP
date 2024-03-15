using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
		private const int _minAge = 1;
		
		/// <summary>
		/// Максимальный возраст персоны.
		/// </summary>
		private const int _maxAge = 90;

		/// <summary>
		/// Свойство для считывания полня _age класса Persom.
		/// </summary>
		public int Age 
		{
			get { return _age; }
			set 
			{
				if (value < _minAge || value > _maxAge) 
				{
					throw new ArgumentException("Ошибка!" + 
						$" Возраст от {_minAge} до {_maxAge}");
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
		public Gender Gender
		{
			get { return _gender; }
			set 
			{
				if (value == Gender.Female || value == Gender.Male)
					_gender = value;
				else 
				{
					throw new ArgumentException("Ошибка!" +
						$" Введите число 0 или 1.");
				}
			}
		}

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Person() : this("Фамилия", "Имя", _minAge, Gender.Female)
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
		public string GetInfoPerson() 
		{
			return ($"Фамилия: {Surname}, Имя: {Name}, Возраст: {Age}, Пол: {Gender}.\n");
		}

		//TODO: Вынести в отдельный класс генерацию случайной персоны
		private static Random rnd = new Random();

		/// <summary>
		/// Метод: генерация случайного объекта класса Person.
		/// </summary>
		/// <returns>Объект класса Person.</returns>
		public static Person GetRandomPerson()
		{
			//TODO: RSDN
			string[] SurnameFemaleRandomList = 
				{ 
					"Клоус", "Петрова", "Зимина",
					"Морозова", "Цох", "Шмидт",
					"Кельм", "Трубина", "Воровай",
					"Зубарева" 
				};

			string[] NameFemaleRandomList = { "Анастасия","Виктория","Екатерина",
				"Елизавета","Нина","Евгения","Виталина","Вера","Надежна","Любовь" };

			string[] SurnameMaleRandomList = { "Израэльсон","Кельм","Сидоров","Зной",
				"Пелевин", "Данчук","Попов","Ветров","Зализный","Пряников" };

			string[] NameMaleRandomList = { "Анатолий","Максим","Олег","Евгений",
				"Виктор", "Егор","Роберт","Игорь","Всеволод","Владимир" };

			string surname;
			string name;
			int age = rnd.Next(_minAge, _maxAge);
			Gender gender = (Gender)rnd.Next(2);

			if (gender == Gender.Female) 
			{
				surname = SurnameFemaleRandomList[rnd.Next(SurnameFemaleRandomList.Length)];
				name = NameFemaleRandomList[rnd.Next(NameFemaleRandomList.Length)];
			}
			else 
			{
				surname = SurnameMaleRandomList[rnd.Next(SurnameMaleRandomList.Length)];
				name = NameMaleRandomList[rnd.Next(NameMaleRandomList.Length)];
			}
			return new Person(surname, name, age, gender);
		}

		//TODO: extract
		/// <summary>
		/// Метод: чтение персоны с консоли.
		/// </summary>
		/// <returns>Новая персона (объект класса Person).</returns>
		public static Person ReadPersonConsole() 
		{
			Person person = new Person();

			Console.Write("Введите фамилию: ");
			person.Surname = Console.ReadLine();

			Console.Write("Введите имя: ");
			person.Name = Console.ReadLine();

			while (true)
			{
				try
				{
					Console.Write("Введите возраст: ");
					person.Age = Convert.ToInt32(Console.ReadLine());
					break;
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch (FormatException)
				{
					Console.WriteLine("Неверный формат. Введите целое число.");
				}
			}

			while (true)
			{
				try
				{
					Console.Write("Введите пол (женский - 0; мужской - 1): ");
					person.Gender = (Gender)Convert.ToInt32(Console.ReadLine());
					break;
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			return person;
		}

		/// <summary>
		/// Метод: вывод персоны на экран.
		/// </summary>
		/// <param name="person"></param>
		public static void DisplayPersonConsole(Person person)
		{
			Console.WriteLine(person.GetInfoPerson());
		}

		//TODO: RSDN
		/// <summary>
		/// Метод: проверка на пустую строну.
		/// </summary>
		/// <param name="str">Имя или фамилия персоны.</param>
		/// <returns>Имя или фамилия.</returns>
		/// <exception cref="ArgumentException">Исключение при
		/// null или пустой строке.</exception>
		public static string CheckStr(string str) 
		{
			//TODO: RSDN
			if (string.IsNullOrEmpty(str))
				throw new ArgumentException("Ошибка! Заполните параметр.");
			return str;
		}

		//TODO: rename
		/// <summary>
		/// Метод: преобразование регистров с учетом двойного 
		/// имени (фамилии).
		/// </summary>
		/// <param name="str">Имя или фамилия.</param>
		/// <returns>Скоректированное имя (фамилия)</returns>
		public static string GetRegister(string str) 
		{
			Regex regex = new Regex(@"[-]");
			if (regex.IsMatch(str))
			{
				//TODO: rename
				string[] mark = str.Split('-');
				string str1 = mark[0];
				string str2 = mark[1];
				str1 = char.ToUpper(str1[0]) + str1.Substring(1).ToLower();
				str2 = char.ToUpper(str2[0]) + str2.Substring(1).ToLower();
				str = str1 + "-" + str2;
			}
			else
				//TODO: {}
				str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
			return str;
		}
	}
}
