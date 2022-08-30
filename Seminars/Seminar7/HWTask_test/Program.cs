// Задача. Сделать игру тетрис в консоли
// Размер поля 20х10
// Пустые поля заполнятются "."
// Фигуры заполняются "*"

class Program
{  
    static void FillField(char[,] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                field[i, j] = '.';
            }
        }
    }

    static void DrawField(char[,] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                Console.Write(field[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void NewTetrisElement(char[,] field, int x, int y)
    {
        field[x, y] = '*';
        field[x + 1, y] = '*';
        field[x + 2, y] = '*';
        field[x + 3, y] = '*';
    }

    static void SetElementOnField(char[,] field, int x, int y)
    {
        if (x < 0 || x > field.GetLength(0) - 1 || y < 0 || y > field.GetLength(1) - 1)
        {
            return;
        }
        else
        {
            field[x, y] = '*';
        }
    }
   
    static void Main(string[] args)
    {
        char[,] field = new char[20, 10];
        FillField(field);
        DrawField(field);
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == '*')
                        {
                            field[i, j] = '.';
                            field[i, j - 1] = '*';
                        }
                    }
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == '*')
                        {
                            field[i, j] = '.';
                            field[i, j + 1] = '*';
                        }
                    }
                }
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == '*')
                        {
                            field[i, j] = '.';
                            field[i - 1, j] = '*';
                        }
                    }
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == '*')
                        {
                            field[i, j] = '.';
                            field[i + 1, j] = '*';
                        }
                    }
                }
            }
        }
    }

}