// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int size=10;

int[] array = new int[size];
int CountEvenNumbersInArray=0;
for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + "\t");
        if (array[i]%2 == 0) CountEvenNumbersInArray++;
    }
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в заданном массиве - {CountEvenNumbersInArray}");