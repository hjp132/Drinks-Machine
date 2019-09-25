using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    class Program
    {
        public static string userInput;
        public static int numTea = 10, numSugar = 10, numMilk = 10, numCoffee = 10, numCups = 10;

        public static int Teacount = 0;
        public static int teaMilkCount = 0;
        public static int teaSugarCount = 0;
        public static int coffeeCount = 0;
        static void Main()
        {
            menu();

            //int.TryParse(Console.ReadLine(), out userInput);
            userInput = Console.ReadLine();
            int result = Int32.Parse(userInput);

            do
            {
                switch (result)
                {
                    case 1:
                        TeaWithSugarMilk();
                        break;
                    case 2:
                        TeaWithMilk();
                        break;
                    case 3:
                        TeaWithSugar();
                        break;
                    case 4:
                        //coffee
                        break;
                    case 5:
                        //check inventory
                        Ingredients();
                        break;
                    case 6:
                        Quit();
                        break;

                }

                menu();


                userInput = Console.ReadLine();
                result = Int32.Parse(userInput);

                //RestartPrompt();

            } while (IngridCheck());


            Console.Write("Error: Not enough ingredients");
        }
        static bool IngridCheck()
        {
            if (numTea <= 0)
            {
                return false;
            }
            else if (numMilk <= 0)
            {
                return false;
            }
            if (numSugar <= 0)
            {
                return false;
            }
            if (numCoffee <= 0)
            {
                return false;
            }
            if (numCups <= 0)
            {
                return false;
            }

            return true;
        }


        static void menu()
        {
            Console.WriteLine("1. - Tea with sugar and milk");
            Console.WriteLine("2. - Tea with milk");
            Console.WriteLine("3. - Tea with sugar");
            Console.WriteLine("0. - Exit");
        }
        static void TeaWithSugarMilk()
        {
            TeaCount();
            string message = "You have chosen Tea with Sugar and Milk. This drink has been ordered: " + Teacount + " times.";
            Console.WriteLine(message);


            Tea1Cost();


        }

        static void TeaWithMilk()
        {
            TeaMilkCount();
            string message = "You have chosen Tea with Milk. This drink has been ordered: " + teaMilkCount + " times.";
            Console.WriteLine(message);
            Tea2Cost();
        }

        static void TeaWithSugar()
        {
            TeaSugarCount();
            string message = "You have chosen Tea with Sugar. This drink has been ordered: " + teaSugarCount + " times.";
            Console.WriteLine(message);
            Tea3Cost();
        }

        static void Coffee()
        {
            CoffeeCount();
            string message = "You have chosen Tea with Sugar. This drink has been ordered: " + teaSugarCount + " times.";
            Console.WriteLine(message);

        }

        static char GetUserInputChar(string message)
        {
            Console.WriteLine(message);
            return Console.ReadKey().KeyChar;
        }


        static int TeaCount()
        {
            return Teacount = (Teacount + 1);
        }

        static int TeaMilkCount()
        {
            return teaMilkCount = (teaMilkCount + 1);
        }

        static int TeaSugarCount()
        {
            return teaSugarCount = (teaSugarCount + 1);
               
        }

        static int CoffeeCount()
        {
            return coffeeCount = (coffeeCount + 1);
        }

        static void Tea1Cost()
        {
            numTea = numTea - 1;
            numSugar = numSugar - 1;
            numMilk = numMilk - 1;
            numCups = numCups - 1;

        }



        static void Ingredients()
        {
            Console.WriteLine(numTea);
            Console.WriteLine(numSugar);
            Console.WriteLine(numMilk);
            Console.WriteLine(numCups);
        }



        static void Tea2Cost()
        {
            numTea = numTea - 1;
            numMilk = numMilk - 1;
            numCups = numCups - 1;
        }


        static void Tea3Cost()
        {
            numTea = numTea - 1;
            numSugar = numSugar - 1;
            numCups = numCups - 1;
        }

        static void CoffeeCost()
        {
            numCoffee = numCoffee - 1;
            numCups = numCups - 1;
        }

        static void Quit()
        {
            Console.WriteLine("\nQuiting\n");
            // quits the application
            System.Environment.Exit(1);
        }


        static void RestartPrompt()
        {
            string message = "\nWould you like to input any additional values? y/n:";
            Console.WriteLine(message);
            userInput = Console.ReadKey().KeyChar.ToString().ToLower();
            if (userInput == "y")
            {
                Console.WriteLine("");
                Main();
            }
            else
            {
                // runs Quit, ending the program
                Quit();
            }



        }










    }
}
