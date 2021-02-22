using System;


class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Package Express!\n Please follow the instructions below.");


        Console.WriteLine("Please enter package weight");
        int weight = Convert.ToInt32(Console.ReadLine());
        bool weightOK = weight < 50;
        if (weightOK)
        {
            Console.WriteLine("Please enter package width.");
            int width = Convert.ToInt32(Console.ReadLine());
            bool widthOK = width < 50;
            if (widthOK) {
                Console.WriteLine("Please enter package height.");
                int height = Convert.ToInt32(Console.ReadLine());
                bool heightOK = height < 50;
                if (heightOK) {
                    Console.WriteLine("Please enter package length.");
                    int length = Convert.ToInt32(Console.ReadLine());
                    bool lengthOK = length < 50;
                    if (lengthOK)
                    {

                        Console.WriteLine("Processing Quote...");
                        double quote = height * width * length * weight / 100;
                        Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    }
                    else Console.WriteLine("Your package is too long to be shipped via Package Express. Have a good day."); }

                else Console.WriteLine("Your package is too high to be shipped vis Package Express. Have a good day."); }


            else Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day."); }
        else Console.WriteLine("Your package is to heavy to be shipped via Package Express. Have a good day.");
           
       
            
        

        


       
        
        Console.ReadLine();
        }
    }

