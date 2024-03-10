// Запрос у пользователя ввода значений m и n
        Console.Write("Введите значение m: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // Вычисляем и выводим значение функции Аккермана
                int result = AckermannFunction(m, n);
                Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод для n.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для m.");
        }
    

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }