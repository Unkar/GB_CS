/* Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

while (true)
{
    Console.WriteLine("Нахождение максимального из трёх чисел");

    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    int max = number1;

    if (number2 > max)
    {
        max = number2;
    }
    else if (number3 > max)
    {
        max = number3;
    }

    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
    
    Console.WriteLine("Повторим ещё раз? (Y/N)");
    string continueRequest = Console.ReadLine();
    if (continueRequest.ToLower() == "n")
    {
        break;
    }
}