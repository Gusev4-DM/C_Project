Console.Clear();

int n = GetNumberFromUser("Введите положительное число: ", "Ошибка ввода!");
int m = 1;

Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

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
