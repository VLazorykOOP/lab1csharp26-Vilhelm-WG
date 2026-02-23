namespace Lab1Charp;
using System;

public class Task_1
{
    static void main()
    {
        Console.Write("Введіть координату (a)");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть координату (b)");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Введіть координату (c)");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Введіть координату (d)");
        double d = double.Parse(Console.ReadLine());

        double deltaX = c - a;
        double deltaY = d - b;

        double Delta = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2);

        double distance = Math.Sqrt(Delta);
        
        Console.WriteLine($"Відстань становить {distance:F2}");

    }

}