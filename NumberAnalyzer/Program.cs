using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:

            
            Console.WriteLine("Welcome");

            // Get user input
            Console.WriteLine("Please enter a number between 1 and 100?");

            double input = double.Parse(Console.ReadLine());
            

            // Use Modulus Operator to check for even/odd integar

            bool even = input % 2 == 0;
            bool odd = input % 2 == 1;

            // check ranges
            bool range = input >= 2 && input <= 24;
            bool range1 = input >= 26 && input <= 59;
            bool range2 = input >= 60;


            // Conditional Statements
            if (odd)
            {
                Console.WriteLine(input + " " + "is an odd number");
            }
            else if (even && range)
            {
                Console.WriteLine("This is an even number and less than 25");

            }
            else if (even && range1)
            {
                Console.WriteLine("This is an even number");
            }
            else if (even && range2)
            {
                Console.WriteLine(input + " " + " is an even number");
            }
            else if (odd & range2)
            {
                Console.WriteLine(input + " " + "is an odd number");
            }

            // Continue or End Program
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("Yes or No?");

            string input2 = Console.ReadLine().ToLower();

            if (input2 == "yes")
            {
                Console.WriteLine("Awesome!!!");
                goto Start; 
            }
             else
            {
                Console.WriteLine("Thank you Goodbye.");
            }
















        }
    }
}
