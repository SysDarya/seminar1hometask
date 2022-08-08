// Показать вторую цифру трёхзначного числа
Console.WriteLine ("Введите трёхзначное число: ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Вторая цифра числа: " + (a/10)%10);