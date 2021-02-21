using System;


class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison");
        Console.ReadLine();

        Console.WriteLine("Person 1");
        Console.ReadLine();

        Console.WriteLine("Hourly Rate?");
        float wage1 = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        Console.WriteLine("Hours worked per week?");
        float hoursPerweek = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.ReadLine();

        Console.WriteLine("Hourly Rate?");
        float wage2 = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        Console.WriteLine("Hours worked per week?");
        float hoursPerweek2 = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        Console.WriteLine("Annual Salary of Person 1: ");
        double weeklyWage = wage1 * hoursPerweek;
        double annualSalary = weeklyWage * 52;
        Console.WriteLine(annualSalary);
        Console.ReadLine();

        Console.WriteLine("Annual Salary of Person 2: ");
        double weeklyWage2 = wage2 * hoursPerweek2;
        double annualSalary2 = weeklyWage2 * 52;
        Console.WriteLine(annualSalary2);
        Console.ReadLine();

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.ReadLine();
        bool moreThan = annualSalary > annualSalary2;
        Console.WriteLine(moreThan);
        Console.ReadLine();


        }
    }