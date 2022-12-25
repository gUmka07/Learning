// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число");

int Ditig(int number)

    {
        int number1 = number / 10;
        int number2 = number / 100;
        int result = number1 - number2 * 10;
        return result;
    }
int number = Convert.ToInt32(Console.ReadLine());
int result = Ditig(number);
Console.WriteLine(result);

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 /*
Console.WriteLine("Введите любое число");
int ThirdDigit(int number)
{
    int result;
    while (number > 999)
        number = number / 10;
    result = number % 10;
    return result;
}
int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100)
        Console.WriteLine("Третьей цифры нет");
        
    else
    {
        int end = ThirdDigit(number);
        Console.WriteLine($"В числе = {number}, третьей цифрой является = {end}");
    }
Console.ReadLine();
*/
// подглядел в интернете, честно признаться.


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Введите число, обозначающее день недели, где 1 - это понедельник, а 7 - воскресенье");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7)
    {
        Console.WriteLine("В неделе всего 7 дней. Начните заново и введите число от 1 до 7!");
    }
else
        {
            if (day <= 5)
                {
                    Console.WriteLine($"Число {day} обозначает будний день");
                }
            else
                {
                    Console.WriteLine($"Число {day} обозначает выходной день");
                }
        }
*/