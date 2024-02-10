string rec(int n, int m)
{
    if (n == m)
        return $"{n}";
    return rec(n - 1, m) + $" {n}";
}

Console.Clear();
Console.Write("Введите начальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));
