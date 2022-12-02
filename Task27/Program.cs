Console.Clear();

int NumberInput(string invitation)
{
    Console.WriteLine(invitation);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int SumOfDigits(int num)
{
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int num = NumberInput("Введите число для подсчета суммы цифр в нем:");
int sum = SumOfDigits(num);

Console.WriteLine($"Сумма цифр в числе {num} равна {sum}");