namespace Lab1Charp;

public class Task_4
{
    public static void Run()
    {
        Console.Write("Введіть номер масті (від 1 до 4): ");
        int m = int.Parse(Console.ReadLine());

        // Перевіряємо значення змінної m
        switch (m)
        {
            case 1:
                Console.WriteLine("піки");
                break;
            case 2:
                Console.WriteLine("трефи");
                break;
            case 3:
                Console.WriteLine("бубни");
                break;
            case 4:
                Console.WriteLine("черви");
                break;
            default:
                // Спрацює, якщо користувач введе число, якого немає серед case (наприклад, 5 або 0)
                Console.WriteLine("Помилка: номер масті має бути від 1 до 4.");
                break;
        }
    }
}