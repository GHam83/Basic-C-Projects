using System;


class Program
    {
    static void Main()
    {
        Console.WriteLine("Let's count to ten!");
        int i = 0;
        while (i < 11)
        {
            Console.WriteLine(i);
            i++;
        }

        Console.ReadLine();
        Console.WriteLine("Let's do it again with a different method!");
        int n = 0;
        do
        {
            Console.WriteLine(n);
            n++;
        }
        while (n < 11);
        Console.ReadLine();
    }
    }


