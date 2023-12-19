/*
Выполнение через рекурсию (функция вызывает саму себя)

Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int NumSum(int num)
{
    if (num / 10 > 0)
    {
        return num % 10 + NumSum(num / 10);
    }
    return num;
}

int userNum = Massege("Введите число: ");
System.Console.WriteLine(NumSum(userNum));