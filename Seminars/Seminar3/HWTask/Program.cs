using System;

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

    static double[] CoordStringToVector(string point) //Преобразует строку с координатами в вектор.
    {
        string[] pointCoords = point.Split(',');
        double[] vector = new double[pointCoords.Length];
        for (int i = 0; i < pointCoords.Length; i++)
        {
            vector[i] = Convert.ToDouble(pointCoords[i].Trim());
        }
        return vector;
    }

    static double LengthBetween(double[] point1, double[] point2) // Вычисляет расстояние между двумя векторами
    {
        double length = 0;
        int i = 0;
        while (i < point1.Length && i < point2.Length)
        {
            length += Math.Pow(point1[i] - point2[i], 2);
            i++;
        }

        length = Math.Sqrt(length);

        return length;
    }


    static void HomeWorkTask21()
    {
        /*          Задача 21
         Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

         A (3,6,8); B (2,1,-7), -> 15.84

         A (7,-5, 0); B (1,-1,9) -> 11.5326 */

        Console.WriteLine("Введите координаты первой точки");
        string pointA = Console.ReadLine();
        Console.WriteLine("Введите координаты второй точки");
        string pointB = Console.ReadLine();

        double[] coordinatesA = CoordStringToVector(pointA);
        double[] coordinatesB = CoordStringToVector(pointB);

        double lineLength = LengthBetween(coordinatesA, coordinatesB);
        Console.WriteLine("Расстояние между точками: ");
        Console.WriteLine(lineLength);

    }

    static void HomeWorkTask23()
    {
        /*         Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

                3 -> 1, 8, 27
                5 -> 1, 8, 27, 64, 125 */
        Console.WriteLine("Введите число: ");
        int numberN = Console.ReadLine();

        for (int i, i< numberN, i++)
        {
            Console.Write(Math.Pow(i,3)+", ");
        }
        Console.WriteLine(Math.Pow(numberN,3));
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
