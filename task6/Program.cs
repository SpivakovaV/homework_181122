﻿Console.Clear();

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0) a = a * -1;

if (a % 2==1)
            {
                Console.WriteLine("Число нечетное");
           
            }
            else
            {
                Console.WriteLine("Число четное");
            }