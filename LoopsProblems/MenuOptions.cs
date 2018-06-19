using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsProblems
{
    
    class MenuOptions
    {
        Factorial factObject = new Factorial();
        ReverseNumber reverseObject = new ReverseNumber();
        ArmstrongNumber armstrongObject = new ArmstrongNumber();
        PrimeNumber primeObject = new PrimeNumber();
        ThreeInputs threeInputsObject = new ThreeInputs();

        string userInputOptions;
        public void Menu()
        {
            

            do
            {
                Console.WriteLine("Please choose from the following options: \n");
                Console.WriteLine("1. Factorial \n2. Reverse of Number \n3. Three inputs \n4. Armstrong Number \n5. Prime Numbers \n6. Exit \n");

                userInputOptions = Console.ReadLine();

                bool checkUserInputOptions = int.TryParse(userInputOptions, out int userInputOptionsValue);
                if (checkUserInputOptions)
                {
                    if(userInputOptionsValue == 6)
                    {
                        Console.ReadKey();
                        break;
                    }
                    if(userInputOptionsValue > 6 || userInputOptionsValue < 1)
                    {
                        Console.WriteLine("Please select a value from 1 to 6. \n");
                        continueCheck();
                    }
                    performAction(userInputOptionsValue);
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice from the above given options \n");
                    continueCheck();
                }
            } while (!true);
            
            

        }
        public void performAction(int value)
        {
            
            if(value == 1)
            {
                Console.WriteLine("Program to find factorial of a number. \n");
                factObject.FindFactorial();
                continueCheck();

            }
            else if( value == 2)
            {
                Console.WriteLine("Program to find Reverse of a number. \n");
                reverseObject.FindReverse();
                continueCheck();
            }
            else if(value == 3)
            {
                Console.WriteLine("Program to do operation based on the inputs. \n");
                threeInputsObject.GetThreeInputs();
                continueCheck();
            }
            else if(value == 4)
            {
                Console.WriteLine("Program to verify an armstrong number. \n");
                armstrongObject.FindArmstrongNumber();
                continueCheck();
            }
            else if(value == 5)
            {
                Console.WriteLine("Program to print prime numbers till a given number. \n");
                primeObject.FindPrimeNumber();
                continueCheck();
            }

        }

        public void continueCheck()
        {
            string continueInput;
            Console.WriteLine("Press 1 to continue or 6 to exit. \n");
            continueInput = Console.ReadLine();
            if(int.TryParse(continueInput, out int contIntValue))
            {
                if (contIntValue == 1)
                {
                    Menu();
                }
                else if (contIntValue == 6)
                {
                    Console.ReadKey();
                    
                }
                else if(contIntValue != 1 || contIntValue != 6)
                {
                    Console.WriteLine("Please enter either 1 or 6 \n");
                    continueCheck();
                }
            }
            else
            {
                Console.WriteLine("Please enter either 1 or 6");
                continueCheck();
            }
            
        }
    }
}
