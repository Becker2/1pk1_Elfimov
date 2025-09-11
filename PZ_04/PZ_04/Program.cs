using System;
using System.Collections.Generic;

// Палата (композиция)
public class Ward
{
    public string WardNumber { get; set; }

    public Ward(string number)
    {
        WardNumber = number;
    }

    public override string ToString()
    {
        return $"Палата №{WardNumber}";
    }
}

// Отделение (композиция палат)
public class Department
{
    public string Name { get; set; }
    private List<Ward> wards = new List<Ward>();

    public Department(string name)
    {
        Name = name;
    }

    public void AddWard(Ward ward)
    {
        wards.Add(ward);
        Console.WriteLine($"Добавлена {ward} в отделение {Name}");
    }

    public void RemoveWard(Ward ward)
    {
        wards.Remove(ward);
        Console.WriteLine($"Удалена {ward} из отделения {Name}");
    }

    public void ShowWards()
    {
        Console.WriteLine($"Отделение {Name} содержит палаты:");
        foreach (var ward in wards)
        {
            Console.WriteLine($" - {ward}");
        }
    }
}

// Больница (агрегация отделений)
public class Hospital
{
    public string Name { get; set; }
    private List<Department> departments = new List<Department>();

    public Hospital(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department dept)
    {
        departments.Add(dept);
        Console.WriteLine($"Добавлено отделение: {dept.Name}");
    }

    public void RemoveDepartment(Department dept)
    {
        departments.Remove(dept);
        Console.WriteLine($"Удалено отделение: {dept.Name} и все его палаты");
    }

    public void ShowDepartments()
    {
        Console.WriteLine($"\nБольница {Name} содержит отделения:");
        foreach (var dept in departments)
        {
            Console.WriteLine($" - {dept.Name}");
            dept.ShowWards();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Создание больницы
        Hospital hospital = new Hospital("Городская больница");

        // Создание отделений
        Department surgery = new Department("Хирургия");
        Department therapy = new Department("Терапия");

        // Добавление палат в отделения
        surgery.AddWard(new Ward("101"));
        surgery.AddWard(new Ward("102"));

        therapy.AddWard(new Ward("201"));
        therapy.AddWard(new Ward("202"));

        // Добавление отделений в больницу
        hospital.AddDepartment(surgery);
        hospital.AddDepartment(therapy);

        // Вывод структуры
        hospital.ShowDepartments();

        // Удаление отделения
        hospital.RemoveDepartment(surgery);

        // Вывод после удаления
        hospital.ShowDepartments();
    }
}