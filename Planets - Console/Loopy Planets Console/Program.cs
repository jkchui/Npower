using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy_Planets_Console
    //Choose a planet, enter your weight. See how much you'll weigh on that planet
{
    class Program
    {
        static void Main(string[] args)
        {
            //sets variables for conversion rates
            double mercuryMultiplier = 0.37;
            double venusMultiplier = 0.88;
            double marsMultiplier = 0.38;
            double jupiterMultiplier = 2.64;
            double saturnMultiplier = 1.15;
            double myanusMultiplier = 1.15;
            double neptuneMultiplier = 1.12;
            double plutoMultiplier = 0.04;

            //sets up scanner to get user input, declares variables for storing input
            //Scanner userInput = new Scanner(System.in);
            String planetSelection = "";
            String weightEarth = "";
         
            //starts loop until user chooses "9" for Quit
            while (planetSelection != "9")
            {

                try
                {
                    //gets user input for planet and stores as integer
                    Console.WriteLine("\n          Menu of Planets\n          ==== == =======");
                    Console.WriteLine("1. Jupiter    2. Mars     3. Mercury\n4. Neptune    5. Pluto    6. Saturn\n7. Uranus     8. Venus    9. <Quit>\n");
                    Console.Write("Enter your menu choice: ");
                    planetSelection = Console.ReadLine();
                    int planetChoiceInt = Convert.ToInt32(planetSelection);

                    //breaks loop if user chooses "9" for Quit
                    if (planetChoiceInt == 9)
                    {
                        Console.WriteLine("GOOD BYEEE!");
                        break;
                    }

                    //checks that the menu selection is valid
                    else if (1 > planetChoiceInt || 9 < planetChoiceInt)
                    {
                        Console.WriteLine("Please enter an integer from 1-9 to make your selection.");
                    }

                    else
                    {
                        //gets and stores user input for weight
                        Console.Write("Enter your weight on earth: ");
                        weightEarth = Console.ReadLine();

                        //converts stored weight string to a float and calculates weight on selected planet
                        double weightNew = Convert.ToDouble(weightEarth);
                        switch (planetSelection)
                        {
                            case "1":
                                weightNew *= jupiterMultiplier;
                                break;
                            case "2":
                                weightNew *= marsMultiplier;
                                break;
                            case "3":
                                weightNew *= mercuryMultiplier;
                                break;
                            case "4":
                                weightNew *= neptuneMultiplier;
                                break;
                            case "5":
                                weightNew *= plutoMultiplier;
                                break;
                            case "6":
                                weightNew *= saturnMultiplier;
                                break;
                            case "7":
                                weightNew *= myanusMultiplier;
                                break;
                            case "8":
                                weightNew *= venusMultiplier;
                                break;
                        }

                        //matches planet selection to planet name
                        String planet = "";
                        switch (planetSelection)
                        {
                            case "1":
                                planet = "Jupiter";
                                break;
                            case "2":
                                planet = "Mars";
                                break;
                            case "3":
                                planet = "Mercury";
                                break;
                            case "4":
                                planet = "Neptune";
                                break;
                            case "5":
                                planet = "Pluto";
                                break;
                            case "6":
                                planet = "Saturn";
                                break;
                            case "7":
                                planet = "Uranus";
                                break;
                            case "8":
                                planet = "Venus";
                                break;
                        }


                        //prints converted weight
                        Console.WriteLine("\nYour weight of " + weightEarth + " pounds on Earth would be " + weightNew.ToString() + " pounds on " + planet + ".");
                        }
                }
                //catches non-convertible strings (eg. if user enters "Jupiter" instead of "1")
                catch (System.FormatException e)
                {
                    Console.WriteLine("Please enter an integer between 1-9 for menu choice or a number for your weight on Earth.");
                }
            }
            // Closing Statement, Author's CodeName, and a farewell
            Console.WriteLine("Press any key to exit."); 
            Console.WriteLine("░░░░▄██████████████████▄░░░░░|--------------------------------------------------------------|");
            Console.WriteLine("░░░█▀░░░░░░░░░░░▀▀███████░░░░|Planets De La Loop                            -By Jesse Chui  |");
            Console.WriteLine("░░█▌░░░░░░░░░░░░░░░▀██████░░░|--------------------------------------------------------------|");
            Console.WriteLine("░█▌░░░░░░░░░░░░░░░░███████▌░░");
            Console.WriteLine("░█░░░░░░░░░░░░░░░░░████████░░");
            Console.WriteLine("░▌▄███▌░░░░▀████▄░░░░▀████▌░░");
            Console.WriteLine("▐▀▀▄█▄░▌░░░▄██▄▄▄▀░░░░████▄▄░");
            Console.WriteLine("▐░▀░░═▐░░░░░░══░░▀░░░░▐▀░▄▀▌▌");
            Console.WriteLine("▐░░░░░▌░░░░░░░░░░░░░░░▀░▀░░▌▌");
            Console.WriteLine("▐░░░▄▀░░░▀░▌░░░░░░░░░░░░▌█░▌▌");
            Console.WriteLine("░▌░░▀▀▄▄▀▀▄▌▌░░░░░░░░░░▐░▀▐▐░");
            Console.WriteLine("░▌░░▌░▄▄▄▄░░░▌░░░░░░░░▐░░▀▐░░");
            Console.WriteLine("░█░▐▄██████▄░▐░░░░░░░░█▀▄▄▀░░");
            Console.WriteLine("░▐░▌▌░░░░░░▀▀▄▐░░░░░░█▌░░░░░░");
            Console.WriteLine("░░█░░▄▀▀▀▀▄░▄═╝▄░░░▄▀░▌░░░░░░");
            Console.WriteLine("░░░▌▐░░░░░░▌░▀▀░░▄▀░░▐░░░░░░░");
            Console.WriteLine("░░░▀▄░░░░░░░░░▄▀▀░░░░█░░░░░░░");
            Console.WriteLine("░░░▄█▄▄▄▄▄▄▄▀▀░░░░░░░▌▌░░░░░░");
            Console.WriteLine("░░▄▀▌▀▌░░░░░░░░░░░░░▄▀▀▄░░░░░");
            Console.WriteLine("▄▀░░▌░▀▄░░░░░░░░░░▄▀░░▌░▀▄░░░");
            Console.WriteLine("░░░░▌█▄▄▀▄░░░░░░▄▀░░░░▌░░░▌▄▄");
            Console.WriteLine("░░░▄▐██████▄▄░▄▀░░▄▄▄▄▌░░░░▄░");
            Console.WriteLine("░░▄▌████████▄▄▄███████▌░░░░░▄");
            Console.WriteLine("░╔╗║░╔═╗░═╦═░░░░░╔╗░░╔═╗░╦═╗░");
            Console.WriteLine("░║║║░║░║░░║░░░░░░╠╩╗░╠═╣░║░║░");
            Console.WriteLine("░║╚╝░╚═╝░░║░░░░░░╚═╝░║░║░╩═╝░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");


            // Keep the console window open (only for debug)
            Console.ReadKey();
        }
    }
}
