
int varA;

while(true)
{
    Console.Write("Введите А: ");
    if(int.TryParse(Console.ReadLine(), out varA)) // Применимо для всех типов данных, double... итд
        break;
    Console.WriteLine("Ошибка ввода");
}

Console.WriteLine($"A={varA}");


// Написать программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear();

int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;

if (max < a2)
{
    max = a2;
}

else if (max > a1)
{
     max = a1;
}

Console.WriteLine($"Максимальня цифра в числе {num} -> {max}.");

// В диапазоне чисел [100, 999] убрать среднее из них

Console.Clear();

int num = new Random().Next(100, 999);
int a1 = num / 100;
int a2 = num % 10;
int result = a1 * 10 + a2;

Console.WriteLine($"получаем вот такое число {num} -> {result}.");

// На вход два числа, проверить является ли второе число кратное первому, если нет вывести остаток

Console.Clear();

Console.Write("Введите первое число: ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int userNumberB = int.Parse(Console.ReadLine() ?? "");

if (userNumberA % userNumberB == 0)
{
    Console.WriteLine($"Да, {userNumberA} кратно {userNumberB}");
}
else
{
    Console.WriteLine($"Нет, {userNumberA} не кратно {userNumberB}, остаток от деления будет составлять {userNumberA % userNumberB}");
}


// Принимает на вход число которое должно быть одновременно кратно 7 и 23

Console.Clear();

Console.Write("Введите кратное число: ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");

if ((userNumberA % 23 == 0) && (userNumberA % 7 ==0))
    Console.Write($"Да число {userNumberA} кратно и 7 и 23");
else
{
    Console.Write($"Нет число {userNumberA} не кратно и 7 и 23");
}

// Принимает на вход два числа, проверяет является ли первое число квадратом второго

Console.Clear();

Console.Write("Введите первое число: ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int userNumberB = int.Parse(Console.ReadLine() ?? "");

if (userNumberA * userNumberA == userNumberB)
    Console.Write($"Да число {userNumberB} является квадратом числа {userNumberA}");
else
{
    Console.Write($"Нет число {userNumberB} не является квадратом числа {userNumberA}");
}

