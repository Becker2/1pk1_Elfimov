
public class MathOperations
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        int sum;
        int product;

        CalculateSumAndProduct(ref a, ref b, out sum, out product);

        Console.WriteLine($"Числа: a = {a}, b = {b}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
    }

    // Принимает два числа по ссылке (ref) и возвращает результаты через выходные параметры (out).
    public static void CalculateSumAndProduct(ref int x, ref int y, out int sum, out int product)
    {
        // Можно изменить значения x и y внутри метода, и эти изменения отразятся на исходных переменных
        x = x + 1;

        sum = x + y;
        product = x * y;
    }
}