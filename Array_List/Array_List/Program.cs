using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] greeting = { "Hello", "Greetings", "Q'apla!", "Namaste" };

        Console.WriteLine("Pick a number between 0 and 3.");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 < 4)
        {
            Console.WriteLine(greeting[num1]);
            Console.WriteLine("Pick a number between 0 and 3 to get a number from my Array");
            int[] PickNum = { 7, 5, 9, 3 };
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 < 4)
            {
                Console.WriteLine(PickNum[num2]);
                Console.WriteLine("Enter a number between 0 and 3.");
                List<string> vegetables = new List<string>();
                vegetables.Add("carrot");
                vegetables.Add("corn");
                vegetables.Add("green beans");
                vegetables.Add("peas");
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num3 < 4)
                {
                    Console.WriteLine(vegetables[num3]);
                }
                else
                {
                    Console.WriteLine("That number is not in the List.");
                }
            }
            else
            {
                Console.WriteLine("That number is not in the Array.");
            }





        }
        else
        {
            Console.WriteLine("That number is not in the Array.");


        }
            Console.ReadLine();
        
    }
}






