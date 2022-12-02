Console.Clear();

int NumberInput(string invitation)
{
    Console.WriteLine(invitation);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int PowerRaise(int baseOfPower, int indexOfPower)
{
    int result = 1;
    for (int i = 0; i < indexOfPower; i++)
    {
        result = result * baseOfPower;
    }
    return result;
}

int numA = NumberInput("Введите первое число: ");
int numB = NumberInput("Введите второе натуральное число: ");

int result = PowerRaise(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} равно: {result}.");
