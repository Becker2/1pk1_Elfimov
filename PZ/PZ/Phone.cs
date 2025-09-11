using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Phone : ICloneable, IComparable<Phone>, IDisposable
{
    // Поля класса
    public string prefix;
    public string code;
    public string number;
    public string type;

    // Ссылочное поле для демонстрации глубокого копирования
    public PhoneDetails details;

    // Конструктор по умолчанию
    public Phone()
    {
        prefix = "+7";
        code = "999";
        number = "0000000";
        type = "Личный";
        details = new PhoneDetails();
    }

    // Конструктор с основными параметрами
    public Phone(string phonePrefix, string phoneCode, string phoneNumber)
    {
        prefix = phonePrefix;
        code = phoneCode;
        number = phoneNumber;
        type = "Личный";
        details = new PhoneDetails();
    }

    // Конструктор со всеми параметрами
    public Phone(string phonePrefix, string phoneCode, string phoneNumber, string phoneType)
    {
        prefix = phonePrefix;
        code = phoneCode;
        number = phoneNumber;
        type = phoneType;
        details = new PhoneDetails();
    }

    // Конструктор из строки (2 параметра)
    public Phone(string fullNumber, string phoneType)
    {
        if (fullNumber.Length >= 10)
        {
            prefix = fullNumber.Substring(0, 2);
            code = fullNumber.Substring(2, 3);
            number = fullNumber.Substring(5);
        }
        else
        {
            prefix = "+7";
            code = "999";
            number = "0000000";
        }

        if (number.Length > 7)
        {
            number = number.Substring(0, 7);
        }

        type = phoneType;
        details = new PhoneDetails();
    }

    // ICloneable - глубокое копирование
    public object Clone()
    {
        Phone cloned = (Phone)this.MemberwiseClone();
        cloned.details = new PhoneDetails
        {
            OwnerName = this.details.OwnerName,
            PurchaseDate = this.details.PurchaseDate,
            IsActive = this.details.IsActive
        };
        return cloned;
    }

    // IComparable - сравнение по номеру телефона
    public int CompareTo(Phone other)
    {
        if (other == null) return 1;

        string thisFullNumber = prefix + code + number;
        string otherFullNumber = other.prefix + other.code + other.number;

        return string.Compare(thisFullNumber, otherFullNumber, StringComparison.Ordinal);
    }

    // IDisposable
    private bool disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
                details = null;
            }
            // Освобождаем неуправляемые ресурсы (если есть)
            disposed = true;
        }
    }

    ~Phone()
    {
        Dispose(false);
    }

    // Метод для получения номера в формате +7(xxx)xxx-xx-xx
    public string GetPhoneNumber()
    {
        if (number.Length != 7)
        {
            return "Неверный формат номера";
        }

        return $"{prefix}({code}){number.Substring(0, 3)}-{number.Substring(3, 2)}-{number.Substring(5, 2)}";
    }

    // Метод для вывода полной информации
    public void PrintInfo()
    {
        Console.WriteLine("=== ИНФОРМАЦИЯ О ТЕЛЕФОНЕ ===");
        Console.WriteLine($"Префикс: {prefix}");
        Console.WriteLine($"Код: {code}");
        Console.WriteLine($"Номер: {number}");
        Console.WriteLine($"Тип: {type}");
        Console.WriteLine($"Форматированный номер: {GetPhoneNumber()}");
        if (details != null)
        {
            Console.WriteLine($"Владелец: {details.OwnerName}");
            Console.WriteLine($"Дата активации: {details.PurchaseDate:dd.MM.yyyy}");
            Console.WriteLine($"Активен: {details.IsActive}");
        }
        Console.WriteLine("==============================");
        Console.WriteLine();
    }
}

// Класс для демонстрации глубокого копирования
public class PhoneDetails
{
    public string OwnerName { get; set; } = "Неизвестно";
    public DateTime PurchaseDate { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;
}