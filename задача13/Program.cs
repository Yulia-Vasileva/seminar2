//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
В этом варианте все работает, кроме отрицательных чисел(если ввести отрицательное число)
int number (int a ,int n)
{
      int result = 0;
    if (n<3)
    {
       Console.WriteLine("Третьей цифры в этом числе нет");
    }
    else
    {
        int c = 1;
        int z = n;
        while(z>3)
        {
         c =c*10;
         z = z-1;
        }
        result = a/c% 10;
    } 
    
    return result;
}

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num.ToString().Length;
Console.WriteLine(number(num, count));
*/




/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//В этом варианте работает с трехзначными(полжительными и отрицательными) числами и меньше. Больше трехзначных не работает, я не понимаю как зациклить в этом случае
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number>1000)
{
//    if (number1000&number-1000)
int thirdDigit = (number/10);

//thirdDigit = thirdDigit-1;

Console.WriteLine($"Третья цифра этого числа:{thirdDigit%10}");
}

if (number>=100&number<1000)

{
    int thirdDigit = (number%10);
Console.WriteLine($"Третья цифра этого числа:{thirdDigit}");
}

else if (number<=-100&number>-1000)
{
    int thirdDigit = (number%10)* -1;
Console.WriteLine($"Третья цифра этого числа:{thirdDigit}");
}

else if(number<100||number>-100)
{
Console.WriteLine($"Третьей цифры в этом числе нет");
}
*/