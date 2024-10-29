using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
	/// <summary>
	/// Класс формирования случайной персоны.
	/// </summary>
	public class PersonGeneratorRandom
	{
		/// <summary>
		/// Генератор случайных параметров.
		/// </summary>
		public static Random rnd = new Random();

		/// <summary>
		/// Метод: установка данных полей базового класса PersonBase.
		/// </summary>
		/// <param name="person">Объект класса PersonBase.</param>
		public static void SetPersonRandom(PersonBase person)
		{
			person.Age = rnd.Next(person.MinAge, person.MaxAge);

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
					"Вера", "Надежда", "Любовь"
				};

			string[] surnameMaleRandomList =
				{
					"Сидоров", "Иванов", "Косыхов",
					"Зномов", "Пелевов", "Данчуков", "Попов",
					"Ветров", "Кедров", "Пряников"
				};

			string[] nameMaleRandomList =
				{
					"Анатолий", "Максим", "Олег", "Евгений",
					"Виктор", "Егор", "Роберт", "Игорь",
					"Всеволод", "Владимир"
				};

			switch (person.Gender)
			{
				case Gender.Male:
					{
						person.Name = nameMaleRandomList
							[rnd.Next(0, nameMaleRandomList.Length)];
						person.Surname = surnameMaleRandomList
							[rnd.Next(0, surnameMaleRandomList.Length)];
						break;
					}
				case Gender.Female:
					{
						person.Name = nameFemaleRandomList
							[rnd.Next(nameFemaleRandomList.Length)];
						person.Surname = surnameFemaleRandomList
							[rnd.Next(surnameFemaleRandomList.Length)];
						break;
					}
			}
		}

		/// <summary>
		/// Метод: установка данных полей базового класса PersonBase.
		/// </summary>
		/// <param name="person">Объект класса PersonBase.</param>
		public static void SetPersonRandom(PersonBase person, Gender gender)
		{
			person.Age = rnd.Next(person.MinAge, person.MaxAge);

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
					"Вера", "Надежда", "Любовь"
				};

			string[] surnameMaleRandomList =
				{
					"Сидоров", "Иванов", "Косыхов",
					"Зномов", "Пелевов", "Данчуков", "Попов",
					"Ветров", "Кедров", "Пряников"
				};

			string[] nameMaleRandomList =
				{
					"Анатолий", "Максим", "Олег", "Евгений",
					"Виктор", "Егор", "Роберт", "Игорь",
					"Всеволод", "Владимир"
				};

			if (gender == Gender.Male)
			{
				person.Gender = Gender.Male;
			}
			else if (gender == Gender.Female)
			{
				person.Gender = Gender.Female;
			}

			switch (person.Gender)
			{
				case Gender.Male:
				{
					person.Name = nameMaleRandomList
						[rnd.Next(0, nameMaleRandomList.Length)];
					person.Surname = surnameMaleRandomList
						[rnd.Next(0, surnameMaleRandomList.Length)];
					break;
				}
				case Gender.Female:
				{
					person.Name = nameFemaleRandomList
						[rnd.Next(nameFemaleRandomList.Length)];
					person.Surname = surnameFemaleRandomList
						[rnd.Next(surnameFemaleRandomList.Length)];
					break;
				}
			}
		}

		/// <summary>
		/// Метод: установка данных полей класса Adult.
		/// </summary>
		/// <param name="adult">Объект класса Adult.</param>
		public static void SetAdultRandom(Adult adult)
		{
			string[] nameJob =
				{
					"СО ЕЭС", "СГК", "Россети", "Роснефть",
					"Palette", "СтройБюро", "Гамма", "ArtVector",
					"Аэрофлот", "Мясокомбинат"
				};

			adult.Job = nameJob[rnd.Next(0, nameJob.Length)];

			adult.PassportSeries = rnd.Next
				(Adult.MinPassportSeries, Adult.MaxPassportSeries);
			adult.PassportNumber = rnd.Next
				(Adult.MinPassportNumber, Adult.MaxPassportNumber);

			if (rnd.Next(2) == 0)
			{
				switch (adult.Gender)
				{
					case Gender.Male:
						{
							adult.Partner = GetRandomAdult(Gender.Female);
							break;
						}
					case Gender.Female:
						{
							adult.Partner = GetRandomAdult(Gender.Male);
							break;
						}
				}
			}
		}

		/// <summary>
		/// Метод: генерация случайного пола персоны.
		/// </summary>
		/// <param name="person">Объект класса PersonBase.</param>
		public static void SetGenderRandom(PersonBase person)
		{
			person.Gender = (Gender)rnd.Next(2);
		}

		/// <summary>
		/// Перегруженный метод: получение объекта класса Adult.
		/// </summary>
		/// <returns>Объекта класса Adult</returns>
		public static Adult GetRandomAdult()
		{
			Adult adult = new Adult();
			SetPersonRandom(adult);
			SetAdultRandom(adult);
			return adult;
		}

		/// <summary>
		/// Перегруженный метод: получение объекта класса Adult.
		/// </summary>
		/// <param name="gender">Пол.</param>
		/// <returns>Объекта класса Adult</returns>
		public static Adult GetRandomAdult(Gender gender)
		{
			Adult adult = new Adult();
			SetPersonRandom(adult, gender);
			SetAdultRandom(adult);
			return adult;
		}

		/// <summary>
		/// Метод: установка данных полей класса Child.
		/// </summary>
		/// <param name="child">Объект класса Child.</param>
		/// <param name="adult">Объект класса Adult.</param>
		public static void SetChildRandom(Child child, Adult adult)
		{
			string[] namePlaceOsStudy =
				{
					"Лицей №7", "Гимнашия №1", "Школа №9", "Школа №16",
					"Школа №4", "Школа №2", "Школа №12", "Школа глухонимых",
					"Школа №6", "Кадетский корпус"
				};

			child.PlaceOfStudy = namePlaceOsStudy
				[rnd.Next(0, namePlaceOsStudy.Length)];

			Adult father = GetRandomAdult(Gender.Male);
			child.Father = father;

			Adult mother = GetRandomAdult(Gender.Female);
			child.Mother = mother;

			mother.Surname = father.Surname;
			mother.Surname += "а";

			if (child.Gender == Gender.Male)
			{
				child.Surname = father.Surname;
			}
			else if (child.Gender == Gender.Female)
			{
				child.Surname = mother.Surname;
			}
		}

		/// <summary>
		/// Метод получения рандомного объекта класса Child.
		/// </summary>
		/// <returns></returns>
		public static Child GetRandomChild()
		{
			Child child = new Child();
			Adult adult = new Adult();
			SetGenderRandom(child);
			SetPersonRandom(child);
			SetChildRandom(child, adult);
			return child;
		}
	}
}
