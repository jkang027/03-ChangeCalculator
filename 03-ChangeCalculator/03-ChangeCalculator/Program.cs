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
                    Console.WriteLine("Your input was not a dollar amount.");
                }
            }
        }

        static void Main(string[] args)
        {
            //Get the item's cost and amount customer paid.
            double itemCost = GetDoubleFromUser("How much does the item cost?");
            double customerPaid = GetDoubleFromUser("How much has the customer given you?");
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
                Console.WriteLine("The customer's change is: $" + change);

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

                Console.WriteLine("Hundreds: " + hundreds);
                Console.WriteLine("Fiftys: " + fiftys);
                Console.WriteLine("Twentys: " + twenties);
                Console.WriteLine("Tens: " + tens);
                Console.WriteLine("Fives: " + fives);
                Console.WriteLine("Ones: " + ones);
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes: " + dimes);
                Console.WriteLine("Nickels: " + nickels);
                Console.WriteLine("Pennies: " + pennies);
            }
            else
            {
                Console.WriteLine("The customer still owes you $" + change * -1 + ".");
            }

            Console.WriteLine("Hit enter to close.");
            Console.ReadLine();
        }
    }
}
