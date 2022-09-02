// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
while (size < 0)
{
    Console.Write("Вы ввели в качестве размера массива отрицательное значение. Введите заново размер массива:");
    size = int.Parse(Console.ReadLine());
}
double[] array = new double[size];
for (int index = 0; index < array.Length; index++)
{
    Console.Write("Введите значение элемента массива c index " + index + " = ");
    array[index] = double.Parse(Console.ReadLine());
}
double diff = 0;
double max = array[0];
double min = array[0];
for (int index = 0; index < array.Length; index++)
{
    if (array[index] > max) max = array[index];
    if (array[index] < min) min = array[index];
}
diff = max - min;
Console.WriteLine("Ответ: в получившемся массиве [" + string.Join("  ", array) + "] разница между максимальным и минимальным элементом массива равна -> " + diff);