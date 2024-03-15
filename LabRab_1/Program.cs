using ClassLibrary1;
using System;

namespace LabRab_1
{
    /// <summary>
    /// Основная программа.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод Main. Пункт 3.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Действия программы выполняются " +
                "по нажатию любой клавиши клавиатуры.\n");
            Console.ReadKey();

            // а. Создание программно два списка персон, в каждом
            // из которых по три человка.
            PersonList personList_1 = new PersonList();
            PersonList personList_2 = new PersonList();

            for (int i = 0; i < 3; i++)
            {
                personList_1.Add(Person.GetRandomPerson());
                personList_2.Add(Person.GetRandomPerson());
            }

            // b. Вывод содержимого кадого списка на экран с
            // соответствующими подписящи списков.
            // Каждый новый шаг выполняется по нажатию
            // любой клавиши клавиатуры.
            Console.WriteLine("Программно созданы два списка персон.\n");
            Console.ReadKey();
            Console.WriteLine($"Список №1:\n{personList_1.GetInfoPersonList()}");
            Console.WriteLine($"Список №2:\n{personList_2.GetInfoPersonList()}");
            Console.ReadKey();

            // с. Добавление нового человека в первый список.
            Console.WriteLine("Добавление нового человека в список №1.\n");
            Console.ReadKey();
            personList_1.Add(Person.ReadPersonConsole());
            Console.WriteLine($"Обновленный список №1:\n{personList_1.GetInfoPersonList()}");
            Console.ReadKey();

            // d. Копирование второго человека из первого списка
            // в конец второго списка. Один и то же человек
            // находится в обоих списках.
            Console.WriteLine("Копирование 2-го человека из списка №1" +
                " в конец списка №2.\n");
            Console.ReadKey();
            personList_2.Add(personList_1.FindElementAtIndex(1));
            Console.WriteLine("Проверка! Один и тот же человек находится" +
                " в обоих списках\n");
            Console.WriteLine($"Список №1:\n{personList_1.GetInfoPersonList()}");
            Console.WriteLine($"Список №2:\n{personList_2.GetInfoPersonList()}");
            Console.ReadKey();

            // e. Удаление второго человека из первого списка.
            // Удаление человека из первого списка не приводит к
            // уничтожению этого же человека во втором списке.
            Console.WriteLine("Удаление 2-го человека из списка №1.\n");
            Console.ReadKey();
            personList_1.RemoveAtIndex(1);
            Console.WriteLine("Проверка! Удаление человека из списка №1" +
                " не привело к удалению этого же человека из списка №2.\n");
            Console.WriteLine($"Список №1:\n{personList_1.GetInfoPersonList()}");
            Console.WriteLine($"Список №2:\n{personList_2.GetInfoPersonList()}");
            Console.ReadKey();

            // f. Очистка второго списка.
            Console.WriteLine("Удаление всего списка №2.\n");
            Console.ReadKey();
            personList_2.ClearList();
            Console.WriteLine("Проверка! Список №2 пуст.\n");
            Console.WriteLine($"Список №2:\n{personList_2.GetInfoPersonList()}");
            Console.ReadKey();
        }
    }
}
