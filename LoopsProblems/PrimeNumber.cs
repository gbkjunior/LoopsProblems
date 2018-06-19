using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsProblems
{
    class PrimeNumber
    {
        public void FindPrimeNumber()
        {
            try
            {
                string userInput;
                Console.WriteLine("Please enter an integer:");
                userInput = Console.ReadLine();

                if (long.TryParse(userInput, out long userInputValue))
                {
                    GetPrimeNumber(userInputValue);
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}:", e.ToString());
            }
            
        }

        private void GetPrimeNumber(long value)
        {
            
            bool prime = false;
            if(value == 1 || value == 0 || value < 0)
            {
                Console.WriteLine("Please enter any number greater than or equal to 2.");
            }
            else
            {
                for (int i = 2; i <= value; i++)
                {
                    for (int j = 2; j < value; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            prime = true;
                            break;
                        }
                    }
                    if (!prime)
                    {
                        Console.Write("{0} ", i);

                    }
                    prime = false;
                }
                Console.WriteLine();
            }
            
        }
    }
}
