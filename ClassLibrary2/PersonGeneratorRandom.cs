using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
	public class PersonGeneratorRandom
	{
		private static Random rnd = new Random();

		/// <summary>
		/// Метод: генерация случайного объекта класса Person.
		/// </summary>
		/// <returns>Объект класса Person.</returns>
		public static Person GetRandom()
		{
			
			//TODO + : RSDN
			string[] surnameFemaleRandomList =
				{
					"Клоус", "Петрова", "Зимина", "Морозова", 
				    "Цох", "Шмидт", "Кельм", "Трубина", 
				    "Воровай", "Зубарева"
				};

			string[] nameFemaleRandomList = 
				{
					"Анастасия", "Виктория", "Екатерина",
				    "Елизавета", "Нина", "Евгения", "Виталина",
				    "Вера", "Надежна", "Любовь"
				};

			string[] surnameMaleRandomList = 
				{ 
				    "Израэльсон", "Кельм", "Сидоров", 
				    "Зной", "Пелевин", "Данчук", "Попов",
				    "Ветров", "Зализный", "Пряников"
			    };

			string[] nameMaleRandomList = 
				{
				    "Анатолий", "Максим", "Олег", "Евгений", 
				    "Виктор", "Егор", "Роберт", "Игорь", 
				    "Всеволод", "Владимир" 
			    };

			string surname;
			string name;
			int age = rnd.Next(Person.MinAge, Person.MaxAge);
			Gender gender = (Gender)rnd.Next(2);

			if (gender == Gender.Female)
			{
				surname = surnameFemaleRandomList[rnd.Next(surnameFemaleRandomList.Length)];
				name = nameFemaleRandomList[rnd.Next(nameFemaleRandomList.Length)];
			}
			else
			{
				surname = surnameMaleRandomList[rnd.Next(surnameMaleRandomList.Length)];
				name = nameMaleRandomList[rnd.Next(nameMaleRandomList.Length)];
			}
			return new Person(surname, name, age, gender);
		}
	}
}
