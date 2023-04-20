// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a == b)
// {
//    Console.Write("числа равны");
// }
// else if (a > b)
// {
//    Console.Write("max = " + max);
// }
// else
// {
//    max = b;
//    Console.Write("max = " + max);
// }

///////////////////////////////////////////////////////////////////////////////
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
//из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;

// if (max < b)
// {
//    max = b;
// }

// if (max < c)
// {
//    max = c;
// }

// else
// {
//    Console.Write("Числа равны");
// }

// Console.Write("max = " + max);

///////////////////////////////////////////////////////////////////////////////

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число: ");
// double a = Convert.ToDouble(Console.ReadLine());
// a = a % 2;

// if (a == 0)
// {
//    Console.Write("да");
// }
// else
// {
//    Console.Write("нет");
// }

///////////////////////////////////////////////////////////////////////////////

// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 2;

// while (count <= N)
// {
//    Console.Write(" " + count);
//    count = count + 2;
// }

///////////////////////////////////////////////////////////////////////////////

// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
// которая принимает на вход целое число любой разрядности и на выходе показывает 
// вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());

// N = N / 10;
// Console.WriteLine(N);

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 9)
{
   while (N > 99)
   {
      N = N / 10;
   }
   Console.Write(N % 10);
}
else
{
   Console.Write("нет");
}
