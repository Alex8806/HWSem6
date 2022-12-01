// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

int Podschet (int a){

if(a==0){
    return 0;
}
int schet = Podschet(a/10)+1;
return schet;
}


Console.Write("Введите число:\t");
string? s = Console.ReadLine();
bool check = int.TryParse(s, out int a);
while (check == false)
{
    Console.WriteLine("Вы ввели не число");
    Console.WriteLine("Введите число:\t");
    s = Console.ReadLine();
    check = int.TryParse(s, out a);
}
a = Math.Abs(a);
a = Podschet(a); // просто проверил можно ли так сделать.

Console.WriteLine($"Количество цифр: {a}");