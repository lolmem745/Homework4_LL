int[] toIntegerArray(int number) // Перевод числа в массив
{
    int a = number;
    List<int> l = new List<int>();
    while (a > 0)
    {
        l.Add(a % 10);
        a = a / 10;
    }
    l.Reverse();
    return l.ToArray();
}

int sumOf(int[] arr) // Вычисление суммы элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int number = 0;

while (number <= 0)
{
    Console.Write("Введите положительное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
        Console.WriteLine($"Сумма чисел равна: {sumOf(toIntegerArray(number))}");
    else
        Console.WriteLine("Это число неположительно!");
}


