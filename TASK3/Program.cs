int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse); //Заполняем массив при помощи строки

System.Console.WriteLine(string.Join(" | ", numbers)); // Вывод массива через string.Join

