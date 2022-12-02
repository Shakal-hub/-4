using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = new int();
            Console.WriteLine("Type:\n\ta - insert value of a\n\tb - insert value of b\n\t+ - perform summation\n\t- - perform substraction\n\t* - perform multiplication\n\t/ - perform division");
            string command = Console.ReadLine();
            if (command != null)
            {
                if (command == "a")
                {
                    Console.WriteLine("Set value:\n");
                    a = Int32.Parse(Console.ReadLine());
                }
                else if (command == "b")
                {
                    Console.WriteLine("Set value:\n");
                    b = Int32.Parse(Console.ReadLine());
                }
                else if (command == "-")
                {
                    Console.WriteLine(a - b);
                }
            }

        }
    }
}
