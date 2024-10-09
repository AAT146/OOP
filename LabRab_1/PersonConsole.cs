using LibraryPerson;
using System;

namespace LabRab_1
{
    /// <summary>
    /// Класс взаимодействия с консолью.
    /// </summary>
    public class PersonConsole
    {
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
