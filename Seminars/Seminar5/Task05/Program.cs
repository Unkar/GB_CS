class Program
{
    /*     **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
     значения которых лежат в отрезке [10,99].

    *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

    [5, 18, 123, 6, 2] -> 1

    [1, 2, 3, 6, 2] -> 0

    [10, 11, 12, 13, 14] -> 5

    **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
     второй и предпоследний и т.д. Результат запишите в новом массиве.

    [1 2 3 4 5] -> 5 8 3

    [6 7 3 6] -> 36 21
     */

    static int[] CreateRandomIntArray(int numberN) //Создание массива из целых числел
    {
        int[] array = new int[numberN];
        Random rng = new Random();
        for (int i = 0; i < numberN; i++)
        {
            array[i] = rng.Next(0, 200);
        }
        return array;
    }

    static int CountInclusion(int[] array)
    {
        int minRange = 10;
        int maxRange = 90;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            count += (array[i] >= minRange && array[i] <= maxRange) ? 1 : 0;
        }
        return count;
    }
    static void ClassWorkTask35()
    {
        int[] array = CreateRandomIntArray(123);
        //Console.WriteLine(array);
        Console.WriteLine($"Количество элементов массива, которые лежат в диапазоне [10,90]: {CountInclusion(array)}");
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
    static void HomeWorkTask37()
    {
        int[] array = CreateRandomIntArray(11);
        int[] newArray = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] + array[array.Length - 1];
        }
        if (array.Length % 2 == 1)
        {
            newArray[array.Length / 2] = array[array.Length / 2];
        }
        OutputFormatedArray(array);
        OutputFormatedArray(newArray);
    }
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Введите номер задачи 35 или 37 или Q для выхода:");
            string taskNumber = Console.ReadLine();

            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "35":
                    ClassWorkTask35();
                    break;
                case "37":
                    HomeWorkTask37();
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
