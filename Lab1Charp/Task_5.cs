namespace Lab1Charp;

public class Task_5
{
    public static void Run()
    {
        int a, b;
        Console.WriteLine("Введіть 2 цілих числа: ");
        Console.Write("a: ");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Помилка! Ви ввели щось не те.");
            Console.Write("Будь ласка, введіть саме ЦІЛЕ число: ");
        }
        
        Console.Write("b: ");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            // ...програма буде видавати помилку і просити ввести знову
            Console.WriteLine("Помилка! Ви ввели щось не те.");
            Console.Write("Будь ласка, введіть саме ЦІЛЕ число: ");
        }

        int solve = a * b;
        
        Console.WriteLine($"Добуток чисел {a} та {b} дорівнює {solve}");


    }
}