// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void LineCrossing(double t1, double r1, double t2, double r2)
{

    double x = (t1 - t2) / (r2 - r1);
    double y = r1 * x + t1;
    Console.WriteLine($"Координата x - {x}, Координата y - {y}");
    return;
}











Console.WriteLine("Задайте первую прямую линию. Угловой коэффициент:");
string? s = Console.ReadLine();
bool check = double.TryParse(s, out double k1);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте первую прямую линию. Угловой коэффициент:");
    s = Console.ReadLine();
    check = double.TryParse(s, out  k1);
}






Console.WriteLine("Задайте первую прямую линию. Коэффициент смещения:");
s = Console.ReadLine();
check = double.TryParse(s, out double b1);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте первую прямую линию. Коэффициент смещения:");
    s = Console.ReadLine();
    check = double.TryParse(s, out  b1);
}

Console.WriteLine("Задайте вторую прямую линию. Угловой коэффициент:");
s = Console.ReadLine();
check = double.TryParse(s, out double k2);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте вторую прямую линию. Угловой коэффициент:");
    s = Console.ReadLine();
    check = double.TryParse(s, out  k2);
}

Console.WriteLine("Задайте вторую прямую линию. Коэффициент смещения:");
s = Console.ReadLine();
check = double.TryParse(s, out double b2);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Задайте вторую прямую линию. Коэффициент смещения:");
    s = Console.ReadLine();
    check = double.TryParse(s, out  b2);
}


if (b1 == b2 && k1 == k2)
{
    Console.WriteLine("Прямые совпадают! Bсе точки -точки пересени");
 
}
else if (k1 == k1 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны! Точек пересечения нет");
  
   
}


else
{
    LineCrossing(b1, k1, b2, k2);
}