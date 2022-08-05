double count = 0,
    distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5,
    friend = 2;
double time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз между людьми");
