using System;

namespace IterationStatements3
{
    class Program
    {
        // 1. Method to print numbers 1000 through -1000
        public static void ThousandCounter()
        {
            for (int i = 1000; i >= -1000; i--)

            {
                Console.WriteLine(i);
            }

        }
        // 2. Method to print 3 through 999 by 3
        public static void ThreeCounter()
        {
            int num = 0;
            do
            {
                num += 3;
                Console.WriteLine(num);
            }
            while (num >= 3 && num < 999);
        }
        // 3. Method to check whether 2 given numbers are equal
        // Numbers entered by me
        public static void EqualOrNot(int numOne, int numTwo)
        {


            if (numOne == numTwo)
            {
                Console.WriteLine("The two numbers are equal.");
            }
            else
            {
                Console.WriteLine("The two numbers are not equal.");
            }
        }
        // 4. Method to check whether a given number is even or odd
        // Numbers entered by user
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number to check if it is even or odd:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

        }
        // 5. Method to check whether a given number is positve or negative
        // Numbers entered by user
        // Can store as a string for later
        public static string PosOrNeg()
        {
            Console.WriteLine("Enter a number to check if it is positive or negative:");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber >= 0)
            {
                return "The number is positive.";
            }
            else
            {
                return "The number is negative.";
            }
        }
        // 6. Method to read the age of a candidate and determine whether they can vote
        public static void VotingEligibility()
        {
            Console.WriteLine("You must be 18 or older to vote.");
            Console.WriteLine("Please enter your age to confirm voting eligibility:");
            var age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote!!");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
                Console.WriteLine($"Please try again in {18 - age} years.");
            }
        }
        // 1. Method to check if number is in range -10 to 10
        public static void InRange()
        {
            Console.WriteLine("I am thinking of a range of 21 numbers.");
            Console.WriteLine("I will give you 5 chances to guess a number within the range.");
            Console.WriteLine("Please enter your first guess:");
            


            for (int i = 0; i < 5; i++)
            {
                int userGuess = int.Parse(Console.ReadLine());
                if (userGuess > 10 || userGuess < -10)
                {
                    Console.WriteLine("Sorry, you are out of range. Try again!");
                }
                else
                {
                    Console.WriteLine("Perfect! You have guessed within range!");
                    break;
                }
                
            }

        }
        // 2. Method to display multiplication table from 1 to 12 of a given number
        // Numbers entered by me
        public static void MultiplicationTable(int multiplier)
        {

            int tableNumber = 1;
            for (int i = 0; i < 12; i++)
     
            {
                int newMultiple = multiplier * tableNumber ;

                tableNumber++;
                
                Console.WriteLine(newMultiple);


            }
        }
        static void Main(string[] args)
        {
            //Method 1
            ThousandCounter();
            //Method 2
            ThreeCounter();
            //Method 3
            EqualOrNot(2, 2);
            //Method 4
            EvenOrOdd();
            //Method 5
            var tool = PosOrNeg();
            Console.WriteLine($"{tool} Thank you for participating.");
            //Method 6
            VotingEligibility();
            //Method 1 Heatin Up
            InRange();
            //Method 2 Heatin Up
            MultiplicationTable(8);

         }
    }
}
