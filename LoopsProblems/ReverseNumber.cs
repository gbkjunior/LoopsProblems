using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsProblems
{
    class ReverseNumber
    {
        public void FindReverse()
        {
            try
            {
                string userInput;
                Console.WriteLine("Please enter an integer:");
                userInput = Console.ReadLine();

                if (long.TryParse(userInput, out long userInputValue))
                {
                    Console.WriteLine(GetReverse(userInputValue));
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.ToString());
            }
            
        }

        private long GetReverse(long userInputValue)
        {
            long testValue = userInputValue;
            long reverse = 0;
            while (userInputValue != 0)
            {
                
                testValue = userInputValue % 10;
                reverse = reverse * 10 + testValue;
                userInputValue = userInputValue / 10;
            }
            return reverse;
        }
    }
}
