// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10, 100);
Console.WriteLine ("Дано число " + a);
 if (a/10 > a%10)
 {
    Console.WriteLine ("Наибольшая цифра числа = " + a/10);
 }
 else if (a/10 < a%10)
 {
    Console.WriteLine ("Наибольшая цифра числа = " + a%10);
 }
 else
 {
    Console.WriteLine ("Цифры числа одинаковы и равны " + a/10);
 }