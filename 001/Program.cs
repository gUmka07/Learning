// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("Начните заново, используя разные числа");
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine($"Число {number1} больше чем {number2}");
    }
    else
    {
    Console.WriteLine($"Число {number2} больше, чем {number1}");
    }
}
*/

/*
//Задача 4:Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите три разных целых числа для нахождения максимального!");

Console.Write("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.Read());

if (number1 > number2)
    {
        max = number1;
    }
else
    {
        max = number2;
    }

if (number3 < max)
        {
        Console.Write($"Число {max} самое большое");
        }
else
        {
        Console.Write($"Число {number3} самое большое");
        }
// Не могу понять, почему мне нужно начать на Enter чтобы получить результат. Но она работает.
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Введите целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

int otvet = number1 % 2;

if (number1 % 2 == 1 )  
{
        Console.WriteLine($"{number1} - нечетное число");
}
else
{
        Console.WriteLine($"{number1} - четное число");
}

*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 0;
while(current <= number)
{
    Console.Write(current++ + " ");
    current++;
}
 
*/