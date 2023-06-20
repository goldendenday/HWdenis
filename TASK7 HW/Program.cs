// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты первой точки через пробел:");
int[] fp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
System.Console.WriteLine("Введите координаты второй точки через пробел:");
int[] sp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(fp[0]-sp[0], 2) + Math.Pow(fp[1]-sp[1], 2) + Math.Pow (fp[2]-sp[2],2)), 2));
