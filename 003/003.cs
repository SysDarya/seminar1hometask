// Найти максимальное из трех чисел
Console.WriteLine ("Ведите первое число: ");
int a = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Ведите второе число: ");
int b = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Ведите третье число: ");
int c = int.Parse (Console.ReadLine()!);

int d = a;

if (d < b)
{
    d = b;
}
else if (d < c)
{
    d = c;
}

Console.Write ("Maксимальное число равно ");
Console.WriteLine (d);