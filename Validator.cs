using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseLab2023
{
    internal class Validator
    {
        public static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Would you like to see another student? (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                choice = choice.Trim();
                Console.WriteLine();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {

                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I do not understand your input. Please try again.");
                    Console.WriteLine();
                }
            }
            return result;
        }
    }
}
