using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsProblems
{
    class Factorial
    {
        

        public long GetFactorial(long number) 
        {
            try
            {
                if (number == 0)
                {
                    return 1;
                }
                else
                    return number * GetFactorial(number - 1);
                
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Exception caught {0}:", e.ToString());
            }
            return number;

        }

        public void FindFactorial()
        {
            try
            {
                string userInput;
                Console.WriteLine("Please enter an integer to find its factorial:");
                userInput = Console.ReadLine();
                if (long.TryParse(userInput, out long userInputValue) && userInputValue >= 0)
                {
                    Console.WriteLine(GetFactorial(userInputValue));
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive integer value");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
