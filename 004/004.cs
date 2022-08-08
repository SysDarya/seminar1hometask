// Выяснить является ли число чётным
Console.WriteLine ("Введите число, чтобы определить его чётность: ");
int a = int.Parse (Console.ReadLine()!);

if ( a%2 == 0)
{
    Console.WriteLine ("Число чётное. ");
}
else
{
    Console.WriteLine ("Число нечётное. ");
}