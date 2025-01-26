using System;
using System.Runtime.InteropServices;

namespace project
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш возраст: ");
            int monf = int.Parse(Console.ReadLine());

            int now = monf;

            if (monf >= 18)
            {
                Console.WriteLine("Вы совершеннолетний и ваша дата рождения: {0}.{1}.{2}", year, month, day);
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний и ваша дата рождения: {0}.{1}.{2}", year, month, day);
            }
        }

    }
}