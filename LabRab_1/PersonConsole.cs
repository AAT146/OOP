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
        // TODO + : extract

        /// <summary>
        /// Метод: чтение персоны с консоли.
        /// </summary>
        /// <returns>Новая персона (объект класса Person).</returns>
        public static Person ReadPersonConsole()
        {
            Person person = new Person();

            while (true)
            {
                try
                {
                    Console.Write("Введите фамилию: ");
                    person.Surname = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите имя: ");
                    person.Name = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат." +
                        " Введите целое число от 1 до 90.");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите пол (женский - 0; мужской - 1): ");
                    person.Gender = (Gender)Convert.ToInt32(Console.ReadLine());
                    if (person.Gender == Gender.Female || person.Gender == Gender.Male)
                    {
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Ошибка!" +
                            " Введите число 0 или 1.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Не верный формат!" +
                        " Введите число 0 или 1.");
                }
            }

            return person;
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
