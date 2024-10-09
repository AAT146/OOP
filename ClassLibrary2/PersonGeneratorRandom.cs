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
		private static Random rnd = new Random();

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


			switch (person.Gender)
			{
				case Gender.Male:
					person.Name = nameMaleRandomList
						[rnd.Next(nameMaleRandomList.Length)];
					person.Surname = surnameMaleRandomList
						[rnd.Next(surnameMaleRandomList.Length)];
					break;
				case Gender.Female:
					person.Name = nameFemaleRandomList
						[rnd.Next(nameMaleRandomList.Length)];
					person.Surname = surnameFemaleRandomList
						[rnd.Next(surnameMaleRandomList.Length)];
					break;
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
		/// Метод: получение объекта класса Adult.
		/// </summary>
		/// <param name="gender">Пол.</param>
		/// <returns>Объекта класса Adult</returns>
		public static Adult GetRandomAdult()
		{
			Adult adult = new Adult();
			SetGenderRandom(adult);
			SetPersonRandom(adult);
			SetAdultRandom(adult);
			SetPartners(adult);
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
			adult.Gender = gender;
			SetPersonRandom(adult);
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

			switch (adult.FamilyStatus)
			{
				case FamilyStatus.SingleMale:
					child.Father = GetRandomAdult(Gender.Male);
					break;
				case FamilyStatus.Married:
					child.Father = GetRandomAdult(Gender.Male);
					SetPartners(child.Father);
					child.Mother = child.Father.Partner;
					break;
				case FamilyStatus.SingleFemale:
					child.Mother = GetRandomAdult(Gender.Female);
					break;
			}
		}

		/// <summary>
		/// Метод: установка партнера.
		/// </summary>
		/// <param name="adult">Объект класса Adult.</param>
		public static void SetPartners(Adult adult)
		{;
			Adult partner = new Adult();

			FamilyStatus status = (FamilyStatus)rnd.Next(3);
			if (status == FamilyStatus.Married)
			{
				switch (adult.Gender)
				{
					case Gender.Male:
						partner = GetRandomAdult(Gender.Female);
						break;
					case Gender.Female:
						partner = GetRandomAdult(Gender.Male);
						break;
				}
			}

			adult.Partner = partner;
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
