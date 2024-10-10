using LibraryPerson;
using System;

namespace LabRab_1
{
    /// <summary>
    /// Основная программа.
    /// </summary>
    internal class Program
    {
        /// <summary>
		/// Генератор случайных параметров.
		/// </summary>
		private static Random _rnd = new Random();

        /// <summary>
        /// Вход в программу.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Действия программы выполняются " +
                "по нажатию любой клавиши клавиатуры.\n");

            // 5а. Создание программно списка PersonList, в который
            // добавляются рандомно 7 человек (взрослые/дети).
            PersonList personList = new PersonList();

            Console.WriteLine("Случайный список взрослых и детей:\n");
            Console.ReadKey();

            //Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                if (_rnd.Next(2) == 0)
                {
                    personList.Add(PersonGeneratorRandom.GetRandomAdult());
                }
                else
                {
                    personList.Add(PersonGeneratorRandom.GetRandomChild());
                }
            }

            // 5b. Вывод на экранописание всех людей списка.
            PersonConsole.DisplayPersonConsole(personList);
            Console.ReadKey();

            // 5c. Четвертый человек. Работа метода.
            var fourPerson = personList.FindElementAtIndex(3);
            Console.WriteLine($"Тип 4-го человека в списке: {fourPerson.GetType()}\n");

            switch (fourPerson)
            {
                case Adult adult:
                    Console.WriteLine($"Взрослый: {adult.Surname} {adult.Name}");
                    Console.WriteLine(adult.MethodExampleAdult());
                    break;
                case Child child:
                    Console.WriteLine($"Ребёнок: {child.Surname} {child.Name}");
                    Console.WriteLine(child.MethodExampleChild());
                    break;
                default:
                    Console.WriteLine("Пипец");
                    break;
            }

            Console.WriteLine("Завершение программы.");
            Console.ReadKey();
        }
    }
}
