/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SumMN(int m, int n)
{
    if (m > n) return n + SumMN(m, n + 1);
    return n;
}

int userM = Massege("Введите значение M: ");
int userN = Massege("Введите значение N: ");
System.Console.WriteLine($"{SumMN(userM, userN)}");