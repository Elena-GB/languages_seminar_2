// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//  void ThreeDigital(int num)
//  {
//      int res = (num % 100 - num % 10) / 10;
//      if(num >= 100 && num < 1000)
//      {
//          System.Console.WriteLine($"The second number of a three digital number {num} -> {res}");
//      }
//      else
//      {
//         System.Console.WriteLine("The digit is not a three digital number");
//     }
// }
// System.Console.WriteLine("Input a three digital number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ThreeDigital(num);     

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void ThirdDigit(int num)
// {
//     if (num < 100)
//     {
//         System.Console.Write($"{num} -> третьей цифры нет ");
//     }
//     else if (num > 99 && num < 1000)
//     {
//         int one = num % 10;
//         System.Console.Write($"{num} -> {one} ");
//     }
//     else if (num > 999 && num < 10000)
//     {
//         int two = num % 100;
//         System.Console.Write($"{num} -> {two / 10} ");
//     }
//     else if (num > 9999 && num < 100000)
//     {
//         int three = num % 1000;
//         System.Console.Write($"{num} -> {three / 100} ");
//     }
//     else if (num > 99999 && num < 1000000)
//     {
//         int four = num % 10000;
//         System.Console.Write($"{num} -> {four / 1000} ");
//     }
//     else if (num > 999999 && num < 10000000)
//     {
//        int five = num % 100000;
//        System.Console.Write($"{num} -> {five / 10000} ");
//     }
//     else if (num > 9999999 && num < 100000000)
//     {
//        int six = num % 1000000;
//        System.Console.Write($"{num} -> {six / 100000} ");
//     }
//     else if (num > 99999999 && num < 1000000000)
//     {
//        int six = num % 10000000;
//        System.Console.Write($"{num} -> {six / 1000000} ");
//     }
//     else if (num > 99999999 && num < 2147483647)
//     {
//        int six = num % 100000000;
//        System.Console.Write($"{num} -> {six / 10000000} ");
//     } 
//     else 
//     {
//         System.Console.Write("Указанное число лежит вне диапазона int (от -2147483648 до 2147483647)");
//     }
// }
// System.Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ThirdDigit(num);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// void WeekDayNumber(int num)
// {
//     if (num >= 6 && num < 8)
//     {
//        System.Console.Write($"{num} -> да");  
//     }
//     else
//     {
//        System.Console.Write($"{num} -> нет"); 
//     }
// }

// System.Console.Write("Input a number of the week's day (where monday = 1, and sunday = 7): ");
// int num = Convert.ToInt32(Console.ReadLine());
// WeekDayNumber(num);     






