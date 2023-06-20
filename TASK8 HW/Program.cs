// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введи число от 1");
int number = Convert.ToInt32(Console.ReadLine());
for (int index = 1; index <= number; index++)
{
System.Console.Write(Math.Pow(index, 3) + " ");
}
