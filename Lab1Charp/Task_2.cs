namespace Lab1Charp;
using System;

public class Task_2
{
    public static void Run()
    {
        Console.Write("Введіть число для перевірки: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 != 0)
        {
            Console.WriteLine($"Число {a} не є парним");
        }
        else
        {
            Console.WriteLine($"Число є {a} парним");
        }
    }
}