/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double FindX(double k1, double b1, double k2, double b2)
{
    return (double)(b2-b1)/(k1-k2);
}

double FindY(double k1, double b1, double k2, double b2)
{
    return (double)(b1*k2-b2*k1)/(k2-k1);
}

System.Console.WriteLine("Введите числа начала и конца первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите числа начала и конца второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine($"({FindX(k1, b1, k2, b2)}; {FindY(k1, b1, k2, b2)})");
System.Console.WriteLine();