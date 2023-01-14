Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int M = Convert.ToInt32(Console.ReadLine());

if (N > M)
{
    (M, N) = (N, M);
}

int sum = 0;

Console.WriteLine(Function(N, M, sum));

int Function(int n, int m, int sum)
{
    sum = sum+n;
    if (n == m)
        return sum;
    return Function(n + 1, m, sum);
}

Console.Read();