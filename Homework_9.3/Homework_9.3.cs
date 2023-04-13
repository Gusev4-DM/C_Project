Console.Clear();

Console.WriteLine("Введите два положительных числа: M и N.");
int m = GetNumberFromUser("Введите M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите N: ", "Ошибка ввода!");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");


int GetNumberFromUser(string massage, string errorMassage)
{ 
    while (true)
    {
        Console.Write(massage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);
        if (isCorrect && UserNumber >= 0)
            return UserNumber;
        Console.Write(errorMassage);
    }
}


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}