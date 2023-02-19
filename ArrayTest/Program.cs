using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of integers in the array
            Console.WriteLine("Enter the number of integers in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Create an array of integers
            int[] numbers = new int[n];

            // Prompt the user to enter each integer and store it in the array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter integer number " + (i + 1) + ":");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Create an instance of the ArraySum class
            ArraySum arraySum = new ArraySum();

            // Call the Sum method to calculate the sum of the numbers and print the result
            int sum = arraySum.Sum(numbers);
            Console.WriteLine("The sum of the numbers is: " + sum);

            Console.ReadKey();
        }
    }
}
