using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseLab2023
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Names[] names = new Names[]
            {
                new Names("John Lennon"),
                new Names("Paul McCartney"),
                new Names("George Harrison"),
                new Names("Ringo Starr"),
            };

            bool keepAsk = true;
            bool stuName = true;
            
            Console.WriteLine("Welcome to the student databse.");
            while (keepAsk)
            {
                bool goodAns = false;
                while (!goodAns)
                {
                    Console.WriteLine("Please enter the number for the student you would like choose from " +
                        "1 - 4. If you know the name of the student you would like to see, you may enter that " +
                        "instead. (Enter 5 for a list of current students.): ");
                    string userAns1 = Console.ReadLine().ToLower();
                    goodAns = int.TryParse(userAns1, out int userChoice);

                    Console.WriteLine();

                    if (goodAns)
                    {
                        if (userChoice < 1 || userChoice > 5)
                        {
                            Console.WriteLine("We do not have a student by that number. Please try again.\n");
                            goodAns = false;
                        }
                        else if (userChoice == 5)
                        {
                            foreach (Names nameSearch in names)
                            {
                                Console.WriteLine(nameSearch.name);
                            }
                            Console.WriteLine();
                            goodAns = false;
                        }
                        else if (userChoice >= 1 && userChoice < 5)
                        {
                            Console.WriteLine($"\n {names[userChoice - 1].name} \n");
                            ExtraInfo.stuInfo(userChoice, goodAns, userAns1);
                        }
                    }
                    else if (!goodAns)
                    {
                        if (userAns1 == "john" || userAns1 == "lennon")
                        {
                            stuName = true;
                        }
                        else if (userAns1 == "paul" || userAns1 == "mccartney")
                        {
                            stuName = true;
                        }
                        else if (userAns1 == "george" || userAns1 == "harrison")
                        {
                            stuName = true;
                        }
                        else if (userAns1 == "ringo" || userAns1 == "starr")
                        {
                            stuName = true;
                        }
                        else
                        {
                            stuName = false;
                        }

                        if (stuName && names.Any(x => x.name.Contains(userAns1, StringComparison.CurrentCultureIgnoreCase)))
                        {
                            foreach (Names nameSearch in names)
                            {
                                if (nameSearch.name.Contains(userAns1, StringComparison.CurrentCultureIgnoreCase))
                                {
                                    Console.WriteLine(nameSearch.name);
                                }
                            }
                            Console.WriteLine();
                            ExtraInfo.stuInfo(userChoice, goodAns, userAns1);
                            goodAns = true;
                        }
                        else if (!stuName)
                        {
                            Console.WriteLine("I do not understand your input. Please try again.\n");
                        }
                    }
                }
                keepAsk = Validator.getContinue();
            }
        }
    }
}

