using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1234;

            string xString = x.ToString(); //Converts the integer to a string so each character can be easily displayed seperately.



            Console.WriteLine($"{xString[0]}{xString[1]}{xString[2]}{xString[3]}"); //Manually outputs all the combinations.
            Console.WriteLine($"{xString[0]}{xString[1]}{xString[3]}{xString[2]}");
            Console.WriteLine($"{xString[0]}{xString[2]}{xString[1]}{xString[3]}");
            Console.WriteLine($"{xString[0]}{xString[2]}{xString[3]}{xString[1]}");
            Console.WriteLine($"{xString[0]}{xString[3]}{xString[1]}{xString[2]}");
            Console.WriteLine($"{xString[0]}{xString[3]}{xString[2]}{xString[1]}");

            Console.WriteLine($"{xString[1]}{xString[1]}{xString[2]}{xString[3]}");
            Console.WriteLine($"{xString[1]}{xString[1]}{xString[3]}{xString[2]}");
            Console.WriteLine($"{xString[1]}{xString[2]}{xString[1]}{xString[3]}");
            Console.WriteLine($"{xString[1]}{xString[2]}{xString[3]}{xString[1]}");
            Console.WriteLine($"{xString[1]}{xString[3]}{xString[1]}{xString[2]}");
            Console.WriteLine($"{xString[1]}{xString[3]}{xString[2]}{xString[1]}");

            Console.WriteLine($"{xString[2]}{xString[1]}{xString[2]}{xString[3]}");
            Console.WriteLine($"{xString[2]}{xString[1]}{xString[3]}{xString[2]}");
            Console.WriteLine($"{xString[2]}{xString[2]}{xString[1]}{xString[3]}");
            Console.WriteLine($"{xString[2]}{xString[2]}{xString[3]}{xString[1]}");
            Console.WriteLine($"{xString[2]}{xString[3]}{xString[1]}{xString[2]}");
            Console.WriteLine($"{xString[2]}{xString[3]}{xString[2]}{xString[1]}");

            Console.WriteLine($"{xString[2]}{xString[1]}{xString[2]}{xString[3]}");
            Console.WriteLine($"{xString[2]}{xString[1]}{xString[3]}{xString[2]}");
            Console.WriteLine($"{xString[2]}{xString[2]}{xString[1]}{xString[3]}");
            Console.WriteLine($"{xString[2]}{xString[2]}{xString[3]}{xString[1]}");
            Console.WriteLine($"{xString[2]}{xString[3]}{xString[1]}{xString[2]}");
            Console.WriteLine($"{xString[2]}{xString[3]}{xString[2]}{xString[1]}");
        }
    }
}