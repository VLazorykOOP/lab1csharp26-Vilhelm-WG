namespace Lab1Charp;

public class Task_3
{
    public static void Run()
    {
        Console.WriteLine("Введіть координату x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть координату y:");
        double y = double.Parse(Console.ReadLine());

        // Обчислюємо квадрат відстані точки від початку координат (x^2 + y^2)
        double d2 = x * x + y * y;

        // 1. Перевірка: чи лежить точка на МЕЖІ
        bool onOuterSemicircle = (d2 == 100 && y >= 0);
        bool onInnerSemicircle = (d2 == 25 && y >= 0);
        bool onBottomStraightEdges = (y == 0 && d2 >= 25 && d2 <= 100);

        if (onOuterSemicircle || onInnerSemicircle || onBottomStraightEdges)
        {
            Console.WriteLine("На межі");
        }
// 2. Перевірка: чи лежить точка ВСЕРЕДИНІ (Так)
        else if (d2 > 25 && d2 < 100 && y > 0)
        {
            Console.WriteLine("Так");
        }
// 3. Якщо ні те, ні інше — значить точка ЗОВНІ (Ні)
        else
        {
            Console.WriteLine("Ні");
        }
    }
}

