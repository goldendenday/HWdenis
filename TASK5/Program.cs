// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Vvedite chislo");
int number = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// while (index <= number)
// {
//     System.Console.Write(Math.Pow(index , 2)+ " ");
//     index++;
// }

for (int index = 1; index <= number; index++)
{
    System.Console.Write(Math.Pow(index, 2) + " ");
}
