using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int min = 1;
        static int max = 10;

        static void Main(string[] args)
        {
            bool run = true;

            do
            {

                int num;
                long factorial;

                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);

                //Gets input from user, validates, and calculates factorial
                num = GetNumberInRange(min, max);
                factorial = GetFactorial(num);

                Console.WriteLine(factorial);

                //Asks user to continue
                Console.WriteLine("Do you want to continue?");

                string input = Console.ReadLine();

                if (input.ToLower() == "no")
                    run = false;



            } while (run);


        }
        //Validates that input is an integer
        public static int GetValidInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }

            return input;
        }
        //Validates that integer is within a given range
        public static int GetNumberInRange(int min, int max)
        {
            int input = GetValidInput();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInput();
            }
            return input;
        }
        //Calculates factorial
        public static long GetFactorial(int num)
        {
            long result = 1;
            for (int i = 1; i < num; i++)
            {
                result = result * i;
            }
            return result;
        }

    }
}
