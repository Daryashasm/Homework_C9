Console.WriteLine("Задайте промежуток от N до 1");
Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа от {N} до 1: ");

void naturNumber(int x)
{
    if (x == 0)
    {
        return;
    }
Console.Write($"{x} ");
naturNumber(x-1);
}

naturNumber(N);
Console.WriteLine();
