class Program
{
    /*     Задача 41: Пользователь вводит с клавиатуры M чисел.
     Посчитайте, сколько чисел больше 0 ввёл пользователь.

    0, 7, 8, -2, -2 -> 2

    1, -7, 567, 89, 223-> 3 */
    static void HomeWorkTask41()
    {
        Console.WriteLine("Введите несколько чисел с клавиатуры: ");
        string[] array = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (var item in array)
        {
            count += int.Parse(item) > 0 ? 1 : 0;
        }
        Console.WriteLine($"Строке {count} чисел больше 0");
    }

    /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
    static double[] CoordStringToVector(string point) //Преобразует строку с числами в вектор. Скопировал из предыдущего задания обработчик строки в массив чисел
    {
        string[] pointCoords = point.Split(',', StringSplitOptions.RemoveEmptyEntries);
        double[] vector = new double[pointCoords.Length];
        for (int i = 0; i < pointCoords.Length; i++)
        {
            vector[i] = Convert.ToDouble(pointCoords[i].Trim());
        }
        return vector;
    }

    static bool CheckPossibilityOfIntersection(double[] array)                      // Проверка на возможность пересечения. Если к1 и К2 равны, то пересечение не возможно.
    {
        return array[0] != array[2] ? true : false;
    }

    static bool CheckCoincide(double[] array)                                       // проверка на совпадение прямых
    {
        return (array[0] == array[2]) && (array[1] == array[3]) ? true : false;
    }


    static void GetIntersection(double[] array)                                                 // решение системы линейных уравнений, получение координат пересечения и вывод
    {
        double pointX = (array[3] - array[1]) / (array[0] - array[2]);
        double pointY = array[0] * pointX + array[1];
        Console.WriteLine($"Координаты точки пересечения двух прямых: X={pointX}, Y={pointY}");
    }
    static void HomeWorkTask43()
    {
        Console.WriteLine("Введите коэфициенты k1, b1 и k2, b2 через запятую: ");
        double[] array = CoordStringToVector(Console.ReadLine());
        if (CheckCoincide(array))                                                                                   // проверяем на совпадение прямых
        {
            Console.WriteLine("Прямые совпадают полностью и имеют бесконечное множество пересечений");
        }
        else if (!CheckPossibilityOfIntersection(array))                                                             //проверяем на возможность пересечения
        {
            Console.WriteLine("Пересечение параллельных прямых невозможно");
        }
        else
        {
           
           GetIntersection(array);
        }
    }
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Введите номер задачи 41 или 43 или Q для выхода:");
            string taskNumber = Console.ReadLine();

            if (taskNumber == null || taskNumber.ToLower() == "q")
            {
                running = false;
            }

            switch (taskNumber)
            {
                case "41":
                    HomeWorkTask41();
                    break;
                case "43":
                    HomeWorkTask43();
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