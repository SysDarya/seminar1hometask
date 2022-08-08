// По заданному номеру дня недели вывести его название
Console.WriteLine ("Задайте номер дня недели, чтобы программа могла определить его название: ");
int d = int.Parse (Console.ReadLine());
if (d == 1)
{
    Console.WriteLine ("Понедельник");
}
if (d == 2)
{
    Console.WriteLine ("Вторник");
}
if (d == 3)
{
    Console.WriteLine ("Среда");
}
if (d == 4)
{
    Console.WriteLine ("Четверг");
}
if (d == 5)
{
    Console.WriteLine ("Пятница");
}
if (d == 6)
{
    Console.WriteLine ("Суббота");
}
if (d == 7)
{
    Console.WriteLine ("Воскресенье");
}
if (d > 7)
{
    Console.WriteLine ("Можно ввести число от 1 до 7. ");
}
if (d < 1)
{
    Console.WriteLine ("Можно ввести число от 1 до 7. ");
}