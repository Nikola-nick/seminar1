string [] days = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.Write(" введите число ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if (numberOfDay > 7 | numberOfDay < 1)
{
    Console.WriteLine("ввели неверное число");
}
else Console.WriteLine(days[numberOfDay - 1]);