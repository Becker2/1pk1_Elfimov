using System;

public class Vklad
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Программа расчета времени достижения вклада заданной суммы.");

        Console.Write("Введите начальную сумму вклада (x): ");
        if (!double.TryParse(Console.ReadLine(), out double initialDeposit) || initialDeposit <= 0)
        {
            Console.WriteLine("Некорректный ввод начальной суммы.");
            return;
        }

        Console.Write("Введите годовой процент (p): ");
        if (!double.TryParse(Console.ReadLine(), out double annualInterestRate) || annualInterestRate <= 0)
        {
            Console.WriteLine("Некорректный ввод годового процента.");
            return;
        }

        Console.Write("Введите целевую сумму вклада (y): ");
        if (!double.TryParse(Console.ReadLine(), out double targetDeposit) || targetDeposit <= initialDeposit)
        {
            Console.WriteLine("Некорректный ввод целевой суммы.");
            return;
        }

        int years = CalculateYearsToReachTarget(initialDeposit, annualInterestRate, targetDeposit);

        if (years != -1)
        {
            Console.WriteLine($"Вклад достигнет целевой суммы в размере {targetDeposit} руб. через {years} лет.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static int CalculateYearsToReachTarget(double initialDeposit, double annualInterestRate, double targetDeposit)
    {
        double currentDeposit = initialDeposit;
        int years = 0;

        while (currentDeposit < targetDeposit)
        {
            currentDeposit = currentDeposit * (1 + annualInterestRate / 100);
            currentDeposit = Math.Floor(currentDeposit);
            years++;

            if (years > 100000)
            {
                Console.WriteLine("Целевая сумма не будет достигнута, либо для этого потребуется слишком много времени");
                return -1;
            }
        }

        return years;
    }
}