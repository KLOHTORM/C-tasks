/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
*/

System.Console.WriteLine("Введите координаты точки A по x, y, z: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B по x, y, z: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double num = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);

double resolt = Math.Round(Math.Sqrt(num), 2);

System.Console.WriteLine(resolt);