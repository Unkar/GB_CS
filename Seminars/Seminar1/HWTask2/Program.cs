while (true)
{
    Console.WriteLine("Сравнение двух чисел.");

    Console.WriteLine("Введите первое число a: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число b: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 > number2)
    {
        Console.WriteLine("Наибольшее число: ");
        Console.WriteLine(number1);

        Console.WriteLine("Наименьшее число: ");
        Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine("Наибольшее число: ");
        Console.WriteLine(number2);

        Console.WriteLine("Наименьшее число: ");
        Console.WriteLine(number1);
    }
    Console.WriteLine("Повторим ещё раз? (Y/N)");
    string continueRequest = Console.ReadLine();
    if (continueRequest.ToLower() == "n")
    {
        break;
    }
}