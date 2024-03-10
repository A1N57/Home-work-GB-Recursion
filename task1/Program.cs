 // Запрос у пользователя ввода значений M и N
        Console.Write("Введите значение M: ");
        if (int.TryParse(Console.ReadLine(), out int M))
        {
            Console.Write("Введите значение N: ");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                // Выводим все натуральные числа в промежутке от M до N
                PrintNaturalNumbersInRange(M, N);
            }
            else
            {
                Console.WriteLine("Некорректный ввод для N.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для M.");
        }


    static void PrintNaturalNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            // Выводим текущее число
            Console.WriteLine(start);

            // Рекурсивно вызываем функцию для следующего числа
            PrintNaturalNumbersInRange(start + 1, end);
        }
    }

