// Напищите программу которая на вход принимает число и выдае его квадрат
// пример
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write (" Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write (" Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}