using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short[] numbers = new short[10];
            short summ = 0;

            Random rnd = new Random();

            for (byte i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(rnd.Next(-240, 240));
                Console.WriteLine("El: " + numbers[i]);
                summ += numbers[i];
            }
            Console.WriteLine(summ);
        }
    }
}
 