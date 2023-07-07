// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива. 
int num = 0;
int rows = Input ("Введите количество строк");
int colum = Input ("Введите количество столбцов");
int [,] array = new int [rows,colum];
array = FillArray(array);
PrintArray(array);
int [,] arraySort = ArraySort(array);
Console.WriteLine();
PrintArray(arraySort);


int Input (string message){
    Console.WriteLine(message);
    string text = Console.ReadLine();
    Check(text);
    return num;
}

void Check (string t){
    if (Int32.TryParse(t,out num))  {
        if (num > 0) {}
            else {
        Console.WriteLine("Введено некорректное значение");
        Input("Повторите ввод");
    }
    } else {
        Console.WriteLine("Введено некорректное значение");
        Input("Повторите ввод");
    }
}
int [,] FillArray (int [,] ar){
    Console.WriteLine("Введите нижнюю границу чисел массива");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу чисел массива");
    int k = Convert.ToInt32(Console.ReadLine()); 
    if (k < l) {
        Console.WriteLine("Ошибочно заданы границы. Возвращен нулевой массив");
        return ar;
    }
    Random rnd = new Random();
    for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
            ar[i,j] = rnd.Next(l,k);
        }
    }
    return ar;
}
int [,] ArraySort (int [,] arr){
    int [] temp = new int [arr.GetLength(1)];
    for (int i = 0;i < arr.GetLength(0);i++){
        for (int j = 0;j < arr.GetLength(1);j++){
            temp[j] = arr[i,j];
        }
        Array.Sort(temp, (x, y) => y.CompareTo(x));
    
        for (int j = 0;j < arr.GetLength(1);j++){
            arr[i,j] = temp[j];
        }
    }
    return arr;
}

void PrintArray <T> (T [,] ar){
     for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
           Console.Write(ar[i,j] + " ");
        }
        Console.WriteLine();
    }
}
// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

rows = Input ("Введите количество строк");
colum = Input ("Введите количество столбцов");
int [,] array1 = new int [rows,colum];
array1 = FillArray(array1);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Наименьшая сумма элементов в строке -> " + MinSum(array1));

int MinSum (int [,] ar){
    int minSum = int.MaxValue;
    int minIndex = 0;
    int sum = 0;
    for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
          sum += ar[i,j];
        }
        if (sum < minSum){
            minSum = sum;
            minIndex = i;
        }
        sum = 0;
    }
    return minIndex + 1;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int size = Input("Задайте размер матриц");
int [,] arr1 = new int [size,size];
int [,] arr2 = new int [size,size];
int [,] arrResult = new int [size,size];
Console.WriteLine("Заполнить массив 1");
arr1 = FillArray(arr1);
Console.WriteLine("Заполнить массив 2");
arr2 = FillArray(arr2);
arrResult = ArrayMultiplication(arr1,arr2,arrResult);
Console.WriteLine ("Первый массив");
PrintArray(arr1);
Console.WriteLine("Второй массив");
PrintArray(arr2);
Console.WriteLine("Результат перемножения");
PrintArray(arrResult);

int [,] ArrayMultiplication (int [,] ar1, int [,] ar2, int [,] ar3){
    for (int i = 0;i < ar1.GetLength(0);i++){
        for (int j = 0;j < ar1.GetLength(1);j++){
            for (int k = 0;k < ar2.GetLength(0);k++){
                ar3 [i,j] += ar1[i,k] * ar2 [k,j];
        }
    }
}
return ar3;
} 

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int siz = Input("Задайте размер массива от 2 до 4");
int [,,] array3D = new int [siz,siz,siz];
int [] tempArray = new int [siz * siz * siz];
tempArray = FillArrayTemp(tempArray);
array3D = FillArray3D(array3D);
PrintArray3D(array3D);

int [] FillArrayTemp(int [] ar){
    Random rnd = new Random();
    int temp = 0;
    bool isCompare = true;
    for (int i = 0; i < ar.Length; i++){
        while(true){
            temp = rnd.Next(10,100);
            for (int j=0; j < ar.Length;j++){
                if (temp == ar[j])
                    isCompare = false;
            }
            if (isCompare) {
                ar[i] = temp;
                break;
            }
        isCompare = true;
        }
    }
return ar;
}
int [,,] FillArray3D (int [,,] ar){
    int count = 0;
      for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
            for (int k = 0;k < ar.GetLength(2);k++){
                ar [i,j,k] = tempArray[count++];
        }
    }
}
return ar;  
}

void PrintArray3D (int [,,] ar){
   for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
            for (int k = 0;k < ar.GetLength(2);k++){
               Console.Write(ar [i,j,k] + "(" + i +"," + j + "," + k + ") ");
            }
        Console.WriteLine();
        }  
     }
} 

// Напишите программу, которая заполнит спирально массив 4 на 4.

int row = Input ("Введите количество строк");
int col= Input ("Введите количество столбцов");
string [,] arraySpiral = new string [row,col];
arraySpiral = FillArraySpiral(arraySpiral);
PrintArray(arraySpiral); 
    
string [,] FillArraySpiral (string [,] ar){
    int I0 = 0, In = 0, J0 = 0, Jn = 0;
    int k = 1, i = 0, j = 0;
    
    while (k <= row * col){;
        if (k < 10)
            ar[i,j] = "0" + k.ToString();
        else
            ar[i,j] = k.ToString();
        if (i == I0 && j < col - Jn - 1)
            j++;
        else if (j == col - Jn - 1 && i < row - In - 1)
            i++;
        else if (i == row - In - 1 && j > J0)
            j--;
        else
            i--;

        if ((i == I0 + 1) && (j == J0) && (J0 != col - Jn - 1)){
            I0++;
            In++;
            J0++;
            Jn++;
        }
        k++;
    }
    return ar;
}