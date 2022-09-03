//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число A");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число B");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("A в степени B = " + Power(a, b));
        Console.ReadKey();
    }

    static int Power(int a, int b)
    {
        if (b == 0)
            return 1;
        else
            return a * Power(a, b - 1);
    }
}