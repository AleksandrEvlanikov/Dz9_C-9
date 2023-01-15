Console.WriteLine("Введите число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());


static int SumNaturalNumbers(int m, int n)
{

if (m == n)
{
    return m;
}
else
{
    return m + SumNaturalNumbers(m + 1, n);
}
}
Console.WriteLine(SumNaturalNumbers(m,n));
