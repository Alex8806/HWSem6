// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void LineCrossing(double b1, double k1, double b2, double k2, out string x, out string y)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают! ");
        x = "Все точки- точки пересечения";
        y = "Все точки- точки пересечения";
        return;
    }
    else if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны!");
        x = "Точек пересечения нет";
        y = "Точек пересечения нет";
        return;
    }
    else
    {
        double vremx = (b1 - b2) / (k2 - k1);
        double vremy = k1 * vremx + b1;
        x = Convert.ToString(vremx);
        y = Convert.ToString(vremy);
        return;
    }
}


Console.WriteLine("Задайте первую прямую линию. Коэффициент смещения b1:");
string? s = Console.ReadLine();
bool check = double.TryParse(s, out double b1);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте первую прямую линию. Коэффициент смещения b1:");
    s = Console.ReadLine();
    check = double.TryParse(s, out b1);
}
Console.WriteLine("Задайте первую прямую линию. Угловой коэффициент k1:");
s = Console.ReadLine();
 check = double.TryParse(s, out double k1);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте первую прямую линию. Угловой коэффициент k1:");
    s = Console.ReadLine();
    check = double.TryParse(s, out k1);
}
Console.WriteLine("Задайте вторую прямую линию. Коэффициент смещения b2:");
s = Console.ReadLine();
check = double.TryParse(s, out double b2);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте вторую прямую линию. Коэффициент смещения b2:");
    s = Console.ReadLine();
    check = double.TryParse(s, out b2);
}
Console.WriteLine("Задайте вторую прямую линию. Угловой коэффициент k2:");
s = Console.ReadLine();
check = double.TryParse(s, out double k2);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте вторую прямую линию. Угловой коэффициент k2:");
    s = Console.ReadLine();
    check = double.TryParse(s, out k2);
}





LineCrossing(b1, k1, b2, k2, out string x, out string y);



Console.WriteLine($"Координата x = {x}, Координата y = {y}");