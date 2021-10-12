using System;

namespace CircleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to the Circlator.");

            //Actually testing during making them 
            //circleTester();

            bool runProgram = true;
            int circleCount = 0;

            while (runProgram)
            {
                //getting radius from user
                double radius = getRadius();
                Circle c = new Circle(radius);
                circleCount++;

                Console.WriteLine($"AREA: {c.CalculateFormattedArea()}");
                Console.WriteLine($"CIRCUMFERENCE: {c.CalculateFormattedCircumference()}");

                runProgram = getContinue();
            }

            Console.WriteLine("Sayonara, arigato.");
            Console.WriteLine($"You made {circleCount} circles.");
        }


        static double getRadius()
        {
            double result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a radius.");
                    result = double.Parse(Console.ReadLine());
                    if (result <= 0)
                    {
                        Console.WriteLine("It cannot be 0 or less.");
                    }
                    else
                    {
                        //User has put correct input
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("It needs to be a number.");
                }
            }
            return result;
        }

        static void circleTester()
        {
            Circle c = new Circle(7);
            Console.WriteLine((c.CalculateCircumference()));
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculateFormattedCircumference());
            Console.WriteLine(c.CalculateFormattedArea());
        }

        static bool getContinue()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("LET'S TRY ANOTHER, YEAH? y/n");
                string choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if(choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Not valid input homie try that sh*t again");
                }
            }

            return result;
        }
    }
}
