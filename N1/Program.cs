int pow(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
Console.WriteLine("Введите число которое хотите возвести в степень, а затем степень в которую хотите возвести.");
Console.WriteLine($"Результат: {pow(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");
