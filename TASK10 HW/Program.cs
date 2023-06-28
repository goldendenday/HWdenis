 Random random = new Random();
 int[] arr = new int[10];
 int sum = 0;
for (int i = 0; i < arr.Length; i++) {
    arr[i] = random.Next(1, 100);
    Console.Write(arr[i] + " ");
        }

for (int i = 1; i < arr.Length; i+=2)
 {
sum += arr[i];
 }
Console.WriteLine("\nСумма элементов на нечетных позициях: " + sum);
   