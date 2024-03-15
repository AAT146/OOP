using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
	/// <summary>
	/// Класс, содержащищй элементы класса Person
	/// </summary>
	public class PersonList
	{
		//TODO: RSDN
		/// <summary>
		/// Список, тип данных - Person.
		/// </summary>
		private List<Person> ListPerson = new List<Person>();

		/// <summary>
		/// Метод: добавление элемента.
		/// </summary>
		/// <param name="person">"Элемент класса Person.</param>
		public void Add(Person person)
		{
			ListPerson.Add(person);
		}

		/// <summary>
		/// Метод: удаление объекта класса Person из списка.
		/// </summary>
		/// <param name="person">Элемент класса Person.</param>
		public void RemoveElement(Person person)
		{
			ListPerson.Remove(person);
		}

		/// <summary>
		/// Метод: удаление элемента из списка по индексу.
		/// </summary>
		/// <param name="index">Индекс элемента.</param>
		public void RemoveAtIndex(int index) 
		{
			ListPerson.RemoveAt(index);
		}

		/// <summary>
		/// Метод: нахождение элемента из списка по индексу.
		/// </summary>
		/// <param name="index">Индекс элемента.</param>
		/// <returns>Элемент.</returns>
		/// <exception cref="IndexOutOfRangeException">Исключение при
		/// выходе индекса за границы списка.</exception>
		public Person FindElementAtIndex(int index)
		{
			//TODO: {}
			if (index >= 0 && index < ListPerson.Count)
				return ListPerson[index];
			else 
				throw new IndexOutOfRangeException($"Элемента с индексом {index}" + 
					"не существует.");
		}

		/// <summary>
		/// Метод: возврат индекса элемента при наличии его в списке.
		/// </summary>
		/// <param name="person">Элемент класса Person.</param>
		/// <returns>Индекс.</returns>
		/// <exception cref="IndexOutOfRangeException">Исключение при
		/// отсутсвии данного индекса.</exception> 
		public int ReturnIndexElement(Person person) 
		{
			//TODO: {}
			if (ListPerson.Contains(person))
				return ListPerson.IndexOf(person);
			else
				throw new IndexOutOfRangeException($"Данный элемент не существует.");
		}

		/// <summary>
		/// Метод: удаление всех элементов из списка.
		/// </summary>
		public void ClearList()
		{
			ListPerson.Clear();
		}

		/// <summary>
		/// Метод: получение количества элементов в списке.
		/// </summary>
		/// <returns>Вовзрат числа</returns>
		public int CountElements()
		{
			return ListPerson.Count(); 
		}

		/// <summary>
		/// Метод: возврат информации о элементе класса Person,
		/// содержащимся в списке.
		/// </summary>
		/// <returns>Строка по форме GetIngoPerson.</returns>
		public string GetInfoPersonList()
		{
			string str = string.Empty;
			foreach (Person person in ListPerson)
			{
				str += person.GetInfoPerson();
			}
			return str;
		}
	}
}