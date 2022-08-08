// Показать последнюю цифру трёхзначного числа
Console.WriteLine ("Введите трёхзначное число: ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Последняя цифра числа: " + a%10);