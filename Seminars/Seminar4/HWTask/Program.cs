using System;

class Program
{
    static double LoopForTask25(double x, double y) // Цикл для возведения X в степень Y
    {
        double result = 1;
        for (int i = 0; i < y; i++) result *= x;
        return result;
    }

    static double[] CoordStringToVector(string point) //Преобразует строку с координатами в вектор. Скопировал из предыдущего задания обработчик строки в массив чисел
    {
        string[] pointCoords = point.Split(',');
        double[] vector = new double[pointCoords.Length];
        for (int i = 0; i < pointCoords.Length; i++)
        {
            vector[i] = Convert.ToDouble(pointCoords[i].Trim());
        }
        return vector;
    }

    static void HomeWorkTask25()
    {
        /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

            3, 5 -> 243 (3⁵)

            2, 4 -> 16 */

        Console.WriteLine("Введите 2 числа через запятую ");
        double[] numbers = CoordStringToVector(Console.ReadLine());
        Console.WriteLine($"{numbers[0]} в степени {numbers[1]} равно {LoopForTask25(numbers[0], numbers[1])} ");
    }

    static int GetFigure(int number, int position) //получение цифры числа по разряду
    {
        int figure = number / Convert.ToInt32(Math.Pow(10, position-1)) % 10; // Сначала отсекаем младшие разряды целочисленным делением, а потом берем остаток от деления на 10.
        return figure;
    }

    static void HomeWorkTask27()
    {
        /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

        452 -> 11

        82 -> 10

        9012 -> 12 */

        /*      Console.WriteLine("Введите число: ");  // вариант №1
                string number = Console.ReadLine();
                double sumFigure = 0;
                for (int i=0; i < number.Length; i++)
                {
                    sumFigure += Char.GetNumericValue(number[i]);

                }
                Console.WriteLine($"Сумма цифр числа {number} равна {sumFigure}"); */

        Console.WriteLine("Введите число для рассчёта суммы цифр: ");  // вариант №2
        string numberString = Console.ReadLine();
        int numberInt = Convert.ToInt32(numberString);
        double sumFigure = 0;
        for (int i = 1; i<=numberString.Length; i++)
        {
            sumFigure += GetFigure(numberInt,i);
        }   
        Console.WriteLine($"Сумма цифр числа {numberInt} равна {sumFigure}");
    }

    static int[] CreateRandomIntArray(int numberN) //Создание массива из целых числел
    {
        int[] array = new int[numberN];
        Random rng = new Random();
        for (int i = 0; i < numberN; i++)
        {
            array[i] = rng.Next(0, 99);
        }
        return array;

    }

    static void OutputFormatedArray(int[] array) // Вывод массива в нужном формате
    {
        string prefix = "[";
        string sufix = "]";
        string result = "";
        foreach (int item in array)
        {
            result += $" {item},"; // добавлем разделители
        }
        result = result.Trim(' ', ','); // обрезка начала и конца строки от разделителей
        Console.WriteLine($"Выводим сгенерированный отформатированный массив:");
        Console.WriteLine($"{prefix}{result}{sufix}");
    }
    static void HomeWorkTask29()
    {
        /* Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

        1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

        6, 1, 33 -> [6, 1, 33] */

        Console.WriteLine("Введите размер массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
        OutputFormatedArray(CreateRandomIntArray(arrayLength));

    }

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Введите номер задачи 25, 27 или 29 или Q для выхода:");
            string taskNumber = Console.ReadLine();

            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "25":
                    HomeWorkTask25();
                    break;
                case "27":
                    HomeWorkTask27();
                    break;
                case "29":
                    HomeWorkTask29();
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