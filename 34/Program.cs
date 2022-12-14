// 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] NewArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

void PrintArray(int[] size)
{
    for (int j = 0; j < size.Length; j++)
    {
        Console.Write(size[j] + " ");
    }
}

int[] array = NewArray(6);
Console.Write("[");
PrintArray(array);
Console.Write("]");

int count = 0;
foreach (int el in array)
{
    if (el % 2 == 0)
    {
        count = count + 1;
    }
}
Console.Write(" Кол-во четных чисел в массиве = " + count);