using System;
using System.Collections.Generic;

namespace LoopsProblems
{
    class MainLoops
    {
        static void Main(string[] args)
        {
            MenuOptions mo = new MenuOptions();
            //mo.Menu();
            Factorial factObject = new Factorial();
            List<int> numList = new List<int>();

            Console.WriteLine("Enter three integers:");
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    numList.Add(int.Parse(Console.ReadLine()));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.ToString());
                Console.WriteLine("Please enter integer values.");
            }
            

            int sum = 0;
            foreach(int values in numList)
            {
                sum = sum + values;
            }

            Console.WriteLine(factObject.GetFactorial(sum));
            Console.ReadKey();
        }
    }
}
