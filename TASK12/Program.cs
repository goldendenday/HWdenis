//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        // задаем размеры массива
        int m = 4;
        int n = 5;

        // создаем двумерный массив
        double[,] array = new double[m, n];

        // заполняем массив случайными вещественными числами
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble();
            }
        }

        // выводим массив на экран
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(Math.Round(array[i, j],2) + "\t");
            }
            Console.WriteLine();
        }


