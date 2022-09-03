//Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine("Сумма цифр числа равна {0}", sum);
        Console.ReadKey();
    }
}

