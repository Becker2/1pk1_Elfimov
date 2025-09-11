using System;
using System.Threading;
public class TrafficLight
{
    public enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }
    private TrafficLightColor currentColor = TrafficLightColor.Red;
    public void RunAutomaticMode()
    {
        while (true)
        {
            Console.WriteLine($"Светофор: {currentColor}");

            switch (currentColor)
            {
                case TrafficLightColor.Red:
                    Thread.Sleep(3000);
                    currentColor = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Green:
                    Thread.Sleep(3000);
                    currentColor = TrafficLightColor.Yellow;
                    break;
                case TrafficLightColor.Yellow:
                    Thread.Sleep(1000); // Yellow горит меньше
                    currentColor = TrafficLightColor.Red;
                    break;
            }
        }
    }
    public void RunManualMode()
    {
        Console.WriteLine("Ручной режим управления светофором. Нажмите клавиши для переключения:");
        Console.WriteLine("  1 - Красный");
        Console.WriteLine("  2 - Желтый");
        Console.WriteLine("  3 - Зеленый");
        Console.WriteLine("  Q - Выход");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true чтобы не выводить нажатую клавишу в консоль
            switch (keyInfo.KeyChar)
            {
                case '1':
                    currentColor = TrafficLightColor.Red;
                    Console.WriteLine($"Светофор: {currentColor}");
                    break;
                case '2':
                    currentColor = TrafficLightColor.Yellow;
                    Console.WriteLine($"Светофор: {currentColor}");
                    break;
                case '3':
                    currentColor = TrafficLightColor.Green;
                    Console.WriteLine($"Светофор: {currentColor}");
                    break;
                case 'q':
                case 'Q':
                    Console.WriteLine("Выход из ручного режима.");
                    return; // Выход из метода RunManualMode
                default:
                    Console.WriteLine("Некорректная клавиша.");
                    break;
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();

        Console.WriteLine("Выберите режим работы светофора:");
        Console.WriteLine("  1 - Автоматический");
        Console.WriteLine("  2 - Ручной");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                trafficLight.RunAutomaticMode(); // Запускаем автоматический режим в бесконечном цикле
                break;
            case "2":
                trafficLight.RunManualMode(); // Запускаем ручной режим
                break;
            default:
                Console.WriteLine("Некорректный выбор. Завершение программы.");
                break;
        }
    }
}