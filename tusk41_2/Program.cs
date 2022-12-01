// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
bool check = false;
string? s = "";
int k = 0;
int[] FullArr = new int[0];
while ( s != "end")
{
    while (check == true || s != "end")
    {
        Console.WriteLine("Введите число или слово 'end' для окончания ввода: ");

        s = Console.ReadLine();
        check = int.TryParse(s, out k);
        if (s == "end" || check == true) break;
        if (check == false && s != "end") Console.WriteLine("Вы ввели не число!");

    }
    if (s == "end") break;
    int[] vrem = new int[1];
    vrem[0] = k;
    FullArr = FullArr.Concat(vrem).ToArray();
}
Console.WriteLine("Вы ввели числа: " + String.Join(",", FullArr));
int Schetchik= 0;
for (int i=0; i<FullArr.Length;i++){
if(FullArr[i]>0)Schetchik++;


}
Console.WriteLine($"Вы ввели {Schetchik} положительных чисел(a)");