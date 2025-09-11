namespace Task_11_01
{
    public class PassByValueExample
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Значения до вызова метода: a = {a}, b = {b}");

            Swap(a, b);

            Console.WriteLine($"Значения после вызова метода: a = {a}, b = {b}");
        }

        // метод для обмена значениями двух целых чисел
        public static void Swap(int x, int y)
        {
            Console.WriteLine($"  Значения внутри метода до обмена: x = {x}, y = {y}");

            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"  Значения внутри метода после обмена: x = {x}, y = {y}");
        }
    }
}
