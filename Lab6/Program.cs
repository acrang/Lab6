using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the calculation tool!"); //greeting text
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine();

            bool userContinue = true;
            while (userContinue)

            {

                Console.WriteLine("Please enter a number and I will calculate it for you: "); 
                string userInput = Console.ReadLine();

                int number = 0;

                if (int.TryParse(userInput, out number))

                {
                    Console.WriteLine();
                    Console.WriteLine("Number\tSquared\tCubed"); //formats the headings
                    Console.WriteLine("======\t======\t======");

                    for (int i = 1; i <= number; i++)

                    {
                        Console.WriteLine($"{i}\t{SquareNumber(i)}\t{CubeNumber(i)}"); //writes out results of methods with same spacing as headings
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to continue? y/n");
                    string continueInput = Console.ReadLine();
                    Console.WriteLine();

                    if (continueInput == "n")

                    {
                        userContinue = false;

                        Console.WriteLine();
                        Console.WriteLine("Thank you. Please return when you would like more calculations."); //farewell text
                        Console.WriteLine();
                        Console.WriteLine("><><><><><><><><><><><><");

                        break;

                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.WriteLine();
                }
            }
        }

        public static int SquareNumber(int input) //method to square numbers
        {
            int output = input * input;

            return output;
        }

        public static int CubeNumber(int input) //method to cube numbers
        {
            int output = input * input * input;

            return output;
        }
    }
}