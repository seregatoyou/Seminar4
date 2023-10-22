//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using System;
double number(int A, int B){
    double extent = 0;
    extent = Math.Pow (A, B);
    return extent;
}
Console.WriteLine($"{number(3,5)}");