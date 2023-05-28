// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void FillArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(100, 1000);
//    }
// }

// void PrintArray(int[] array)
// {
//    foreach (var item in array)
//    {
//       System.Console.Write($"{item} ");
//    }
//    System.Console.WriteLine();
// }

// int kol(int[] array)
// {
//    int kol = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] % 2 == 0)
//          kol = kol + 1;
//    }
//    return kol;
// }




// System.Console.WriteLine("Введите кол-во элементов в массиве:");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];

// FillArray(array);
// PrintArray(array);
// Console.Write($"Количество чётных чисел в массиве: {kol(array)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// void FillArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(-50, 200);
//    }
// }

// void PrintArray(int[] array)
// {
//    foreach (var item in array)
//    {
//       System.Console.Write($"{item} ");
//    }
//    System.Console.WriteLine();
// }

// int SummaNech(int[] array)
// {
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (i % 2 == 1)
//          sum = sum + array[i];
//    }
//    return sum;
// }




// System.Console.WriteLine("Введите кол-во элементов в массиве:");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];

// FillArray(array);
// PrintArray(array);
// Console.Write($"Количество чётных чисел в массиве: {SummaNech(array)}");




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0, 201) + new Random().NextDouble();
   }
}

void PrintArray(double[] array)
{
   foreach (var item in array)
   {
      System.Console.Write($"{Math.Round(item, 2)} ");
   }
   System.Console.WriteLine();
}

double SummaNech(double[] array)
{
   double min = array[0];
   double max = array[0];
   int i = 1;
   while (i < array.Length)
   {
      if (max < array[i])
         max = array[i];
      if (min > array[i])
         min = array[i];
      i++;
   }
   return max - min;
}




System.Console.WriteLine("Введите кол-во элементов в массиве:");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];

FillArray(array);
PrintArray(array);
double sum = SummaNech(array);
Console.Write($"Разница между max и min: {Math.Round(sum, 2)}");
