using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        string first = "hello world! ";
        string second = "How are you ";
        string third = "today. It is rainy.";
        string upper = first.ToUpper();

        StringBuilder sb = new StringBuilder("Greg Hamill");
        sb.Append("\n is learning how to use String builder");
        sb.Append("\n in C#. He is enjoying it very");
        sb.Append("\nmuch. \"So much fun\", he said when asked earlier.");



        Console.WriteLine(upper + second + third);
        Console.WriteLine(sb);
        Console.ReadLine();
        }
    }

