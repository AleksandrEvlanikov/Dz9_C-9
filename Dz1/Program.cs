Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

void printNumbers( int n)
{
    if (n == 0)
        return;
    Console.WriteLine(n);
    printNumbers(n-1);
}
printNumbers(n);
 

    
