using System.Numerics;
using System;
using System.Collections.Generic;

namespace PZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДЕМОНСТРАЦИЯ РАБОТЫ КЛАССА PHONE С ИНТЕРФЕЙСАМИ");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            // 1. Создание объектов
            Console.WriteLine("1. СОЗДАНИЕ ОБЪЕКТОВ:");
            Phone phone1 = new Phone();
            Phone phone2 = new Phone("+7", "495", "1234567");
            Phone phone3 = new Phone("+1", "212", "5551234", "Корпоративный");
            Phone phone4 = new Phone("74959998877", "Личный");

            // Установка дополнительных данных
            phone1.details.OwnerName = "Иван Петров";
            phone2.details.OwnerName = "Петр Иванов";
            phone3.details.OwnerName = "Компания ООО 'Львиная душа'";
            phone4.details.OwnerName = "Мария Сидорова";

            phone1.PrintInfo();
            phone2.PrintInfo();
            phone3.PrintInfo();
            phone4.PrintInfo();

            // 2. ICloneable - глубокое копирование
            Console.WriteLine("2. ICLONEABLE - ГЛУБОКОЕ КОПИРОВАНИЕ:");
            Phone clonedPhone = (Phone)phone2.Clone();
            clonedPhone.details.OwnerName = "Клон Петрова";
            Console.WriteLine("Оригинал: " + phone2.details.OwnerName);
            Console.WriteLine("Клон: " + clonedPhone.details.OwnerName);
            Console.WriteLine();

            // 3. IComparable - сортировка коллекции
            Console.WriteLine("3. ICOMPARABLE - СОРТИРОВКА КОЛЛЕКЦИИ:");
            List<Phone> phones = new List<Phone>
        {
            new Phone("+7", "916", "9876543", "Личный"),
            new Phone("+1", "212", "1112233", "Корпоративный"),
            new Phone("+7", "495", "5556677", "Личный"),
            new Phone("+1", "718", "9998888", "Корпоративный"),
            new Phone("+7", "499", "1234567", "Личный"),
            new Phone("+7", "495", "7654321", "Корпоративный"),
            new Phone("+1", "917", "4445566", "Личный"),
            new Phone("+7", "812", "3332222", "Корпоративный"),
            new Phone("+1", "646", "7778888", "Личный"),
            new Phone("+7", "383", "1119999", "Корпоративный")
        };

            Console.WriteLine("До сортировки:");
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.GetPhoneNumber());
            }

            phones.Sort();

            Console.WriteLine("\nПосле сортировки:");
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.GetPhoneNumber());
            }
            Console.WriteLine();

            // 4. IDisposable
            Console.WriteLine("4. IDISPOSABLE:");
            using (Phone disposablePhone = new Phone("+7", "999", "8887777", "Временный"))
            {
                disposablePhone.PrintInfo();
                Console.WriteLine("Телефон используется в using блоке");
            }
            Console.WriteLine("Телефон disposed");
            Console.WriteLine();

            // 5. Пользовательский интерфейс IPhoneService
            Console.WriteLine("5. ПОЛЬЗОВАТЕЛЬСКИЙ ИНТЕРФЕЙС IPHONESERVICE:");

            // 6. Дополнительная проверка работы интерфейса
            Console.WriteLine("6. ДОПОЛНИТЕЛЬНАЯ ПРОВЕРКА:");

            Console.ReadLine();
        }
    }
}
