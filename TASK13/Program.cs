 int[,] array = { { 1, 5, 8 }, { 4, 9, 4 }, { 7, 2, 2 }, { 2, 3, 4 } };

        // запрос позиций элемента у пользователя
        Console.WriteLine("Введите позицию элемента в массиве.");
        Console.Write("Строка: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Столбец: ");
        int column = int.Parse(Console.ReadLine());

        // проверка корректности позиций элемента
        if (row >= array.GetLength(0) || column >= array.GetLength(1) || row < 0 || column < 0) {
            Console.WriteLine("Указанная позиция находится за пределами массива.");
        } else {
            // вывод значения элемента, если он существует
            Console.WriteLine("Значение элемента: {0}", array[row, column]);
        }

        // ожидание ввода перед завершением программы
        Console.ReadLine();
    
