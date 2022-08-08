// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine ("Введите любое число: ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите делитель, чтобы проверить кратность первого числа делителю: ");
int b = int.Parse (Console.ReadLine()!);

if ( a%b == 0 )
{
    Console.WriteLine ("Число " + a + " кратно числу " + b + ".");
}
else
{
    Console.WriteLine ("Число " + a + " не кратно числу " + b + ".");
    Console.WriteLine ("Остаток от деления равен " + a%b + ".");
}