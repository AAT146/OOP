using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	/// <summary>
	/// Класс, содержащищй объекты Person
	/// </summary>
	public class PersonList
	{
		/// <summary>
		/// Список, тип данных - Person, без начальных значений
		/// </summary>
		List<Person> ListPerson = new List<Person>();

		/// <summary>
		/// Метод: добавление объекта в конец списка.
		/// </summary>
		/// <param name="person">Па-тр типа Person, добавляемый в список.</param>
		public void Add(Person person)
		{
			ListPerson.Add(person);
		}

		/// <summary>
		/// Метод: удаление всех объектов из списка.
		/// </summary>
		public void Clear()
		{
			ListPerson.Clear();
		}
	}
}
