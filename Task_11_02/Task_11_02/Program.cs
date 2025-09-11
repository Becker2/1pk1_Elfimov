using System;

public class PassByReferenceExample
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        Console.WriteLine($"Значения до вызова метода: a = {a}, b = {b}");

        Swap(ref a, ref b); // Передача по ссылке с использованием ключевого слова ref

        Console.WriteLine($"Значения после вызова метода: a = {a}, b = {b}");
    }

    // Метод для обмена значениями двух целых чисел 
    public static void Swap(ref int x, ref int y) // Использование ref для параметров
    {
        Console.WriteLine($"  Значения внутри метода до обмена: x = {x}, y = {y}");

        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"  Значения внутри метода после обмена: x = {x}, y = {y}");
    }
}