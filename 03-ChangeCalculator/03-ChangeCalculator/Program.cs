using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChangeCalculator
{
    class Program
    {
        static double GetDoubleFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);

                    string input = Console.ReadLine();

                    double x = double.Parse(input);

                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your input was not a valid dollar amount.");
                }
            }
        }

        static void Main(string[] args)
        {
            //Get the item's cost and amount customer paid.
            double itemCost = GetDoubleFromUser("How much does the item cost?");
            double customerPaid = GetDoubleFromUser("How much has the customer given you?");
            Console.WriteLine();
            //Calculate amount for change.
            double change = Math.Round(customerPaid - itemCost, 2, MidpointRounding.ToEven);

            //Values for monetary denominations.
            double hundredVal = 100.00;
            double fiftyVal = 50.00;
            double twentyVal = 20.00;
            double tenVal = 10.00;
            double fiveVal = 5.00;
            double oneVal = 1.00;
            double quartVal = 0.25;
            double dimeVal = 0.10;
            double nickVal = 0.05;
            double pennyVal = 0.01;

            //If/else statement to determine whether change is needed or more money is needed from the customer.
            if (change >= 0)
            {
                //Calculate how many of each denomination is required.
                double hundreds = Math.Floor(change / hundredVal);
                double hundredsRemainder = (change % hundredVal);
                double fifties = Math.Floor(hundredsRemainder / fiftyVal);
                double fiftiesRemainder = (hundredsRemainder % fiftyVal);
                double twenties = Math.Floor(fiftiesRemainder / twentyVal);
                double twentiesRemainder = (fiftiesRemainder % twentyVal);
                double tens = Math.Floor(twentiesRemainder / tenVal);
                double tensRemainder = (twentiesRemainder % tenVal);
                double fives = Math.Floor(tensRemainder / fiveVal);
                double fivesRemainder = (tensRemainder % fiveVal);
                double ones = Math.Floor(fivesRemainder / oneVal);
                double onesRemainder = (fivesRemainder % oneVal);
                double quarters = Math.Floor(onesRemainder / quartVal);
                double quartersRemainder = (onesRemainder % quartVal);
                double dimes = Math.Floor(quartersRemainder / dimeVal);
                double dimesRemainder = (quartersRemainder % dimeVal);
                double nickels = Math.Floor(dimesRemainder / nickVal);
                double nickelsRemainder = (dimesRemainder % nickVal);
                double pennies = Math.Floor(nickelsRemainder / pennyVal);

                //Another way to calculate how many of each denomination is required.
                /*
                double hundreds = Math.Floor(change / hundredVal);
                double fiftys = Math.Floor(change % hundredVal / fiftyVal);
                double twenties = Math.Floor(change % hundredVal % fiftyVal / twentyVal);
                double tens = Math.Floor(change % hundredVal % fiftyVal % twentyVal / tenVal);
                double fives = Math.Floor(change % hundredVal % fiftyVal % twentyVal % tenVal / fiveVal);
                double ones = Math.Floor(change % hundredVal % fiftyVal % twentyVal % tenVal % fiveVal / oneVal);
                double quarters = Math.Floor(change % hundredVal % fiftyVal % twentyVal % tenVal % fiveVal % oneVal / quartVal);
                double dimes = Math.Floor(change % hundredVal % fiftyVal % twentyVal % tenVal % fiveVal % oneVal % quartVal / dimeVal);
                double nickels = Math.Floor(change % hundredVal % fiftyVal % twentyVal % tenVal % fiveVal % oneVal % quartVal % dimeVal / nickVal);
                double pennies = Math.Round(change % hundredVal % fiftyVal % twentyVal % tenVal % fiveVal % oneVal % quartVal % dimeVal % nickVal / pennyVal);
                */

                //Print to console the total change and how many of each denomination is required.
                Console.WriteLine("The customer's change is: $" + change);
                Console.WriteLine();

                Console.WriteLine("Hundreds: " + hundreds);
                Console.WriteLine("Fifties: " + fifties);
                Console.WriteLine("Twenties: " + twenties);
                Console.WriteLine("Tens: " + tens);
                Console.WriteLine("Fives: " + fives);
                Console.WriteLine("Ones: " + ones);
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes: " + dimes);
                Console.WriteLine("Nickels: " + nickels);
                Console.WriteLine("Pennies: " + pennies);
                Console.WriteLine();
            }

            //If the change due to the customer is negative (or the customer still owes more money), this will happen.
            else
            {
                Console.WriteLine("The customer still owes you $" + change * -1 + ".");
                Console.WriteLine();
            }

            Console.WriteLine("Hit enter to close.");
            Console.ReadLine();
        }
    }
}
