Console.WriteLine("Задайте промежуток от M до N");
Console.Write("Введите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}, равна: ");

int sumNaturNumber (int x, int y)
{
    if (y == x)
    {
        return x;
    }
    return x + sumNaturNumber(x+1, y);
}
Console.WriteLine(sumNaturNumber(M,N));