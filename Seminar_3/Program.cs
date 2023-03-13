// Написать программупринимающую на вход координаты точки (Х и Y), причем (X =! 0) и (Y =! 0), и выдает номер четверти плоскости в которойнаходится эта точка

// Console.Clear();
// int x, y;

// try // блок try воспроизводит блок в его же теле, и если ловит ошибки перенаправляет в блок catch
// {
//     Console.Write("Введите X число: ");
//     x = int.Parse(Console.ReadLine() ?? "");
//     Console.Write("Введите Y число: ");
//     y = int.Parse(Console.ReadLine() ?? "");
// }
// catch(Exception exc) // exeption позволяет принять переменной exc его значение и использовать .Message
// {
//     Console.WriteLine($"Ошибка ввода данных! {exc.Message}"); // .Message выводит текст ошибки
//     return;
// }

// if ( x > 0 && y > 0 )
//     Console.WriteLine("1");
// else if( x < 0 && y > 0)
//     Console.WriteLine("2");
// else if( x < 0 && y < 0)
//     Console.WriteLine("3");
// else if( x > 0 && y < 0 )
//     Console.WriteLine("4");
// else
//     Console.WriteLine("Ошибка! Точка находится на пересечении оси координат!");

Console.Clear();
int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y);   // Вызов метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(X, Y);           // Вызов метода с передачей параметров по значению

static void InitCoordinatesByUser(ref int X, ref int Y)
{   
    while(true)
    {
        try
        {
            Console.Write("Введите число X: ");
            X = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Введите число Y: ");
            Y = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch(Exception)
        {
            Console.WriteLine($"Ошибка ввода данных!");
        }
    }
}

static void PrintQuarterByCoords(int X, int Y)
{
    if( X > 0 && Y > 0)
        Console.WriteLine("1");
    else if( X < 0 && Y > 0)
        Console.WriteLine("2");
    else if( X < 0 && Y < 0)
        Console.WriteLine("3");
    else if( X > 0 && Y < 0 )
        Console.WriteLine("4");
    else
        Console.WriteLine("Ошибка! Точка находится на пересечении оси координат!");
}
