﻿/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(numA, numB);

System.Console.WriteLine(result);