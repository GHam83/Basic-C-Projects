using System;



    class Program
    {
        static void Main()
        {
        Console.WriteLine("Please enter a number: ");
        long number1 = Convert.ToInt32(Console.ReadLine());
        long addNum = number1 * 50;
        Console.WriteLine("Your number times 50 equals " + addNum);
        Console.ReadLine();

        Console.WriteLine("Please enter a number: ");
        long number2 = Convert.ToInt32(Console.ReadLine());
        long addNum2 = number2 + 25;
        Console.WriteLine("Your number plus 25 is " + addNum2);
        Console.ReadLine();

        Console.WriteLine("Please enter a number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        double addNum3 = number3 / 12.5;
        Console.WriteLine("Your number divided by 12.5 equals " + addNum3);
        Console.ReadLine();

        Console.WriteLine("Please enter a number: ");
        int number4 = Convert.ToInt32(Console.ReadLine());
        bool greater = number4 > 50;
        Console.WriteLine(greater);
        Console.ReadLine();

        Console.WriteLine("Please enter a number: ");
        int number5 = Convert.ToInt32(Console.ReadLine());
        int remainder = number5 % 7;
        Console.WriteLine("The modulus of your number is " + remainder);
        Console.ReadLine();

        }
    }
