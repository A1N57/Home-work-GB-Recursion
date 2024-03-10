
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Выводим элементы массива, начиная с конца, в одну строку с использованием рекурсии
        PrintArrayReverse(array, array.Length - 1);
    

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            // Выводим текущий элемент с запятой
            Console.Write(arr[index]);

            // Добавляем запятую, если это не последний элемент
            if (index > 0)
            {
                Console.Write(", ");
            }

            // Рекурсивно вызываем функцию для предыдущего элемента
            PrintArrayReverse(arr, index - 1);
        }
    }

