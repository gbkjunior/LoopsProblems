using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsProblems
{
    class ArmstrongNumber
    {
        long sum = 0;
        public void FindArmstrongNumber()
        {
            string userInput;
            Console.WriteLine("Please enter an integer:");
            userInput = Console.ReadLine();

            if (long.TryParse(userInput, out long userInputValue))
            {
                VerifyArmstrongNumber(userInputValue);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }

        private void VerifyArmstrongNumber(long value)
        {
            try
            {
                long testValue = value;
                long rem;
                while (testValue != 0)
                {
                    rem = testValue % 10;
                    double cubeValue = (long)Math.Pow(rem, 3);
                    sum = sum + (long)cubeValue;
                    //Console.WriteLine(sum);
                    testValue = testValue / 10;

                }


                if (sum == value)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }


                sum = 0;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            
        }
    }
}
