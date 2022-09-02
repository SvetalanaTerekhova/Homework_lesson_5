//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// 1 Вариант - когда диапазон генерации случайных чисел массива задано строгим значеним

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
while (size < 0)
{
    Console.Write("Вы ввели в качестве размера массива отрицательное значение. Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
}
int count = 0;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
for (int i = 0; i < array.Length; i++)
{
    count += array[i] % 2 == 0 ? 1 : 0;
}
Console.WriteLine("Ответ: в получившемся массиве [" + string.Join(",", array) + "] количество четных чисел -> " + count);


//2 Вариант - когда пользователь сам задает диапазон генерации случайных чисел массива 

/* Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите трёхзначное положительное число, которое будет минимальным значением диапазона генерации случайных чисел массива: ");
int MinNumber = int.Parse(Console.ReadLine());
Console.Write("Введите трёхзначное положительное число, которое будет максимальным значением диапазона генерации случайных чисел массива: ");
int MaxNumber = int.Parse(Console.ReadLine());
while (size < 0 || MinNumber > MaxNumber || MinNumber < 100 || MinNumber > 999 || MaxNumber < 100 || MaxNumber > 999)
{
    if (size < 0)
    {
        Console.WriteLine("_________________________________________");
        Console.Write("Вы ввели в качестве размера массива отрицательное значение. Введите заново размер массива: ");
        size = int.Parse(Console.ReadLine());
    }
    if (MinNumber > MaxNumber)
    {
        Console.WriteLine("_________________________________________");
        Console.WriteLine("Вы ввели диапазон генерации случайных чисел массива, где минимальное значение больше максимального. Сформировать такой массив не возможно.");
        Console.Write("Введите трёхзначное положительное число, которое будет минимальным значением диапазона генерации случайных чисел массива: ");
        MinNumber = int.Parse(Console.ReadLine());
        Console.Write("Введите трёхзначное положительное число, которое будет максимальным значением диапазона генерации случайных чисел массива: ");
        MaxNumber = int.Parse(Console.ReadLine());
    }
    if (MinNumber < 100 || MinNumber > 999)
    {
        Console.WriteLine("_________________________________________");
        Console.WriteLine("Вы ввели в качестве минимального значения диапазона генерации случайных чисел массива не положительное трёхзначное число.");
        Console.Write("Введите трёхзначное положительное число, которое будет минимальным значением диапазона генерации случайных чисел массива: ");
        MinNumber = int.Parse(Console.ReadLine());
    }
    if (MaxNumber < 100 || MaxNumber > 999)
    {
        Console.WriteLine("_________________________________________");
        Console.WriteLine("Вы ввели в качестве максимального значения диапазон генерации случайных чисел массива не положительное трёхзначное число.");
        Console.Write("Введите трёхзначное положительное число, которое будет максимальным значением диапазона генерации случайных чисел массива: ");
        MaxNumber = int.Parse(Console.ReadLine());
    }
}
int count = 0;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(MinNumber, MaxNumber + 1);
}
for (int i = 0; i < array.Length; i++)
{
    count += array[i] % 2 == 0 ? 1 : 0;
}
Console.WriteLine("Ответ: в получившемся массиве [" + string.Join(",", array) + "] количество четных чисел -> " + count); */