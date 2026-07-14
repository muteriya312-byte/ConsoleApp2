using System;
using System.Collections.Generic;
using System.Text;

namespace project3
{
    internal class _1D_Array
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;
            double average;

            //task 1 - input 5 element into this array
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter no. :");

                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            //task 2 - print array element
            Console.WriteLine("Enter element in array are:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // Task 3 - Find and print sum and average
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }

            average = (double)sum / a.Length;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);

            //task 4 - Find and print min and max 
            int min = a[0]; 
            int max = a[0]; 

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i]; 
                }

                if (a[i] > max)
                {
                    max = a[i]; 
                }
            }

            Console.WriteLine("Minimum Value = " + min);
            Console.WriteLine("Maximum Value = " + max);

            Console.ReadLine(); 
        }

    }
}