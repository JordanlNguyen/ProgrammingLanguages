using System;

class Program
{
    static void Main(string[] args)
    {
        Task1();
    }

    static void Task1()
    {
        Console.WriteLine("Enter your name: ");
        string str = Console.ReadLine();
        char[] strArray = str.ToCharArray();
        int l = 0; int r = strArray.Length - 1;
        while (l < r)
        {
            char tmp = strArray[l];
            strArray[l] = strArray[r];
            strArray[r] = tmp;
            l++; r--;
        }
        str = new string(strArray);
        Console.WriteLine("Reverse name is: " + str);
    }
    
}