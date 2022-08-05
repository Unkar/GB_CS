// int string bool float double
/* int a = 10;
string b = "Hello";
bool c = true; // false
float d = 25.23;
double e = 13.334; */

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите оператор ");
string Operator = Console.ReadLine();
if (Operator == "+")
{
    Console.WriteLine(number1 + number2);
}
else if (Operator == "-")
{
    Console.WriteLine(number1 - number2);
}
else if (Operator == "*")
{
    Console.WriteLine(number1 * number2);
}
else if (Operator == "/")
{
    Console.WriteLine(number1 / number2);
}