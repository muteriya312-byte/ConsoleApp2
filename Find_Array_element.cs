using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Find_Array_element
    {
        static void Main(string[] args)
        {
            int n, i, search, count = 0;

            Console.WriteLine("Enter the size of Array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter elment of index " + i + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter elment that you want to search : ");
            search = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (arr[i] == search)
                {
                    count++;
                }
            }
            Console.WriteLine(search + " occurs " + count + " time in the array");
        }
    }
}
