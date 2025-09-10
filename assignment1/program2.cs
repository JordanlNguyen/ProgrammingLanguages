using System;

class Program
{
    static void Main(string[] args)
    {
        Task2();
    }

    static void Task2()
    {
        int n = 100;
        int evenCount = 0;
        Random rand = new Random();
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = rand.Next(1,10000000);
        }
        for (int i = 0; i < n; i++)
        {
            if (a[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine("Even Count: " + evenCount);
    }
}