// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine ("Введите любое число: ");
int a = int.Parse (Console.ReadLine()!);

if (a < 100)
{
    Console.WriteLine ("В числе нет третьей цифры.");
}
else
{
    string str = a.ToString();
    Console.WriteLine ("Третья цифра числа равна " + str[2] + ".");
}