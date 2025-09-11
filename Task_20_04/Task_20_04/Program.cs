using System;
using System.Collections.Generic;
using System.Linq;
public class VehicleManager
{
    public enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }
    private List<VehicleType> vehicles = new List<VehicleType>();

    public void AddVehicle(VehicleType type)
    {
        vehicles.Add(type);
        Console.WriteLine($"Добавлен транспорт типа: {type}");
    }
    public int CountVehiclesOfType(VehicleType type)
    {
        return vehicles.Count(v => v == type);
    }
    public void DisplayVehiclesOfType(VehicleType type)
    {
        Console.WriteLine($"Транспорт типа: {type}");
        foreach (var vehicle in vehicles)
        {
            if (vehicle == type)
            {
                Console.WriteLine($"- {vehicle}");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();

            manager.AddVehicle(VehicleManager.VehicleType.Car);
            manager.AddVehicle(VehicleManager.VehicleType.Truck);
            manager.AddVehicle(VehicleManager.VehicleType.Car);
            manager.AddVehicle(VehicleManager.VehicleType.Motorcycle);
            manager.AddVehicle(VehicleManager.VehicleType.Bus);
            manager.AddVehicle(VehicleManager.VehicleType.Truck);
            manager.AddVehicle(VehicleManager.VehicleType.Bike);

            Console.WriteLine($"\nКоличество автомобилей: {manager.CountVehiclesOfType(VehicleManager.VehicleType.Car)}");
            Console.WriteLine($"Количество грузовиков: {manager.CountVehiclesOfType(VehicleManager.VehicleType.Truck)}");

            Console.WriteLine("\nВывод информации о грузовиках:");
            manager.DisplayVehiclesOfType(VehicleManager.VehicleType.Truck);
        }
    }
}