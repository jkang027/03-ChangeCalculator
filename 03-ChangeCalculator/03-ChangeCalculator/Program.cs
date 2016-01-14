using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChangeCalculator
{
    class Program
    {
        static int GetIntFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);

                    string input = Console.ReadLine();

                    int x = int.Parse(input);

                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your input was not a valid number.");
                }
            }
        }

        static void Main(string[] args)
        {
            int itemCost = GetIntFromUser("How much does the item cost?");
            int customerPaid = GetIntFromUser("How much has the customer given you?");



            Console.WriteLine("Hit enter to close.");
            Console.ReadLine();
        }
    }
}
