using System;

namespace EmployeeDatabase
{
    class Program
    {
        // 1st method
        static void DisplayGreeting()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to Our Employee Database");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        } /* take input ----> */
        static string PromptForString(string prompt) /* this is a method */
        {
            Console.WriteLine("💙💚💛🧡❤️💜");
            // Use the argument, whatever the caller sent us.
            Console.Write(prompt);

            // Get some user input
            var userInput = Console.ReadLine();

            // RETURN that value as the output of this method.
            // The value in `userInput` will go wherever the
            // *CALLER* of the method has specified.
            return userInput;
        }
        static int PromptForInteger(string prompt) /* this has to be a string prompt for the console output */
        {
            //Console.Write(prompt);<- exchanged below for this 

            var userInput = PromptForString(prompt);

            int inputAsInteger;
            var isThisGoodInput = int.TryParse(userInput, out inputAsInteger);
            // var inputAsInteger = int.Parse(userInput);

            if (isThisGoodInput)
            {
                return inputAsInteger;
            }
            else
            {
                Console.WriteLine("uh-oh, that's not a number value - have a 0.");
                return 0;
            }

        }


        static void Main(string[] args)
        {
            // 1st method called on 
            DisplayGreeting();

            var name = PromptForString("What is your name? "); /* ----> return output */

            var department = PromptForInteger("What is your department number? ");

            var salary = PromptForInteger("What is your yearly salary (in dollars)? ");
            //var salary = int.Parse(Console.ReadLine());

            var salaryPerMonth = salary / 12.0;
            Console.WriteLine($"Hello, {name} you make {salaryPerMonth} a month.");
        }
    }
}