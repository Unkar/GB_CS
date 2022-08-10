/* Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа проверяет является ли день недели выходным.");
        Console.WriteLine("Введите номер дня недели: ");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());
        switch (dayOfWeek)
        {
            case > 7:
                Console.WriteLine("Нет такого дня недели.");
                break;

            case < 6:
                Console.WriteLine("День не является выходным.");
                break;

            default:
                Console.WriteLine("Это выходной день.");
                break;
        }
    }


}