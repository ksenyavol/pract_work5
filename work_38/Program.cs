// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
FillArrayWithRandom(numbers);
Console.WriteLine("Наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

    for(int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
    }
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max} , минимальное значение = {min}");
Console.WriteLine($"разница между максимальным и минимальным значением = {max - min}");

void FillArrayWithRandom(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(10,100)) / 10;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + " ");
    }
    Console.Write("] ");
    Console.WriteLine();
}