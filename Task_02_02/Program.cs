namespace Task_02_02
{
    using System;
    class Program
    {
        static void Main()
        {
            // Заданные значения
            double a = 8;
            double b = 14;
            double c = Math.PI / 4; // c = π/4

            // Вычисление выражения
            double numerator = Math.Sqrt(b + 3 * (a - 1));
            double denominator = Math.Abs(a - b * (Math.Sin(c) * Math.Sin(c) + Math.Tan(c)));

            double result = numerator / denominator;

            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }
    }

}
