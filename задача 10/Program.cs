//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

    if (number>=100&number<1000)
{
int secondDigit = (number/10)%10;

Console.WriteLine($"Вторая цифра этого числа:{secondDigit}");
}

    else if (number<=-100&number>-1000)
{
    int secondDigit = ((number/10)%10)*-1;

Console.WriteLine($"Вторая цифра этого числа:{secondDigit}");
}

    else
{
    Console.WriteLine("Ошибка, введите трехзначное число");
}
