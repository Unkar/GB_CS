int[] array = { 1, 2, 3, 90, 5, 6, 7, 8, 9, 90 };

int n =array.Length;
int find = 90;

int index = 0;
 while (index<n)
 {
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
 }