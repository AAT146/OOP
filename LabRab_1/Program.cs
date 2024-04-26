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
        /// Вход в программу.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Действия программы выполняются " +
                "по нажатию любой клавиши клавиатуры.\n");
            Console.ReadKey();

            // а. Создание программно два списка персон, в каждом
            // из которых по три человка.
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();

            for (int i = 0; i < 3; i++)
            {
                personList1.Add(PersonGeneratorRandom.GetRandom());
                personList2.Add(PersonGeneratorRandom.GetRandom());
            }

            // b. Вывод содержимого кадого списка на экран с
            // соответствующими подписящи списков.
            // Каждый новый шаг выполняется по нажатию
            // любой клавиши клавиатуры.
            Console.WriteLine("Программно созданы два списка персон.\n");
            Console.ReadKey();
            Console.WriteLine($"Список №1:");
            PersonConsole.DisplayPersonConsole(personList1);
            Console.WriteLine($"Список №2:");
            PersonConsole.DisplayPersonConsole(personList2);
            Console.ReadKey();

            // с. Добавление нового человека в первый список.
            Console.WriteLine("Добавление нового человека в список №1.\n");
            Console.ReadKey();
            personList1.Add(PersonConsole.ReadPersonConsole());
            Console.WriteLine($"\nОбновленный список №1:\n");
            Console.WriteLine($"Список №1:");
            PersonConsole.DisplayPersonConsole(personList1);
            Console.ReadKey();

            // d. Копирование второго человека из первого списка
            // в конец второго списка. Один и то же человек
            // находится в обоих списках.
            Console.WriteLine("Копирование 2-го человека из списка №1" +
                " в конец списка №2.\n");
            Console.ReadKey();
            personList2.Add(personList1.FindElementAtIndex(1));
            Console.WriteLine("Проверка! Один и тот же человек находится" +
                " в обоих списках\n");
            Console.WriteLine($"Список №1:");
            PersonConsole.DisplayPersonConsole(personList1);
            Console.WriteLine($"Список №2:");
            PersonConsole.DisplayPersonConsole(personList2);
            Console.ReadKey();

            // e. Удаление второго человека из первого списка.
            // Удаление человека из первого списка не приводит к
            // уничтожению этого же человека во втором списке.
            Console.WriteLine("Удаление 2-го человека из списка №1.\n");
            Console.ReadKey();
            personList1.RemoveAtIndex(1);
            Console.WriteLine("Проверка! Удаление человека из списка №1" +
                " не привело к удалению этого же человека из списка №2.\n");
            Console.WriteLine($"Список №1:");
            PersonConsole.DisplayPersonConsole(personList1);
            Console.WriteLine($"Список №2:");
            PersonConsole.DisplayPersonConsole(personList2);
            Console.ReadKey();

            // f. Очистка второго списка.
            Console.WriteLine("Удаление всего списка №2.\n");
            Console.ReadKey();
            personList2.ClearList();
            Console.WriteLine("Проверка! Список №2 пуст.\n");
            Console.WriteLine($"Список №2:");
            PersonConsole.DisplayPersonConsole(personList2);
            Console.ReadKey();
        }
    }
}
