//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33


using System;
void number1(){
    int[] array = new int[8];
    for(int i = 0; i <=7; i++){
        array[i] = new Random().Next(0, int.MaxValue);
        Console.WriteLine($"{array[i]}");
    }
}
number1();

void number2(){
    int[] array = new int[8];
    for(int i = 0; i <= 7; i++){
        Console.WriteLine("Введите число: ");
        array[i] = int.Parse(System.Console.ReadLine());
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
number2();