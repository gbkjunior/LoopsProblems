using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsProblems
{
    class ThreeInputs
    {
        public void GetThreeInputs()
        {
                Console.WriteLine("Please enter two values and an operator.");
                //Console.WriteLine("For Example:" + "2,3,+");
                //string userInput = Console.ReadLine();
                //if(!userInput.Contains(","))
                //{
                //    Console.WriteLine("Please enter the input in the format specified above.");
                //}
                ////long value1 = long.Parse(userInput.Substring(0,userInput.IndexOf(",")));
                //long value2 = long.Parse(userInput.Substring(userInput.IndexOf(",")+1,(userInput.LastIndexOf(",")-userInput.IndexOf(",")-1)));
                //char oper = char.Parse(userInput.Substring(userInput.LastIndexOf(",")+1,1));

                bool checkValue1 = long.TryParse(Console.ReadLine(), out long value1);
                bool checkValue2 = long.TryParse(Console.ReadLine(), out long value2);
                bool checkOper = char.TryParse(Console.ReadLine(), out char oper);
                if(!checkValue1 || !checkValue2 || !checkOper)
                {
                    Console.WriteLine("Please enter two integer values and an operator");
                }
                else
                {
                    PerformOperation(value1, value2, oper);
                }
                
            

        }

        private void PerformOperation(long val1, long val2, char c)
        {
            try
            {
                if (c == '+')
                {
                    Console.WriteLine(val1 + val2);
                }
                else if (c == '-')
                {
                    Console.WriteLine(val1 - val2);
                }
                else if (c == '*')
                {
                    Console.WriteLine(val1 * val2);
                }
                else if (c == '/')
                {
                    Console.WriteLine(val1 / val2);
                }
                else if (c == '%')
                {
                    Console.WriteLine(val1 % val2);
                }
                else
                {
                    Console.WriteLine("Please enter a valid mathematical operator");
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0} \n Result: Infinity", e.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.ToString());
            }
        }
    }
}
