//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
 void PrintArray(int[] array)
 {
        for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
 }

int EvenNumbers(int[] array)
{
    int otvet = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
            otvet++;
    }
    return otvet;
}
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);

int result = EvenNumbers(yourArray);

Console.WriteLine($"Количество четных чисел в этом массиве = {result}.");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
 void PrintArray(int[] array)
 {
    Console.Write("Cоздал массив: ( ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(") ");
 }
int NumOfOddElem(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
    return sum;
}
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);
int result = NumOfOddElem(yourArray);

Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {result}.");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
/*
double[] CreateArray(int size)

{
    double[] array = new double[size];
        for(int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

 void PrintArray(double[] array)

 {
    Console.Write("Cоздал массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
 }

double DifMaxMin(double[] array)

{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
        {
            if(array[i] > max)
                max = array[i];
            else if(array[i] < min)
                min = array[i];
            dif = max - min;
        }
    Console.Write($"Максимальный элемент в массиве = {max}.");  Console.WriteLine($"Минимальный элемент в массиве = {min}.");
    
    return dif;
}
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] yourArray = CreateArray(size);
PrintArray(yourArray);

double result = DifMaxMin(yourArray);

Console.WriteLine($"Разница, между максимальным и минимальным элементами в массиве равна {result}.");
*/