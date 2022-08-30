using System;

class Program
{
    // Задача 47. Задайте двумерный массив размером m×n,
    //  заполненный случайными вещественными числами.

    // m = 3, n = 4.

    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    static double[,] CreateRandomDouble2DimentionArray(int rowsQuantity, int columnsQuantity, int minRange, int maxRange) //Создание массива из вещественных числел
    {
        double[,] array = new double[rowsQuantity, columnsQuantity];
        Random rng = new Random();
        for (int i = 0; i < rowsQuantity; i++)
        {
            for (int j = 0; j < columnsQuantity; j++)
            {
                array[i, j] = Math.Round(rng.Next(minRange, maxRange) * rng.NextDouble(), 1);
            }
        }
        return array;
    }

    static void OutputFormated2DimentionArray(double[,] array) // Вывод массива в нужном формате для double[,]
    {
        Console.WriteLine($"Выводим сгенерированный отформатированный массив:");
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = "";
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += $"{array[i, j]} "; // добавлем разделители
            }
            result = result.Trim();
            Console.WriteLine(result);
        }
    }

    static void HomeWorkTask47()
    {
        int minRange = -10;
        int maxRange = 10;
        Console.WriteLine("Генерация массива. Введите количество строк: ");
        int rowsQuantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Генерация массива. Введите количество столбцов: ");
        int columnsQuantity = Convert.ToInt32(Console.ReadLine());
        double[,] generatedArray = CreateRandomDouble2DimentionArray(rowsQuantity, columnsQuantity, minRange, maxRange);
        OutputFormated2DimentionArray(generatedArray);
    }

    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    //  и возвращает значение этого элемента или же указание, что такого элемента нет.

    // Например, задан массив:

    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4

    // 17 -> такого числа в массиве нет
    // Внимание!!! Некорректно поставлено условие. Пишем согласно примеру.
    //  На ввод принимается число и выводим его положение в массиве или укзывает, что такого элемента нет.
    static int[,] CreateRandomInt2DimentionArray(int rowsQuantity, int columnsQuantity, int minRange, int maxRange) //Создание массива из целых числел
    {
        int[,] array = new int[rowsQuantity, columnsQuantity];
        Random rng = new Random();
        for (int i = 0; i < rowsQuantity; i++)
        {
            for (int j = 0; j < columnsQuantity; j++)
            {
                array[i, j] = rng.Next(minRange, maxRange);
            }
        }
        return array;
    }

    static void OutputFormatedInt2DimentionArray(int[,] array) // Вывод массива в нужном формате для int[,]
    {
        Console.WriteLine($"Выводим сгенерированный отформатированный массив:");
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = "";
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += $"{array[i, j]} "; // добавлем разделители
            }
            result = result.Trim();
            Console.WriteLine(result);
        }
    }

    static void WritePositionInArray(int value, int[,] array)                      //выводит позицию искомого числа в массиве
    {
        bool found = false;
        int[] result = new int[2];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == value)
                {
                    result[0] = i;
                    result[1] = j;
                    Console.WriteLine($"Число {value} находится на строке {i + 1} в столбце {j + 1}.");
                    found = true;
                }
            }
        }
        if (!found) Console.WriteLine("Такого числа в массиве нет.");
    }
    static void HomeWorkTask50()
    {
        int rowsQuantity = 5;
        int columnsQuantity = 5;
        int minRange = 0;
        int maxRange = 20;
        int[,] array = CreateRandomInt2DimentionArray(rowsQuantity, columnsQuantity, minRange, maxRange);
        Console.WriteLine("Введите искомое число: ");
        int desiredNumber = Convert.ToInt32(Console.ReadLine());
        OutputFormatedInt2DimentionArray(array);
        WritePositionInArray(desiredNumber, array);
    }

    // Задача 52. Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    static void WriteAvarageInColumns(int[,] array)                         //Выводит среднее арифметическое в столбцах
    {
        string result= String.Empty;
        double avarage = 0;
        Console.Write("Средние значения элементов по столбцам: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            avarage = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                avarage += array[i, j];
            }
            avarage = avarage / array.GetLength(0);
            if (j == array.GetLength(1) - 1)
            {
                Console.WriteLine($" {avarage}.");
            }
            else
            {
                Console.Write($" {avarage};");
            }
        }
    }
    static void HomeWorkTask52()
    {
        int rowsQuantity = 5;
        int columnsQuantity = 5;
        int minRange = 0;
        int maxRange = 10;
        int[,] array = CreateRandomInt2DimentionArray(rowsQuantity, columnsQuantity, minRange, maxRange);
        OutputFormatedInt2DimentionArray(array);
        WriteAvarageInColumns(array);
    }

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Введите номер задачи 47,50 или 52 или Q для выхода:");
            string taskNumber = Console.ReadLine();

            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "47":
                    HomeWorkTask47();
                    break;
                case "50":
                    HomeWorkTask50();
                    break;
                case "52":
                    HomeWorkTask52();
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