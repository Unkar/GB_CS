using System;
class Program
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1] + ".");
    }
    static void SelectRace()
    {
        string[] namesRace = { "Люди", "Эльфы", "Гномы", "Орки" };
        WriteSelect(namesRace);
        Console.WriteLine("Укажите вашу расу");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса " + namesRace[indexRace - 1]);
    }
    static void SelectClass()
    {
        string[] namesClass = { "Мечник", "Лучник", "Вор", "Маг" };
        WriteSelect(namesClass);
        Console.WriteLine("Укажите вашу расу");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса " + namesClass[indexClass - 1]);
    }
    static void SelectMale()
    {
        string[] namesMale = { "Мужчина", "Женщина"};
        WriteSelect(namesMale);
        Console.WriteLine("Укажите вашу расу");
        int indexMale = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса " + namesMale[indexMale - 1]);
    }    
    static void Main(string[] args)
    {
        SelectRace();
        SelectClass();
        SelectMale();
    }
}