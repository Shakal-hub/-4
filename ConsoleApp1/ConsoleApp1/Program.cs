using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = new int();
            Console.WriteLine("Type:\n\ta - insert value of a\n\tb - insert value of b\n\t+ - perform summation\n\t- - perform substraction\n\t* - perform multiplication\n\t/ - perform division");
            string command = Console.ReadLine();
            if (command != null)
            {
                if (command == "b")
                {
                    Console.WriteLine("Set value:\n");
                    b = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}
