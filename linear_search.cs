using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class linear_search
    {
        static void Main(string[] args)
        {
            int i, n, search;
            bool found= false;

            Console.WriteLine("Enter the size of Array : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter the element of array : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter element that you want to search: ");
            search = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
               if(arr[i] == search)
                {
                    Console.WriteLine("Element found at index : " + i);
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
