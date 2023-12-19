/*
Выполнение через рекурсию (функция вызывает саму себя)

Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void IntMN(int m, int n)
{
    if (m > n)
    {
        System.Console.Write($"{n} ");
        IntMN(m, n + 1);
    }
    else if (m == n)
    {
        System.Console.Write($"{m} ");
        return;
    }
}

int userM = Massege("Задайте значение M: ");
int userN = Massege("Задайте значение N: ");
IntMN(userM, userN);