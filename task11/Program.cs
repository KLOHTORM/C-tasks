﻿/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
748 -> 78
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;


System.Console.WriteLine($"{first}{last}");
//System.Console.WriteLine("ответ = " + first + last)