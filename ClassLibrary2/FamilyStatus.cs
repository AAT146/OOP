using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
	/// <summary>
	/// Перечисление для определения семейного статуса.
	/// </summary>
	public enum FamilyStatus
	{
		/// <summary>
		/// Холост.
		/// </summary>
		SingleMale,

		/// <summary>
		/// Состоящий в браке.
		/// </summary>
		Married,

		/// <summary>
		/// Не замужем.
		/// </summary>
		SingleFemale,
	}
}
