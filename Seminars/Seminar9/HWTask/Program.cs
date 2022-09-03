// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

class Program
{
    static void Main()
    {
        // Задача 64
        static string Task64(int m, int n)
        {
            string result = "";
            for (int i = m; i < n; i++)
            {
                result += i + ", ";
            }
            result += $"{n}";
            return result;
        }

        // Задача 66
        static int Task66(int m, int n)
        {
            int result = 0;
            for (int i = m; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        // Задача 68
        static int Task68(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Task68(m - 1, 1);
            }
            else
            {
                return Task68(m - 1, Task68(m, n - 1));
            }
        }

        while (true)
        {
            Console.WriteLine("Введите M и N");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Задача 64: " + Task64(m, n));
            Console.WriteLine("Задача 66: " + Task66(m, n));
            Console.WriteLine("Задача 68: " + Task68(m, n));

        }
    }
}