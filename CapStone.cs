using System;

namespace CapStone_Vacation_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to CapStone Vacation Planner 12***");
            Console.WriteLine("May I have your name?");
            String name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}.");
            Console.WriteLine("Can you please choose your desired destination : 1.Hawaii 2.Brazil");
            String Destination = Console.ReadLine();
            Console.WriteLine("How many days you would like to stay in {0}", Destination);
            int daysofstay = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the spending money you would like to bring?");
            Double spendingCash = Double.Parse(Console.ReadLine());
            Double Cashperday = spendingCash / daysofstay;
            Console.WriteLine("Hey {0} , You are going to {1} for {2} days with {3} for spending money. You can spend {4} per day", name, Destination, daysofstay, spendingCash, Cashperday);
            Console.ReadLine();
        }
    }
}
