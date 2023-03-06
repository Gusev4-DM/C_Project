// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

int userNumberA = 0;

while(true)
{
    Console.Write("Введите целое от 1 до 7 число: ");
    if(int.TryParse(Console.ReadLine(), out userNumberA)) 
        break;
    Console.WriteLine("Ошибка ввода, введите целое число");
}


if ((userNumberA < 1) || (userNumberA > 7))
    Console.Write("Введите корректное число");

else if ((userNumberA >= 1) && (userNumberA <= 5))
    Console.Write("Будние дни!");

else if ((userNumberA >= 6) && (userNumberA <= 7))
    Console.Write("Выходные!");
