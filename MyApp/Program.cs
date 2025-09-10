using System;

class Program
{
    static void Main(string[] args)
    {
        long n = 50;
        long res = Task3(n);
        Console.WriteLine("Factorial: " + res);
    }

    static long Task3(long n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * (Task3(n - 1));
        }
    }
}