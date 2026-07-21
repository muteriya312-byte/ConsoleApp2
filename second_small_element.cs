using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class second_small_element
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter size of Array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the element of index " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int small = arr[0];
            int secondsmall = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < secondsmall  || secondsmall == small)
                {
                    if (arr[i] > small)
                    {
                        secondsmall = arr[i];
                    }
                }

            }
            Console.WriteLine("Second small number is : " + secondsmall);
        }
    }
    
}
