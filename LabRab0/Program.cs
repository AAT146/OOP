using System;

namespace LabRab0
{
    /// <summary>
    /// Вводное задание.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Лабораторная работа 4 по ПиОА.
        /// </summary>
        private static void Main()
        {
            uint number;
            Console.Write("Введите число в десятичной системе: ");
            while (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите целое положительное число.");
            }

            Console.WriteLine($"Число в двоичной системе: {BinaryNumber(number)}");

            // Console.WriteLine($"Число в двоичной системе 2: {BN2(number)}");
            Console.WriteLine($"Число в восьмиричной системе: {OctalNumber(number)}");
            Console.WriteLine($"Число в шестнадцатеричной " +
                $"системе: {HexadecimalNumber(number)}");
        }

        /*
        /// <summary>
        /// Перевод из десятичной в двоичную систему счисления.
        /// </summary>
        /// <param name="num">Число в десятичной системе счисления.</param>
        /// <returns>result.</returns>
        private static string BN2(uint num)
        {
            uint renum;
            string result = "";
            while (num > 0)
            {
                renum = num % 2;
                num /= 2;
                result = renum.ToString() + result;
            }

            return result;
        }*/

        /// <summary>
        /// Перевод из десятичной в двоичную систему счисления.
        /// </summary>
        /// <param name="num">Число в десятичной системе счисления.</param>
        /// <returns>result.</returns>
        private static string BinaryNumber(uint num)
        {
            string result = Convert.ToString(num, 2);
            return result;
        }

        /// <summary>
        /// Перевод из десятичной в восьмеричную систему счисления.
        /// </summary>
        /// <param name="num">Число в восьмеричной системе счисления.</param>
        /// <returns>result.</returns>
        private static string OctalNumber(uint num)
        {
            string result = Convert.ToString(num, 8);
            return result;
        }

        /// <summary>
        /// Перевод из десятичной в шестнадцатеричную систему счисления.
        /// </summary>
        /// <param name="num">Число в шестнадцатеричной системе счисления.</param>
        /// <returns>result.</returns>
        private static string HexadecimalNumber(uint num)
        {
            string result = Convert.ToString(num, 16);
            return result;
        }
    }
}
