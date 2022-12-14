// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-10, 101);
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

int Sum(int res)
{
    int sum = 0;
    int j = array.Length;
    for (int i = 1; i < j; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}
int sum = Sum(2);
Console.Write(" Сумма нечетных элементов массива = " + sum);