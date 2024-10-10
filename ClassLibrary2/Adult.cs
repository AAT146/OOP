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
		private int _passportNumber;

		/// <summary>
		/// Количество цифр номера паспорта.
		/// </summary>
		public const int DigitsPassportNumber = 4;

		/// <summary>
		/// Минимальное значение номера паспорта.
		/// </summary>
		public const int MinPassportNumber = 100000;

		/// <summary>
		/// Максимальное значение номера паспорта.
		/// </summary>
		public const int MaxPassportNumber = 999999;

		/// <summary>
		/// Серия паспорта.
		/// </summary>
		private int _passportSeries;

		/// <summary>
		/// Количество цифр серии паспорта.
		/// </summary>
		public const int DigitsPassportSeries = 6;

		/// <summary>
		/// Минимальное значение серии паспорта.
		/// </summary>
		public const int MinPassportSeries = 1000;

		/// <summary>
		/// Максимальное значение серии паспорта.
		/// </summary>
		public const int MaxPassportSeries = 9999;

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
			int passportNumber, int passportSeries, FamilyStatus familyStatus, 
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
			1000, 100000, FamilyStatus.SingleMale, null, "Работа")
		{ }

		/// <summary>
		/// Свойство номера паспорта.
		/// </summary>
		public int PassportNumber 
		{
			get { return _passportNumber; } 
			set 
			{
				if (value >= MinPassportNumber && value <= MaxPassportNumber)
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
		public int PassportSeries
		{
			get { return _passportSeries; }
			set
			{
				if (value >= MinPassportSeries && value <= MaxPassportSeries)
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
					if (value.Gender == Gender)
					{
						throw new ArgumentException("Ошибка!"
						+ "Партнеры должны быть разного пола!");
					}
					_partner = value;
					if (value != null) 
					{
						value._partner = this;
					}
				}
				else
				{
					throw new ArgumentException("Ошибка!"
						+ "Проверьте семейное положение партнеров!");
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
				$"Партнер: {partner}, Место работы: {Job}\n\n";

		}

		//TODO: XML
		public string MethodExampleAdult()
		{
			return "От работы дохнут кони. Ну, а я - бессметрный пони!\n";
		}
	}
}
