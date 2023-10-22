//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System;
int number(int A){
    int sum = 0;
    int x = 0;
    while(A>0){
        x = A % 10;
        A = A / 10;
        sum = sum + x;
    }
    return sum;
}
Console.WriteLine($"{number(82)}");