﻿using System;

class Program
{
    static void FindPalindrome()
    {
        /* Задача 19
        Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        14212 -> нет
        12821 -> да
        23432 -> да */

        Console.WriteLine("Введите число для определения палиндрома: ");
        string number = Console.ReadLine();

        int index = 0;
        bool running = true;
        while (index < number.Length / 2 && running)
        {
            if (number[index] == number[number.Length - index - 1])
            {
                index++;
            }
            else
            {
                Console.WriteLine("Число не палиндром");
                running = false;
            }
            if (index >= number.Length / 2) Console.WriteLine("Число палиндром");
        }
    }

    static void HomeWorkTask21()
    {

    }

    static void HomeWorkTask23()
    {

    }

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Введите номер задачи 19, 21 или 23 или Q для выхода:");
            string taskNumber = Console.ReadLine();

            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "19":
                    FindPalindrome();
                    break;
                case "21":
                    HomeWorkTask21();
                    break;
                case "23":
                    HomeWorkTask23();
                    break;
                case "q":
                    running = false;
                    break;
                default:
                    break;
            }
        }
    }
}
