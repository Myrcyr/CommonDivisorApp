using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDivisor
{
    class Program
    {
        /// <summary>
        /// Program to accept two numbers from the user via console, and run them through a method 
        /// to use the Euclidean algorithm to determine the greatest common divisor between them.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Constants to remove "magic strings" from console prompts
            const String PROGRAM_PROMPT = "This program will find the greatest common divisor of two numbers.\n";
            const String FIRST_NUMBER_PROMPT = "Enter the first number: \n";
            const String SECOND_NUMBER_PROMPT = "Enter the second number: \n";
            
            String userInput;
            int numOne, numTwo;
            int divisor;
            
            Console.Write(PROGRAM_PROMPT);
            Console.Write(FIRST_NUMBER_PROMPT);
            userInput = Console.ReadLine();
            int.TryParse(userInput, out numOne);

            Console.Write(SECOND_NUMBER_PROMPT);
            userInput = Console.ReadLine();
            int.TryParse(userInput, out numTwo);

            divisor = GreatestCommonDivisor(numOne, numTwo);
            Console.Write($"The greatest common divisor for {numOne} and {numTwo} is {divisor}");
            
            Console.ReadKey();

            
        }

        static int GreatestCommonDivisor(int a, int b)
        {
            int remainder;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }
    }
}
