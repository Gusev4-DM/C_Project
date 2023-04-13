COnsole.Clear();

int m = GetNumberFromUser("Введите M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите N: ", "Ошибка ввода!");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");


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


int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

