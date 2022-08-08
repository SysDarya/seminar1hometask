// Показать числа от -N до N
Console.WriteLine ("Введите число-границу: ");
int n = int.Parse (Console.ReadLine()!);
int min = -n;

while ( min <= n )
{
    Console.Write (min + ";" + " ");
    min++;
}