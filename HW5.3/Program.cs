// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = new double[10];
int size = array.Length;
double diffMaxMin = 0;
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(-100, 100);
}
Console.WriteLine($"Массив: {String.Join("; ", array)}");

double maxValue = array.Max();
double minValue = array.Min();
diffMaxMin = maxValue - minValue;
Console.WriteLine($"Максимальное число равно {maxValue}");
Console.WriteLine($"Минимальное число равно {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diffMaxMin}");