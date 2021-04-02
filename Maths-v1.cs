using System;

namespace Basic_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title Screen
            Console.WriteLine("_____________________________");
            Console.WriteLine(" __  __       _    _         ");
            Console.WriteLine("|  V  | __ _ | |_ | |_    ___");
            Console.WriteLine("| |V| |/ _` ||  _||    | (_-/");
            Console.WriteLine("|_| |_| __/_|  __||_||_| /__/");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Gordon P Maurice Maths-v1.cs \n");

            //Instructions
            Console.WriteLine("Choose two whole numbers and ");
            Console.WriteLine("Choose to add (+) subtract(-)");
            Console.WriteLine("Multiply(x) or Divide(/)     ");
            Console.WriteLine("To exit type 'exit'          ");

            //Main code
            while (true)
            {

                //First Number
                int firstInt = StrConverter("\nFirst");

                //Second Number
                int secondInt = StrConverter("Second");

                //Choice of operation
                int Result = FinalResult(firstInt, secondInt);
                Console.WriteLine("The Answer is: " + Result);
                
            }
            




        }
        
        //gets users response error checks it and converts it to int
        static int StrConverter(string lineNumber)
        {
            do
            {
                Console.Write(lineNumber + " Number: ");
                string Num = Console.ReadLine();

                if(Num == "exit")
                {

                    System.Environment.Exit(1);

                }

                try
                {

                    int convertedInt = Convert.ToInt32(Num);
                    return convertedInt;

                }

                catch
                {

                    Console.WriteLine("That is not a whole number");

                }

            } while (true);
            
        }

        //gets user input error checks calculates result returns result to main
        static int FinalResult(int firstInt, int secondInt)
        {
            do
            {

                Console.Write("Operation Type: ");
                string mathsType = Console.ReadLine();
                if (mathsType == "exit")
                {

                    System.Environment.Exit(1);

                }

                else if (mathsType == "/")
                {

                    int result = firstInt / secondInt;
                    return result;

                }
                else if (mathsType == "x")
                {

                    int result = firstInt * secondInt;
                    return result;

                }
                else if (mathsType == "-")
                {

                    int result = firstInt - secondInt;
                    return result;

                }
                else if (mathsType == "+")
                {

                    int result = firstInt + secondInt;
                    return result;

                }
                else
                {

                    Console.WriteLine("That is not a valid choice");

                }

            } while (true);
        }

    }
}
       
