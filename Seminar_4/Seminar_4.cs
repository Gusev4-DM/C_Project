// // Input

// int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

// // Logic

// int SumNumber = GetSumNumber(num);

// // Output

// Console.Write($"{num} -> {SumNumber}");

// //////////////////////////////////////////////////////////////////////////////////////////////////////

// int GetSumNumber(int numbers)
// {
//     int sum = 0;

//     while(numbers > 0)
//     {
//         sum += numbers;
//         numbers--;
//     }
//     return sum;
// }


// int GetNumberFromUser(string massage, string errorMassage)
// {
//     while(true)
//     {
//         Console.Write(massage);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);
//         if(isCorrect && UserNumber >= 0 )
//             return UserNumber;
//         Console.Write(errorMassage);
//     }
// }

// Программа которая выдает колличество цифр в введенном числе

Console.Clear();

int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

int numDigit = CountDigit(num);

Console.Write($"{num} -> {numDigit}");


int CountDigit(int num)
{
    int count = 0;

    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}


int GetNumberFromUser(string massage, string errorMassage)
{
    while(true)
    {
        Console.Write(massage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);
        if(isCorrect && UserNumber >= 0 )
            return UserNumber;
        Console.Write(errorMassage);
    }
}

