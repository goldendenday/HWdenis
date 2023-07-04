int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        // вычисляем среднее значение элементов в каждом столбце
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);
        double[] columnAverages = new double[numCols];
        for (int j = 0; j < numCols; j++) {
            int columnSum = 0;
            for (int i = 0; i < numRows; i++) {
                columnSum += array[i, j];
            }
            columnAverages[j] = (double)columnSum / numRows;
        }

        // выводим результат на экран
        Console.WriteLine("Среднее значение элементов в столбцах:\n");
        for (int j = 0; j < numCols; j++) {
            Console.WriteLine("Столбец {0}: {1}", j, columnAverages[j].ToString("F2"));
        }