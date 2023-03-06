// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число число: ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int userNumberB = int.Parse(Console.ReadLine() ?? "");

if ((userNumberA > userNumberB))
    Console.Write($"{userNumberA} больше чем {userNumberB}");
else
    Console.Write($"{userNumberB} больше чем {userNumberA}");


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое число число: ");
int userNumberX = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int userNumberY = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье число: ");
int userNumberZ = int.Parse(Console.ReadLine() ?? "");

int max = 0;
userNumberX = max;

if ((userNumberX >= userNumberY && userNumberX >= userNumberZ))
    max = userNumberX;
else if (userNumberY >= userNumberX && userNumberY >= userNumberZ)
    max = userNumberY;
else if (userNumberZ >= userNumberX && userNumberZ >= userNumberY)
    max = userNumberZ;

Console.Write($"{max} максимальное число");


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите первое число число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

if (userNumber % 2 == 0)
    Console.Write($"{userNumber} четное число.");
else
    Console.Write($"{userNumber} Нечетное число.");