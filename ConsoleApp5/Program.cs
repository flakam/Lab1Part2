using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendSuggestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user
            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("\nHere are your options:");

            // Initialize the options in an Array
            string[] options = new string[] { "Action", "Chill times", "Danger", "Good food" };

            // Display the options to the user
            int response;
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
            }

            Console.WriteLine();

            // Read user's choice
            Console.Write("Choose an option : ");
            response = int.Parse(Console.ReadLine());

            // Check the choice and display the appropriate suggestion
            if (response >= 1 && response <= 4)
            {
                Console.WriteLine();

                // Read the number of people and display a suggestion based on the number
                int people = 0;
                Console.Write("How many people are you bringing with you? ");
                people = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (people >= 0)
                {
                    if (response == 1)
                    {
                        Console.WriteLine();

                        if (people == 0)
                            Console.WriteLine("You should go Stock car racing in sneakers");
                        else if (people >= 1 && people <= 4)
                            Console.WriteLine("You should go Stock car racing in a sedan");
                        else if (people >= 5 && people <= 10)
                            Console.WriteLine("You should go Stock car racing in a Volkswagen bus");
                        else if (people > 11)
                            Console.WriteLine("You should go Stock car racing in an airplane");
                    }
                    else if (response == 2)
                    {
                        Console.WriteLine();

                        if (people == 0)
                            Console.WriteLine("You should go Hiking in sneakers");
                        else if (people >= 1 && people <= 4)
                            Console.WriteLine("You should go Hiking in a sedan");
                        else if (people >= 5 && people <= 10)
                            Console.WriteLine("You should go Hiking in a Volkswagen bus");
                        else if (people > 11)
                            Console.WriteLine("You should go Hiking in an airplane");
                    }
                    else if (response == 3)
                    {
                        Console.WriteLine();

                        if (people == 0)
                            Console.WriteLine("You should go Skydiving in sneakers");
                        else if (people >= 1 && people <= 4)
                            Console.WriteLine("You should go Skydiving in a sedan");
                        else if (people >= 5 && people <= 10)
                            Console.WriteLine("You should go Skydiving in a Volkswagen bus");
                        else if (people > 11)
                            Console.WriteLine("You should go Skydiving in an airplane");
                    }
                    else if (response == 4)
                    {
                        Console.WriteLine();

                        if (people == 0)
                            Console.WriteLine("You should go to Taco Bell in sneakers");
                        else if (people >= 1 && people <= 4)
                            Console.WriteLine("You should go to Taco Bell in a sedan");
                        else if (people >= 5 && people <= 10)
                            Console.WriteLine("You should go to Taco Bell in a Volkswagen bus");
                        else if (people > 11)
                            Console.WriteLine("You should go to Taco Bell in an airplane");
                    }
                }
                else
                {
                    Console.WriteLine("Input was not understood!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Input was not understood!");
                return;
            }


            //Say Goodbye to user!
            Console.WriteLine();
            Console.WriteLine("Goodbye and have fun!");
        }
    }
}

