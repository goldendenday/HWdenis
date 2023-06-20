// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
System.Console.Write("Введите номер четверти: ");
int qw = Convert.ToInt32(Console.ReadLine());
string[] message = { "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0" };

if (qw > 0 && qw < 5)
{
    System.Console.WriteLine(message[qw - 1]);
}
else
{
    System.Console.WriteLine("Такой четверти не существует!");
}
