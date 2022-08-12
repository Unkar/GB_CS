using System;
class Hero
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
    Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}
class InRase
{
    public string Name;
    public string Ability;
    public string Bonus;
    public string Side;
    Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}




class Program
{
    static void SelectRase(Hero myHero)
    {
        string[] nameRase = { "Люди", "Эльфы", "Орки", "Гоблины", "Гномы" };
        Console.WriteLine("Выбери свою расу");
        Select(nameRase);
        string RaseHero = nameRase[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали расу " + RaseHero);
        myHero.Rase = RaseHero;
    }

    static void SelectSex(Hero myHero)
    {
        string[] nameSex = { "женский", "мужской" };
        Console.WriteLine("Выбери свой пол");
        Select(nameSex);
        string SexHero = nameSex[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали пол " + SexHero);
        myHero.Sex = SexHero;
    }

    static void SelectClass(Hero myHero)
    {
        string[] nameClass = { "Воин", "Разбойник", "Маг", "Вор" };
        Console.WriteLine("Выбери свой класс");
        Select(nameClass);
        string ClassHero = nameClass[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        myHero.Class = ClassHero;
    }



    static void Select(string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + words[i] + ", ");
        }
        Console.WriteLine(words.Length + " - " + words[words.Length - 1] + ". ");
        Console.WriteLine("");
    }
    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("Как вас зовут?");
        myHero.Name = Console.ReadLine();
        SelectRase(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Все наши характеристики");
        Console.WriteLine("Ваше имя " + myHero.Name);
        Console.WriteLine("Ваш пол " + myHero.Sex);
        Console.WriteLine("Ваша раса " + myHero.Rase);
        Console.WriteLine("Ваш класс " + myHero.Class);
    }

}


