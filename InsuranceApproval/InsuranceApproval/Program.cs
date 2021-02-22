using System;



class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Insurance Approval Form");
        Console.ReadLine();

        Console.WriteLine("What is your age?");
        int Age = Convert.ToInt32(Console.ReadLine());
        bool AgeOkay = Age >= 25;
        
       

        Console.WriteLine("Have you ever had a DUI? true or false");
        string dui = Console.ReadLine();
        bool duiOk = dui == "false";
        
        

        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());
        bool ticketsOk = tickets <= 3;
        
        

        Console.WriteLine("Processing...");
        bool Approval = AgeOkay && duiOk && ticketsOk;
        Console.WriteLine("Approved?\n " + Approval);
        Console.ReadLine();
        }
    }
