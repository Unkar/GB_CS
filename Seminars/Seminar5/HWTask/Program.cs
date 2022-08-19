class Program
{
    /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/
    static int[] CreateRandomIntArray(int arraySize, int minRange, int maxRange) //Создание массива из целых числел
    {
        int[] array = new int[arraySize];
        Random rng = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = rng.Next(minRange, maxRange);
        }
        return array;
    }

    static bool GetEvenStatus(int number)                                        //Проверка на чётность 
    {
        return (number % 2 == 0 ? true : false);
    }

    static int GetCountEven(int[] array)                                         //Считаем четные   
    {
        int count = 0;
        foreach (var item in array)
        {
            count += (GetEvenStatus(item) ? 1 : 0);
        }
        return count;
    }

    static void HomeWorkTask34()
    {
        Console.WriteLine("Задайте размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = CreateRandomIntArray(size, 100, 999);
        Console.WriteLine($@"Сгенерированный массив:
        {String.Join(" ", array)}");
        Console.WriteLine($"Количество четных чисел в массиве: {GetCountEven(array)}");
    }
    /* Задача 36: Задайте одномерный массив, заполненный случайными числами.
     Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19

    [-4, -6, 89, 6] -> 0 */

    static int GetSumOddPosition(int[] array)                                       //считаем сумму на нечетных позициях
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i = i + 2)
        {
            sum += array[i];
        }
        return sum;
    }
    static void HomeWorkTask36()                                                      
    {
        Console.WriteLine("Задайте размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = CreateRandomIntArray(size, 1, 10);
        Console.WriteLine($@"Сгенерированный массив:
        {String.Join(" ", array)}");
        Console.WriteLine($"Сумма элементов на нечетных позициях:{GetSumOddPosition(array)}");
    }

    /*     Задача 38: Задайте массив вещественных чисел.
     Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76 */
    static double[] CreateRandomDoubleArray(int arraySize, int minRange, int maxRange) //Создание массива из вещественных числел
    {
        double[] array = new double[arraySize];
        Random rng = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = rng.Next(minRange, maxRange) * rng.NextDouble();                 // генерация вещественных
        }
        return array;
    }

    static double GetMaxOfDoubleArray(double[] array)                                   // поиск максимума в массиве
    {
        double max = array[0];
        foreach (var item in array)
        {
            max = (max < item ? item : max);
        }
        return max;
    }

    static double GetMinOfDoubleArray(double[] array)                                   // поиск минимума в массиве
    {
        double min = array[0];
        foreach (var item in array)
        {
            min = (min > item ? item : min);
        }
        return min;
    }
    static void HomeWorkTask38()
    {
        Console.WriteLine("Задайте размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        double[] array = CreateRandomDoubleArray(size, -10, 10);

        Console.WriteLine($@"Сгенерированный массив:
        {String.Join(" ", array)}");
        Console.WriteLine($"Разница между максимальным и минимальным значением в массиве:{GetMaxOfDoubleArray(array) - GetMinOfDoubleArray(array)}");
    }
    static void Main(string[] args)
    {
        string taskText = @"+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ 

+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234]-> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12]-> 19
[-4, -6, 89, 6]-> 0

Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78]-> 76";
        bool running = true;
        while (running)
        {
            Console.WriteLine(@"Введите номер задачи 34, 36 или 38, L для текста заданий или Q для выхода: ");
            string taskNumber = Console.ReadLine().ToLower();
            

            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "34":
                    HomeWorkTask34();
                    break;
                case "36":
                    HomeWorkTask36();
                    break;
                case "38":
                    HomeWorkTask38();
                    break;
                case "q":
                    running = false;
                    break;
                case "l":
                    Console.WriteLine(taskText);
                     break;
                default:
                    break;
            }
        }

    }
}