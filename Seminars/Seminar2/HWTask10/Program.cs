/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

using System;

class Program
{
    static void Main(string[] args)
    {
        //Вариант 1
        /*Console.WriteLine("Введите трехзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());
        int figure = (number % 100) / 10;
        Console.WriteLine(figure); */

        //Вариант 2
        Console.WriteLine("Введите трехзначное число:");
        string number = Console.ReadLine();
        char[] figure = number.ToCharArray();

        Console.WriteLine(figure[1]);
    }
}