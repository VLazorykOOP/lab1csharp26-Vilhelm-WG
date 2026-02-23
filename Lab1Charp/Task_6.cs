namespace Lab1Charp;

public class Task_6
{
    public static void Run()
    {
        int n, m;
        Console.WriteLine("Введіть 2 цілих числа: ");
        Console.Write("a: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Помилка! Ви ввели щось не те.");
            Console.Write("Будь ласка, введіть саме ЦІЛЕ число: ");
        }
        
        Console.Write("b: ");
        while (!int.TryParse(Console.ReadLine(), out m))
        {
            // ...програма буде видавати помилку і просити ввести знову
            Console.WriteLine("Помилка! Ви ввели щось не те.");
            Console.Write("Будь ласка, введіть саме ЦІЛЕ число: ");
        }

        double X = (n + 1.0) / (n * n + m * m + 1.0);
        double Y = 1.0 / ((m + 1.0) * (n + 1.0));
        double result = X - Y;
        
        Console.WriteLine($"Результат {result}");
    }
}