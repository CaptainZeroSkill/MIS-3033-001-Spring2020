//@Author: Braden Henson

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1 = 16.46, var2 = 8.25, var3 = 0;
            double result = Add(var1, var2);
            Console.WriteLine($"{var1} + {var2} returns the value of {result.ToString("N2")}");

            double[] nums = { var1, var2, var3 };
            nums[0] = var1;
            nums[1] = var2;
            nums[2] = var3;

            result = Add(nums);

            Console.ReadKey();
        }

        /// <summary>
        /// This method adds two different values together and returns the sum of those two values
        /// </summary>
        /// <param name="variable1">The left hand operand of the operation</param>
        /// <param name="variable2">The right hand operand of the operation</param>
        /// <returns>The sum of the two values as type double</returns>
        static double Add(double variable1, double variable2)
        {
            double sum = variable1 + variable2;
            return sum;
        }

        static double Add(double[] numbersToAddUp)
        {
            double r = 0;

            //Iterating through an array with a foreach loop
            foreach (var number in numbersToAddUp)
            {
                r += number;
            }

            //Iterating through an array with a while loop
            int counter = 0;
            r = 0;

            while (counter < numbersToAddUp.Length)
            {
                var number = numbersToAddUp[counter];
                r += number;
                counter++;
            }

            r = 0;

            //Iterating through an array with a for loop
            for (counter = 0; counter < numbersToAddUp.Length; counter++)
            {
                var number = numbersToAddUp[counter];
                r += number;
            }

            return r;
        }
    }
}
