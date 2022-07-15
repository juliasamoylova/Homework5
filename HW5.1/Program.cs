// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int size = array.Length;
int countEvenNumber = 0;
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(100, 1000);
    if (array[index] % 2 == 0)
    {
        countEvenNumber++;
    }
}
Console.WriteLine($"Массив: {String.Join("; ", array)}");
Console.WriteLine($"Количество четных чисел в массиве: {countEvenNumber}");