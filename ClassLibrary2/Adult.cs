using LibraryPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryPerson
{
	/// <summary>
	/// Класс для описания гразжданина.
	/// </summary>
	public class Adult : Person
	{
		/// <summary>
		/// Номер паспорта.
		/// </summary>
		private string _passportNumber;

		/// <summary>
		/// Количество цифр номера паспорта.
		/// </summary>
		public const int DigitsPassportNumber = 4;

		/// <summary>
		/// Серия паспорта.
		/// </summary>
		private string _passportSeries;

		/// <summary>
		/// Количество цифр серии паспорта.
		/// </summary>
		public const int DigitsPassportSeries = 6;

		/// <summary>
		/// Партнер.
		/// </summary>
		private Adult _partner;

		/// <summary>
		/// Наименование работы.
		/// </summary>
		private string _nameJob;

		/// <summary>
		/// Минимальный возраст.
		/// </summary>
		public const int MinAdultAge = 18;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="surname">Фамилия гражданина.</param>
		/// <param name="name">Имя гражданина.</param>
		/// <param name="age">Возраст гражданина.</param>
		/// <param name="gender">Пол гражданина.</param>
		/// <param name="passportNumber">Номер паспорта гражданина.</param>
		/// <param name="passportSeries">Серия паспорта гражданина.</param>
		/// <param name="parther">Супруг/супруга гражданина.</param>
		/// <param name="nameJob">Наименование работы гражданина.</param>
		public Adult(string surname, string name, int age, Gender gender, 
			string passportNumber, string passportSeries, Adult parther, string nameJob) 
			: base(surname, name, age, gender)
		{
			_passportNumber = passportNumber;
			_passportSeries = passportSeries;
			_partner = parther;
			_nameJob = nameJob;
		}

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Adult() : this("Фамилия", "Имя", MinAge, Gender.Female, 
			"№____", "s______", null, "Работа")
		{ }
	}
}
