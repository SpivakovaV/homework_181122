﻿Console.Clear();

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;

Console.Write("Максимум равен ");
Console.WriteLine(max);