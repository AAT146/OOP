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
		/// <summary>
		/// Список, тип данных - Person.
		/// </summary>
		private List<PersonBase> _listPerson = new List<PersonBase	>();

		/// <summary>
		/// Метод: добавление элемента.
		/// </summary>
		/// <param name="person">"Элемент класса Person.</param>
		public void Add(PersonBase person)
		{
			_listPerson.Add(person);
		}

		/// <summary>
		/// Метод: удаление объекта класса Person из списка.
		/// </summary>
		/// <param name="person">Элемент класса Person.</param>
		public void RemoveElement(PersonBase person)
		{
			_listPerson.Remove(person);
		}

		/// <summary>
		/// Метод: удаление элемента из списка по индексу.
		/// </summary>
		/// <param name="index">Индекс элемента.</param>
		public void RemoveAtIndex(int index) 
		{
			_listPerson.RemoveAt(index);
		}

		/// <summary>
		/// Метод: нахождение элемента из списка по индексу.
		/// </summary>
		/// <param name="index">Индекс элемента.</param>
		/// <returns>Элемент.</returns>
		/// <exception cref="IndexOutOfRangeException">Исключение при
		/// выходе индекса за границы списка.</exception>
		public PersonBase FindElementAtIndex(int index)
		{
			if (index >= 0 && index < _listPerson.Count)
			{
				return _listPerson[index];
			}
			else
			{
				throw new IndexOutOfRangeException($"Элемента с индексом {index}" +
					"не существует.");
			}
		}

		/// <summary>
		/// Метод: возврат индекса элемента при наличии его в списке.
		/// </summary>
		/// <param name="person">Элемент класса Person.</param>
		/// <returns>Индекс.</returns>
		/// <exception cref="IndexOutOfRangeException">Исключение при
		/// отсутсвии данного индекса.</exception> 
		public int ReturnIndexElement(PersonBase person) 
		{
			if (_listPerson.Contains(person))
			{
				return _listPerson.IndexOf(person);
			}
			else
			{
				throw new IndexOutOfRangeException($"Данный элемент не существует.");
			}
		}

		/// <summary>
		/// Метод: удаление всех элементов из списка.
		/// </summary>
		public void ClearList()
		{
			_listPerson.Clear();
		}

		/// <summary>
		/// Метод: получение количества элементов в списке.
		/// </summary>
		/// <returns>Вовзрат числа</returns>
		public int CountElements()
		{
			return _listPerson.Count(); 
		}

		/// <summary>
		/// Метод: возврат информации о классе PersonList.
		/// </summary>
		/// <returns>Строка по форме GetIngoPerson.</returns>
		public string GetInfo()
		{
			string str = string.Empty;
			foreach (PersonBase person in _listPerson)
			{
				str += person.GetInfo();
			}
			return str;
		}
	}
}