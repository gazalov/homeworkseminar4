Console.Clear();

int[] FillArray(int[] array)
{
    int arrayLength = array.Length;
    for (int i = 0; i <= arrayLength - 1; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив рандомных чисел из 8 элементов:");
    Console.Write("[ ");
    int arrayLength = array.Length;
    for (int i = 0; i <= arrayLength - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

int arrayLength = 8;
int[] array = new int[arrayLength];

array = FillArray(array);
PrintArray(array);
