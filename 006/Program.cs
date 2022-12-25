//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int positiveNumbers(int quantityNumber)
{   
    int count = 0;
    int quantity = 0;
    
    do
    {
        Console.Write("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());
        
        if (num > 0) 
        count++;
        quantity++;
    } 
    while (quantity < quantityNumber);

    return count;
}


Console.Write("Введите количество чисел: ");
int quantityNum = Convert.ToInt32(Console.ReadLine());

int otvet = positiveNumbers(quantityNum);
Console.WriteLine($"Вы ввели {quantityNum} чисел. Из них {otvet} положительных.");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые не пересекутся");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = Math.Round(k2 * x + b2, 2);

        Console.WriteLine($"Координаты точки пересечения: x: {x}, y: {y}.");
    }
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1,k1,b2,k2);
*/