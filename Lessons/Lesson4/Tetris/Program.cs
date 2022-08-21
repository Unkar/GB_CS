using System;

class Program
{
    static void PrintField(string[,] field)
    {
           
        Console.Write("╔");
        for (int j = 0; j < field.GetLength(1); j++)
        {
            Console.Write("═");
        }
        Console.WriteLine("╗");

        
        for (int i = 0; i < field.GetLength(0); i++)
        {
            Console.Write("║");
            for (int j = 0; j < field.GetLength(1); j++)
            {
                Console.Write(field[i, j]);
            }
            Console.WriteLine("║");
        }
        

        Console.Write("╚");
        for (int j = 0; j < field.GetLength(1); j++)
        {
            Console.Write("═");
        }
        Console.WriteLine("╝");

    }

    static string[,] FillStartField(string[,] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                field[i, j] = ".";
            }

        }
        return field;
    }

    static void Main()
    {
        int weight = 12;
        int height = 22;

        string[,] fieldStatus = new string[height, weight];
        fieldStatus = FillStartField(fieldStatus);
        PrintField(fieldStatus);
    }
}