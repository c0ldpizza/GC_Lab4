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
            int num;
            int factorial;

            Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);

            num = GetNumberInRange(min, max);
            factorial = GetFactorial(num);

            Console.WriteLine(factorial);

        }

        public static int GetValidInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
               Console.WriteLine("Please enter a valid input.");
            }

            return input;
        }

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

        public static int GetFactorial(int num)
        {
            int result = 1;
            for (int i = 1; i < num; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
