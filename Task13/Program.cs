int random_number = new Random().Next(1, 1011);
Console.WriteLine($"Введенное число {random_number}");
int number3 = -1;

while(random_number > 99)
{
    number3 = random_number % 10;
    random_number = random_number / 10;
}

if (number3 == -1)
{
    Console.WriteLine($"Третьей цифры нет.");
}
else
{
    Console.WriteLine($"Третья цифра = {number3}");
}