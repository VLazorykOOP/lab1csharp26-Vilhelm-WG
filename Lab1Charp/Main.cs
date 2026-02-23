using Lab1Charp;

// Меню запускається першим (це єдина точка входу)
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Lab 1 - меню");
    Console.WriteLine("2 - Task 2 (перевірка парності)");
    Console.WriteLine("1 - Task 1 (відстань між точками)");
    Console.WriteLine("0 - Вихід");
    Console.Write("Ваш вибір: ");

    string? choice = Console.ReadLine();

    Console.WriteLine();

    switch (choice)
    {
        case "2":
            Task_2.Run();
            break;
        
        case "1":
            Task1.Run();
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            break;
    }
}