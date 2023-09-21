// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

 void ThreeDigital(int num)
 {
     int res = (num % 100 - num % 10) / 10;
     if(num >= 100 && num < 1000)
     {
         System.Console.WriteLine($"The second number of a three digital number {num} -> {res}");
     }
     else
     {
        System.Console.WriteLine("The digit is not a three digital number");
    }
}
System.Console.WriteLine("Input a three digital number: ");
int num = Convert.ToInt32(Console.ReadLine());
ThreeDigital(num);     

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    
}

