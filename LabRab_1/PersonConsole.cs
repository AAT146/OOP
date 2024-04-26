using LibraryPerson;
using System;
using System.Collections.Generic;

namespace LabRab_1
{
    /// <summary>
    /// Класс взаимодействия с консолью.
    /// </summary>
    public class PersonConsole
    {
        /// <summary>
        /// Метод: чтение персоны с консоли.
        /// </summary>
        /// <returns>Новая персона (объект класса Person).</returns>
        public static Person ReadPersonConsole()
        {
            Person person = new Person();

            List<Action> actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите фамилию: ");
                    person.Surname = Console.ReadLine();
                },
                () =>
                {
                    Console.Write("Введите имя: ");
                    person.Name = Console.ReadLine();
                },
                () =>
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите пол (женский - 0; мужской - 1): ");
                    person.Gender = (Gender)Convert.ToInt32(Console.ReadLine());
                    if (!(person.Gender == Gender.Female || person.Gender == Gender.Male))
                    {
                        throw new ArgumentException("Ошибка!" +
                            " Введите число 0 или 1.");
                    }
                },
            };

            foreach (Action action in actions)
            {
                ActionHandler(action);
            }

            return person;
        }

        /// <summary>
        /// Метод: обработка исключений.
        /// </summary>
        /// <param name="action">Действие.</param>
        public static void ActionHandler(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception ex)
                {
                    var exceptionType = ex.GetType();
                    if (exceptionType == typeof(FormatException) ||
                        exceptionType == typeof(ArgumentOutOfRangeException) ||
                        exceptionType == typeof(ArgumentException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Метод: вывод персоны на экран.
        /// </summary>
        /// <param name="personList">Элемент класса PersonList.</param>
        public static void DisplayPersonConsole(PersonList personList)
        {
            Console.WriteLine(personList.GetInfo());
        }
    }
}
