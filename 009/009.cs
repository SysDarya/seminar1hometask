// Удалить вторую цифру трёхзначного числа
Console.WriteLine ("Введите трёхзначное число: ");
int a = int.Parse (Console.ReadLine()!);

int last = a%10;
int middle = (a/10)%10;
int first = (a/10)/10;

Console.Write (first);
Console.WriteLine (last);
