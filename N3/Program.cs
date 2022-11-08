int[] createArr(int arrLength)
{
    int[] arr = new int[arrLength];
    return arr;
}
int[] arrFilling(int[] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}
void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine()) + 1;
printArray(arrFilling(createArr(size), minValue, maxValue));