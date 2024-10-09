using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
	/// <summary>
	/// Класс для описания ребенка
	/// </summary>
	public class Child : PersonBase
	{
		/// <summary>
		/// Мать.
		/// </summary>
		private Adult _mother;

		/// <summary>
		/// Отец.
		/// </summary>
		private Adult _father;

		/// <summary>
		/// Место обучения.
		/// </summary>
		private string _placeOfStudy;

		/// <inheritdoc/>
		public override int MaxAge { get; } = 17;

		/// <summary>
		/// Констуктор.
		/// </summary>
		/// <param name="surname">Имя.</param>
		/// <param name="name">Фамилия.</param>
		/// <param name="age">Возраст.</param>
		/// <param name="gender">Пол.</param>
		/// <param name="mother">Мать.</param>
		/// <param name="father">Отец.</param>
		/// <param name="placeOfStudy">Место обучения.</param>
		public Child(string surname, string name, int age, Gender gender,
		   Adult mother, Adult father, string placeOfStudy)
		   : base(surname, name, age, gender)
		{
			_mother = mother;
			_father = father;
			_placeOfStudy = placeOfStudy;
		}

		/// <summary>
		/// Класс по умолчанию.
		/// </summary>
		public Child() : this("Фамилия", "Имя", 17, Gender.Female,
			null, null, "Место обучения")
		{ }

		/// <summary>
		/// Свойство для матери.
		/// </summary>
		public Adult Mother
		{
			get { return _mother; }
			set
			{
				if (value is null || value.Gender == Gender.Female)
				{
					_mother = value;
				}
				else
				{
					throw new ArgumentException ("Ошибка! Мать - женский пол.");
				}
			}
		}

		/// <summary>
		/// Свойсвто для отца.
		/// </summary>
		public Adult Father
		{
			get { return _father; }
			set
			{
				if (value is null || value.Gender == Gender.Male)
				{
					_father = value;
				}
				else
				{
					throw new ArgumentException("Ошибка! Отец - мужской пол.");
				}
			}
		}

		/// <summary>
		/// Свойсвто для места обучения.
		/// </summary>
		public string PlaceOfStady
		{
			get { return _placeOfStudy; }
			set
			{
				_placeOfStudy = value;
				if (value == null || value == " ")
				{
					_placeOfStudy = "Без места обучения.";
				}
			}
		}

		/// <inheritdoc/>
		public override string GetInfo()
		{
			string father = "Отсутствует";
			string mother = "Отсутствует";
			if (Mother != null)
			{
				mother = Mother.Surname + " " + Mother.Name;
			}
			if (Father != null)
			{
				father = Father.Surname + " " + Father.Name;
			}

			return base.GetInfo() + $"Отец: {father}, Мать: {mother}" + 
				$"Место обучения: {PlaceOfStady}\n";
		}
	}
}
