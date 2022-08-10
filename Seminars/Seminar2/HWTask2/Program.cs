/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число:");
        string number = Console.ReadLine();
        char[] figure = number.ToCharArray();


        if (figure.Length > 2)
        {
            Console.WriteLine(figure[2]);
        }
        else
        {
            Console.WriteLine("третьей цифры нет");
        }
    }
}