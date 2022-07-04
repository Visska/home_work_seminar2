int day_week = new Random().Next(1, 8);
Console.WriteLine($"День недели от 1 до 7 -> {day_week}");
if(day_week <= 5)
{
    Console.WriteLine($"{day_week} - нет, не выходной");
}
else
{
    Console.WriteLine($"{day_week} - да, выходной");
}
