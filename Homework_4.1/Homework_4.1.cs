// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int a = 0, b = 0, c = 1;
InitCoordinatesByUser(ref a, ref b);


if (b < 1)
    Console.Write("Число B должно быть натуральным\n");
else
{
    while (b != 0)
    {
        c = c * a;
        b = b - 1;
    }
    Console.Write($"Число A в натуральной степени B равно {c}");
}


static void InitCoordinatesByUser(ref int a, ref int b)
{   
    while(true)
    {
        try
        {
            Console.Write("Введите число a: ");
            a = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Введите число b: ");
            b = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch(Exception)
        {
            Console.WriteLine($"Ошибка ввода данных!");
        }
    }
}
