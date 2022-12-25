// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

double otvet = Math.Pow(a,b);

Console.WriteLine($"Число {a} в степени {b} = {otvet}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumbers(int number)
{
   int sum = 0;
   while (number > 0)
   {
      sum = sum + number % 10;
      number /= 10;
   }
   return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");

*/


//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. 

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    if(size == 0) 
        Console.WriteLine("Размер массива = 0, массив пустой.");
    else
    {
        for(int i = 0; i < size; i++)
        {
            Console.Write("Введите элемент массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array; 
}
void PrintArray(int [] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
}
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] YourArray = CreateArray(size);

PrintArray(YourArray);
*/

//Я не понял как сделать, чтобы массив из m собирался из рандомных чисел диапазона