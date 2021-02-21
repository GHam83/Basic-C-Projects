using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\n Student Daily Report:");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            Console.ReadLine();
            string yourName = "Greg";
            Console.WriteLine("Your name is " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            Console.ReadLine();
            string course = "C#";
            Console.WriteLine("You are in " + course);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            Console.ReadLine();
            int courseNum = 140;
            Console.WriteLine("You are on page number " + courseNum);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer True or False");
            Console.ReadLine();
            bool answer = false;
            Console.WriteLine("You answered " + answer);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experirences you'd like to share? Please give specifics.");
            Console.ReadLine();
            string experience = "Learning C# is fun!";
            Console.WriteLine("You said: " + experience);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            string feedback = "Not at this time";
            Console.WriteLine("You said: " + feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();
            int hours = 8;
            Console.WriteLine("You studied " + hours + " hours!");
            Console.ReadLine();

            Console.WriteLine(" Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            
        }
    }
}
