using System;

namespace Survey_app
{
    //program class will always get called automatically
    class Program
    {
        static void Main(string[] args)
        {
            new Survey().RunSurvey();
        }
    }
    public class Survey
    {
        public void RunSurvey()
        {
            Console.WriteLine("Welcome Zen Survey!");
            Console.WriteLine("What's Your Name:");

            string Name = Console.ReadLine();

            Console.WriteLine("Whats Your Age?");

            string Age = Console.ReadLine();

            Console.WriteLine("Whos your current broadband provider?");

            string CurrentBroadband = Console.ReadLine();

            Console.WriteLine("What is your current broadband speed?");

            string BroadbandSpeed = Console.ReadLine();

            Console.WriteLine("How long have you had the broadband service ?");

            string TimeWithService = Console.ReadLine();

            Console.WriteLine("How much do you pay monthly for your broadband service?");

            string Cost = Console.ReadLine();

            Console.WriteLine("Thank You for filling in the survey");

            Console.WriteLine("Your Name Is " + Name);
            Console.ReadLine();

            Console.WriteLine("You are " + Age);
            Console.ReadLine();

            Console.WriteLine("Your Current Broadband Provider Is " + CurrentBroadband);
            Console.ReadLine();

            Console.WriteLine("Your Broadband Speed Is " + BroadbandSpeed);
            Console.ReadLine();

            Console.WriteLine("You have spent " + TimeWithService + " With Your BroadBand Service");
            Console.ReadLine();

            Console.WriteLine("You pay £" + Cost + " Every Month");
            int Speed = int.Parse(BroadbandSpeed);
            string ZenCost = "";
            if (Speed > 50)
            {
                ZenCost = "30";
            }
            else 
            { 
                ZenCost = "20"; 
            }
            Console.WriteLine("Zencost £" + ZenCost);
            Console.ReadLine();
            int MonthlyCost = int.Parse(Cost);
            if (MonthlyCost > 50) 
            {
                int sum1 = MonthlyCost - 30;
                Console.WriteLine("You Save £" + sum1 + " With Zen Internet");
            }
            else if (MonthlyCost < 30)
            {
                int sum2 = 30 - MonthlyCost;
                Console.WriteLine("You are saving £" + sum2);
            }
        }
    }
}
//Cast parse string for speed to be an int and then find out how much it will be going off the notepad, then work out how much the save
