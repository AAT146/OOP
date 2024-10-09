using LibraryPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryPerson
{
	/// <summary>
	/// Класс для описания гразжданина.
	/// </summary>
	public class Adult : PersonBase
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
		/// Свойство для считывания поля _status класса FamilyStatus.
		/// </summary>
		public FamilyStatus FamilyStatus { get; set; }

		/// <inheritdoc/>
		public override int MinAge { get; } = 18;

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
			string passportNumber, string passportSeries, FamilyStatus familyStatus, 
			Adult parther, string nameJob) : base(surname, name, age, gender)
		{
			_passportNumber = passportNumber;
			_passportSeries = passportSeries;
			_partner = parther;
			_nameJob = nameJob;
		}

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Adult() : this("Фамилия", "Имя", 18, Gender.Female, 
			"Серия", "Номер", FamilyStatus.Single, null, "Работа")
		{ }

		/// <summary>
		/// Метод: проверка номера/серии паспорта.
		/// </summary>
		/// <param name="passport">номер/серия паспорта.</param>
		/// <returns>true: номер/серия состоит только из цифр
		/// false: номер/серия содержит символы.</returns>
		public bool CheckNumberSeriesPassport(string passport)
		{
			return Regex.IsMatch(passport, @"^\d+$");
		}

		/// <summary>
		/// Свойство номера паспорта.
		/// </summary>
		public string PassportNumber 
		{
			get { return _passportNumber; } 
			set 
			{
				if (CheckNumberSeriesPassport(value) == true
					&& value.Length == DigitsPassportNumber)
				{
					_passportNumber = value;
				}
				else
				{
					throw new ArgumentException("Неправильно задан № паспорта." +
						$"Введите {DigitsPassportNumber} цифры.");
				}
			}
		}

		/// <summary>
		/// Свойство номера паспорта.
		/// </summary>
		public string PassportSeries
		{
			get { return _passportSeries; }
			set
			{
				if (CheckNumberSeriesPassport(value) == true
					&& value.Length == DigitsPassportSeries)
				{
					_passportSeries = value;
				}
				else
				{
					throw new ArgumentException("Неправильно задана серия паспорта!" +
						$"Введите {DigitsPassportSeries} цифр.");
				}
			}
		}

		/// <summary>
		/// Свойство семейного положения партнетов.
		/// </summary>
		public Adult Partner
		{
			get { return _partner; }
			set
			{
				if (FamilyStatus == FamilyStatus.Married &&
					value.FamilyStatus == FamilyStatus.Married)
				{
					if (Gender != value.Gender)
					{
						_partner = value;
					}
					else
					{
						throw new ArgumentException("Ошибка!" 
							+ "Партнеры должны быть разного пола!");
					}
				}
				else
				{
					throw new ArgumentException("Ошибка! Проверти семейное положение!");
				}
			}
		}

		/// <summary>
		/// Свойство работы.
		/// </summary>
		public string Job
		{
			get { return _nameJob; }
			set
			{
				_nameJob = value;

				if (string.IsNullOrEmpty(value))
				{
					_nameJob = "Безработный";
				}
			}
		}

		/// <inheritdoc/>
		public override string GetInfo()
		{
			string partner = "";
			if (FamilyStatus == FamilyStatus.Married)
			{
				partner = Partner.Surname + " " + Partner.Name;
			}
			return base.GetInfo() + 
				$"Cерия паспорта: {PassportSeries}, № паспорта: {PassportNumber},\n" +
				$"Партнер: {partner}, Место работы: {Job}\n";

		}
	}
}
