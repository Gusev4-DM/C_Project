Console.Write("Введите целое число: ");

// string userInputStr = Console.ReadLine() ?? "";
// int userNumber = int.Parse(userInputStr);

int userNumber = int.Parse(Console.ReadLine() ?? ""); // эффективнее в одну строку

// int result = userNumber * userNumber;
int result = (int)Math.Pow(userNumber, 2); // используем бибилиотеку Math, она возвращает вещественный тип данных, требуется перевод в int

Console.WriteLine($"{userNumber} -> {result}"); // интерполяция строк
Console.WriteLine(userNumber + " -> " + result); // конкатенация строк

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Проверка является ли введенное число квадратом другого числа

Console.Write("Введите число \"а\" число: ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите квадрат числа \"а\": ");
int userNumberB = int.Parse(Console.ReadLine() ?? "");

if ((int)Math.Pow(userNumberA, 2) == userNumberB)
{
    Console.WriteLine($"Да {userNumberA} в квадрате будет {userNumberB} ");
}
else
{
    Console.WriteLine($"Нет {userNumberA} в квдрате не будет равняться {userNumberB} ");
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Проверка дней недели по числу

Console.Write("Введите число \"а\" число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

if ((userNumber < 1) || (userNumber > 7))
    Console.Write("Введите корректное число");

if (userNumber == 1) 
    Console.Write("Понедельник");
else if (userNumber == 2) 
    Console.Write("Вторник");
else if (userNumber == 3) 
    Console.Write("Среда");
else if (userNumber == 4) 
    Console.Write("Четверг");
else if (userNumber == 4) 
    Console.Write("Пятница");
else if (userNumber == 5) 
    Console.Write("Суббота");
else if (userNumber == 6) 
    Console.Write("Воскресенье");
