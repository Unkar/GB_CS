/* Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

while (true)
{
    Console.WriteLine("Вывести все чётные числа от 1 до N");

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    int count = 2;

    while (count <= numberN)
    {
        Console.Write(count);
        Console.Write(" ");
        count = count + 2;
    }

    Console.WriteLine();

    Console.WriteLine("Повторим ещё раз? (Y(anykey)/N)");
    string continueRequest = Console.ReadLine();
    if (continueRequest.ToLower() == "n")
    {
        break;
    }
}