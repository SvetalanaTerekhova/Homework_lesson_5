// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое будет минимальным значением диапазона генерации случайных чисел массива: ");
int MinNumber = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое будет максимальным значением диапазона генерации случайных чисел массива: ");
int MaxNumber = int.Parse(Console.ReadLine());
int sum = 0;
while (MinNumber > MaxNumber || size < 0)
{
    if (size < 0)
    {
        Console.Write("Вы ввели в качестве размера массива отрицательное значение. Введите заново размер массива: ");
        size = int.Parse(Console.ReadLine());
    }
    if (MinNumber > MaxNumber)
    {
        Console.WriteLine("Вы ввели диапазон генерации случайных чисел массива, где минимальное значение больше максимального. Сформировать такой массив не возможно.");
        Console.Write("Введите число, которое будет минимальным значением диапазона генерации случайных чисел массива:");
        MinNumber = int.Parse(Console.ReadLine());
        Console.Write("Введите число, которое будет максимальным значением диапазона генерации случайных чисел массива: ");
        MaxNumber = int.Parse(Console.ReadLine());
    }
}
int[] array = new int[size];
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(MinNumber, MaxNumber + 1);
}
for (int index = 0; index < array.Length; index++)
{
    sum += index % 2 == 1 ? array[index] : 0;
}
Console.WriteLine("Ответ: в получившемся массиве [" + string.Join(",", array) + "] сумма элементов, стоящих на нечётных позициях -> " + sum);