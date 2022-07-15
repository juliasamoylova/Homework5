// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[10];
int size = array.Length;
int sumOddPosition = 0;
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(-100, 100);
}
Console.WriteLine($"Массив: {String.Join("; ", array)}");

for (int i = 1; i < size; i += 2)
{
    sumOddPosition += array[i];
}
Console.WriteLine($"Сумма нечетных элементов массива: {sumOddPosition}");