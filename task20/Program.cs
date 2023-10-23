/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
*/

System.Console.WriteLine("Введите координаты точки A(x, y): ");
int pointAx = Convert.ToInt32(Console.ReadLine());
int pointAy = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите координаты точки B(x, y): ");
int pointBx = Convert.ToInt32(Console.ReadLine());
int pointBy = Convert.ToInt32(Console.ReadLine());

double sqX = Math.Pow(pointBx - pointAx, 2); //Math.Pow(что возводим в степень, в какую степень)-это функция возведения в степень
double sqY = Math.Pow(pointBy - pointAy, 2);

double rootXY = Math.Sqrt(sqX + sqY); //Math.Sqrt()-функция нахождения квадратного корня
System.Console.WriteLine(Math.Round(rootXY, 2)); //Math.Round(число, сколько чисел после запятой)-функция округления чисел после запятой
