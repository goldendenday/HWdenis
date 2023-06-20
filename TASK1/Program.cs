// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
System.Console.Write("Введите номер четверти: ");
int qw = Convert.ToInt32(Console.ReadLine());
string[] message = { "x > 0, y > 0", "x > 0, y < 0", "x < 0, y < 0", "x < 0, y > 0" };
if (qw == 1)
{
    System.Console.WriteLine(message[0]);
}
else if (qw == 2)
{
    System.Console.WriteLine(message[3]);
}
else if (qw == 3)
{
    System.Console.WriteLine(message[2]);
}
else if (qw == 4)
{
    System.Console.WriteLine(message[1]);
}
else
{
    System.Console.WriteLine("Такой четверти не существует!");
}