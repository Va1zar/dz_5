// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] NewArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 100);
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
int[] array = NewArray(7);
Console.Write("[");
PrintArray(array);
Console.Write("]");

int i = 0;
int j = 0;
int l = array.Length;
int max = array[i];
int min = array[j];
int diff = 0;
while (i < l)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
    i++;
}
diff = max - min;
Console.WriteLine(" ");
Console.WriteLine("Максимальное число массива = " + max);
Console.WriteLine("Минимальное число массива = " + min);
Console.WriteLine("Разница максимального и минимального элемента = " + diff);