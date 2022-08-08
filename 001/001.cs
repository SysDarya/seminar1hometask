// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine ("Ведите первое число: ");
int a = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Ведите второе число: ");
int b = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Является ли первое квадратом второго? ");
if (a == b*b)
{
    Console.WriteLine ("Является. ");
}
else
{
    Console.WriteLine ("Не является");
}
