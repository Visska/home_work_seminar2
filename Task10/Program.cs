int three_digit_number = new Random().Next (100, 1000);
Console.WriteLine($"Вводимое число {three_digit_number}");
int second_number = getFindingSecondNumber(three_digit_number);
Console.WriteLine($"Вторая цифра числа {second_number}");


int getFindingSecondNumber(int number)
{
    return ( ( number % 100 ) / 10);
}