// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int numberN = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");

int sumNumber = SumNumber(numberN);

Console.WriteLine("Сумма цифр в числе: " + sumNumber);


int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
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