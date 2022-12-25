
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите пятизначное число ");
string? n = Console.ReadLine();

void Palindrom(string n)
{
   if (n [0] ==n [4] || n [1] == n [3])
    {
    Console.WriteLine($"Число: {n} - является палиндромом.");
    }
  else 
    {
    Console.WriteLine($"Число: {n} - не является палиндромом.");
    }  
}

if (n!.Length == 5) // хотел написать  (n>10000 && n<100000) но в string так нельзя. Поэтому запишу так
{
  Palindrom(n);
}
else Console.WriteLine($"Начните заново, введя правильное число!");
*/


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double otvet;
Console.Write("Введите значение х1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение х2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

otvet = Math.Sqrt(Math.Pow(x2-x1,2) + (Math.Pow(y2-y1,2))+(Math.Pow(z2-z1,2)));
otvet = Math.Round(otvet,2);
Console.WriteLine($"Расстояние между точками  {otvet}");

*/


//Задача 23.  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
    void FindQQ(int n)
    {
        int count = 1;
        while (count <= n)
        {
            Console.Write($"{Math.Pow(count,3)} ");
            count++;
        }
    }
FindQQ(n);
*/

