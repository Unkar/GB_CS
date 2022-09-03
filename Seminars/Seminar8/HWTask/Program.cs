class Program
{
    // Задача 54: Задайте двумерный массив. Напишите программу, 
    // которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

//Генерация двумерного массива
    static int[,] GenerateArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }
        return array;
    }
    //вывод двумерного целочисленного массива
    static void PrintIntArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    //сортировка в строках по убыванию
    static int[,] SortArrayByDescending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }
        return array;
    }
    static void HomeWorkTask54()
    {
        int rows = 3;
        int columns = 4;
        int[,] array = new int[rows, columns];
        array = GenerateArray(rows, columns);
        Console.WriteLine("Исходный массив:");
        PrintIntArray(array);
        Console.WriteLine("Отсортированный массив:");
        array = SortArrayByDescending(array);
        PrintIntArray(array);
    }

    // -----------------------------------------------------------------------------------------------

    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
    //  которая будет находить строку с наименьшей суммой элементов.

    // Например, задан массив:

    // 1 4 7 2

    // 5 9 2 3

    // 8 4 2 4

    // 5 2 6 7

    // Программа считает сумму элементов в каждой строке и
    //  выдаёт номер строки с наименьшей суммой элементов: 1 строка


    //поиск строки с наименьшей суммой элементов
    static int SumOfElementsInRow(int[,] array, int row)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[row, i];
        }
        return sum;
    }

    //поиск строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int minSum = SumOfElementsInRow(array, 0);
        int minSumRow = 0;
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int sum = SumOfElementsInRow(array, i);
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }
        return minSumRow;
    }
    static void HomeWorkTask56()
    {
        int rows = 4;
        int columns = 4;
        int[,] array = new int[rows, columns];
        array = GenerateArray(rows, columns);
        Console.WriteLine("Исходный массив:");
        PrintIntArray(array);
        int minSumRow = FindRowWithMinSum(array);
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
    }

    //-----------------------------------------------------------------------------

    // Задача 58: Задайте две матрицы. Напишите программу,
    //  которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

    //получение произведения двух матриц
    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
    static void HomeWorkTask58()
    {
        int[,] matrix1 = new int[2, 2];
        int[,] matrix2 = new int[2, 2];
        matrix1 = GenerateArray(2, 2);
        matrix2 = GenerateArray(2, 2);
        Console.WriteLine("Исходные матрицы:");
        PrintIntArray(matrix1);
        PrintIntArray(matrix2);
        int[,] result = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Результирующая матрица:");
        PrintIntArray(result);
    }

    //-----------------------------------------------------------------------------

    // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    //  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)
    
    //поиск числа в массиве
    static bool IsNumberInArray(int[,,] array, int number)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    if (array[i, j, k] == number)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    //получение трехмерного массива из неповторяющихся двузначных чисел
    static int[,,] Generate3DementionArray(int rows, int columns, int depth)
    {
        int[,,] array = new int[rows, columns, depth];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    int number = random.Next(10, 100);
                    while (IsNumberInArray(array, number))
                    {
                        number = random.Next(10, 100);
                    }
                    array[i, j, k] = number;
                }
            }
        }
        return array;
    }

    //вывод трехмерного массива
    static void Print3DArray(int[,,] array)
    {
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.GetLength(2); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    static void HomeWorkTask60()
    {
        int rows = 2;
        int columns = 2;
        int depth = 2;
        int[,,] array = new int[rows, columns, depth];
        array = Generate3DementionArray(rows, columns, depth);
        Print3DArray(array);
    }

    //-----------------------------------------------------------------------------

    // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07

    //получение спирального массива
    static int[,] GenerateSpriralArray(int rows, int columns)
    {
        int minRows = 0;
        int maxRows = rows - 1;
        int minColumns = 0;
        int maxColumns = columns - 1;
        int number = 1;
        int[,] array = new int[rows, columns];
        while (minRows <= maxRows && minColumns <= maxColumns)
        {
            for (int i = minColumns; i <= maxColumns; i++)
            {
                array[minRows, i] = number;
                number++;
            }
            minRows++;
            for (int i = minRows; i <= maxRows; i++)
            {
                array[i, maxColumns] = number;
                number++;
            }
            maxColumns--;
            for (int i = maxColumns; i >= minColumns; i--)
            {
                array[maxRows, i] = number;
                number++;
            }
            maxRows--;
            for (int i = maxRows; i >= minRows; i--)
            {
                array[i, minColumns] = number;
                number++;
            }
            minColumns++;
        }
        return array;
    }

    //добавление нулей в начало числа (лидирующие нули)
    static string[,] AddZeroBitToStringArray(int[,] array, int digits)
    {
        string[,] stringArray = new string[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                stringArray[i, j] = array[i, j].ToString();
                while (stringArray[i, j].Length < digits)
                {
                    stringArray[i, j] = "0" + stringArray[i, j];
                }
            }
        }
        return stringArray;
    }

    //вывод строкового массива в консоль
    static void PrintStringArray(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void HomeWorkTask62()
    {
        int rows = 5;
        int columns = 5;
        int digits = 2;
        int[,] array = new int[rows, columns];
        array = GenerateSpriralArray(rows, columns);
        string[,] stringArray = new string[rows, columns];
        stringArray = AddZeroBitToStringArray(array, digits);
        Console.WriteLine("Исходный массив:");
        PrintStringArray(stringArray);
    }


    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Введите номер задачи 54, 56, 58, 60 или 62 или Q для выхода:");
            string taskNumber = Console.ReadLine();


            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "54":
                    HomeWorkTask54();
                    break;
                case "56":
                    HomeWorkTask56();
                    break;
                case "58":
                    HomeWorkTask58();
                    break;
                case "60":
                    HomeWorkTask60();
                    break;
                case "62":
                    HomeWorkTask62();
                    break;
                case "q":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
            }
        }
    }
}