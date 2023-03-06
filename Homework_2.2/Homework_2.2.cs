//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int userNumberA = 0;

while(true)
{
    Console.Write("Введите трехзначное целое число: ");
    if(int.TryParse(Console.ReadLine(), out userNumberA)) 
        break;
    Console.WriteLine("Ошибка ввода, введите целое число");
}


bool GetLose(int userNumberA)
{
    if (userNumberA < 100)
    {
        Console.WriteLine($"Третьей цифры нет");
        return false;
    }
    return true;
}


int GetRect(int userNumberA)
{
    while(userNumberA > 999)
    {
        userNumberA /= 10;
    }
    return userNumberA % 10;

}


if (GetLose(userNumberA))
{
    Console.WriteLine(GetRect(userNumberA));
}

// я честно ничего понял почему это так работает с функциями но оно как-то работает