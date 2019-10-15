using System;
using System.Diagnostics;
using static Conditionals.Season;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            var season = Season.Winter;

            switch(season)
            {
                case Season.Autumn:
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("It is  " + season + " such a beautiful season");
                    break;

                default:
                    Console.WriteLine("It got to be " + season +"! such a cold and sad season");
                    break;
            }

            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning!");
            else if(hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");

            bool isGoldCustomer = true;
            
            /*
            float price;

            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
                */
            //That was the same that this
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }
    }
}
