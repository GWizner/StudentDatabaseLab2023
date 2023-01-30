using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseLab2023
{
    public static class ExtraInfo
    {
        static string[] hometown = new string[] { "Liverpool", "Liverpool", "Wavertree", "Liverpool" };
        static string[] favoriteFood = new string[] { "fish & chips", "Yorkshire pudding", "dhal", "spaghetti bolognese" };
        static Names[] names = new Names[]
           {
                new Names("John Lennon"),
                new Names("Paul McCartney"),
                new Names("George Harrison"),
                new Names("Ringo Starr"),
        };
        public static void stuInfo(int userChoice, bool goodAns, string userAns1)
        {

            if (!goodAns)
            {
                int index = Array.IndexOf(names, names.FirstOrDefault(x => x.name.Contains(userAns1, StringComparison.CurrentCultureIgnoreCase)));
                userChoice = index + 1;
            }
            while (true)
            {
                Console.WriteLine("Would you like to know their hometown or favorite food? ");
                string userAns2 = Console.ReadLine().ToLower();

                if (userAns2.Contains("home") || userAns2.Contains("town"))
                {
                    Console.WriteLine($"\n{hometown[userChoice - 1]}\n");
                    break;
                }
                else if (userAns2.Contains("fav") || userAns2.Contains("food"))
                {
                    Console.WriteLine($"\n{favoriteFood[userChoice - 1]}\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nI do not understand your input. Please try again.\n");
                }

            }
        }
    }
}