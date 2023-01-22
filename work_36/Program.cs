﻿// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayWithRandom(numbers);
Console.WriteLine("Наш массив: ");
PrintArray(numbers);
int sum = 0;
   for(int z = 1; z < numbers.Length; z+=2)
   {
    sum += numbers[z];
   }

Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечетных позициях = {sum}");
void FillArrayWithRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("] ");
    Console.WriteLine();
}