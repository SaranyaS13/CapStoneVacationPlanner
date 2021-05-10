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
            Console.WriteLine($"Welcome {name}.Can you please choose your desired destination : (1)Mexico (2)Brazil");
            String Destination = Console.ReadLine().ToLower();
            int daysofstay;
            double totalhours,totalminutes;
            switch (Destination)
            {

                case "mexico":
                    {
                        Console.WriteLine("Great, {0} sounds like an amazing trip!",Destination.ToUpper());
                        Console.WriteLine("******************************************");
                        Console.WriteLine("Hi {0} !.How many days are you planning to stay in {1}",name,Destination.ToUpper());
                        daysofstay = int.Parse(Console.ReadLine());
                        totalhours = daysofstay * 24;
                        totalminutes = totalhours * 60;
                        Console.WriteLine("Hi User,You will have {0} hours which is {1} minutes stay in {2}", totalhours, totalminutes,Destination);
                        Console.WriteLine("Please enter the spending money you would like to bring?");
                        Double spendingCash = Double.Parse(Console.ReadLine());
                        Double Cashperday = spendingCash / daysofstay;
                        Double moneyinpeso = spendingCash * 19.91;
                        Double moneyinpesoperday = moneyinpeso / daysofstay;
                        Console.WriteLine("You can spend {0} peso in a day", moneyinpesoperday);
                        Console.WriteLine("Hey {0} , You are going to {1} for {2} days with {3}$ to spend. You can spend {4} peso per day", name, Destination, daysofstay, spendingCash, moneyinpesoperday);
                        break;
                    }
                case "jamaica":
                    {
                        Console.WriteLine("Great, {0} sounds like an amazing trip!",Destination.ToUpper());
                        Console.WriteLine("******************************************");
                        Console.WriteLine("Hi {0} !.How many days are you planning to stay in {1}",name,Destination.ToUpper());
                        daysofstay = int.Parse(Console.ReadLine());
                        totalhours = daysofstay * 24;
                        totalminutes = totalhours * 60;
                        Console.WriteLine("Hi User,You will have {0} hours which is {1} minutes stay in {2}", totalhours, totalminutes,Destination);
                        Console.WriteLine("Please enter the spending money you would like to bring?");
                        Double spendingCash = Double.Parse(Console.ReadLine());
                        Double Cashperday = spendingCash / daysofstay;
                        Double moneyinjmcdollar = spendingCash * 152.21;
                        Double moneyinjmcdollarperday = moneyinjmcdollar / daysofstay;
                        Console.WriteLine("You can spend {0} peso in a day", moneyinjmcdollarperday);
                        Console.WriteLine("Hey {0} , You are going to {1} for {2} days with {3}$ to spend. You can spend {4} peso per day", name, Destination.ToUpper(), daysofstay, spendingCash, moneyinjmcdollarperday);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
