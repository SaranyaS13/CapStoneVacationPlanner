using System;

namespace CapStone_Vacation_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to CapStone Vacation Planner ***");
            String name = "Saranya";
            Console.WriteLine($"Welcome {name}.");
            Console.WriteLine("Can you please choose your desired destination : 1.Hawaii 2.Brazil");
            String Destination = Console.ReadLine();
            Console.WriteLine("Your choice is " + Destination);
            Console.ReadLine();
        }
    }
}
