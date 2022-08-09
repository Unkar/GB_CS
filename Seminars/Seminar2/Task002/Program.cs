using System;
class Program
{
    static void SelectRace()
    {
        string[] namesRace = { "Люди", "Эльфы", "Гномы", "Орки" };
        for (int i = 0; i < namesRace.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + namesRace[i] + ", ");
        }
        Console.Write(namesRace.Length + " - " + namesRace[namesRace.Length - 1] + ".");
        Console.WriteLine("Укажите вашу расу");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса " + namesRace[indexRace - 1]);
    }
    static void Main(string[] args)
    {
        SelectRace();
    }
}