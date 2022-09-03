// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 6, 7, 3, 6 };
        int[] arr3 = new int[arr.Length];
        int[] arr4 = new int[arr2.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr3[i] = arr[i] * arr[arr.Length - 1 - i];
            arr4[i] = arr2[i] * arr2[arr2.Length - 1 - i];
        }
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.Write(arr3[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < arr4.Length; i++)
        {
            Console.Write(arr4[i] + " ");
        }
    }
}