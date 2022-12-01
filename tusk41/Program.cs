// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int SchetPoloj (){
    string ? s = "";
    int Sch =0;
  
    while (s != "end")
    {
        bool check = true;
        int k=0;
        while (check == true || s != "end")
        {
            Console.WriteLine("Введите число или слово 'end' для окончания : ");
    
            s = Console.ReadLine();
            check = int.TryParse(s, out  k);
          
            if(check==false && s !="end") Console.WriteLine("Вы ввели не число!");
             if (k > 0) Sch++;
        }
// if (k > 0) Sch++; - не могу понять, почему если я условие ставлю сюда то остается 0
    }
    return Sch;}

    int T = SchetPoloj();
System.Console.WriteLine("Вы ввели " + T+ " положительных чисел(а)");