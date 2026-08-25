using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class copy_array
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter size of an array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter element of an array : ");

            for(int i =0;  i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] copy_arr = new int[n];
            Console.WriteLine("Copy array is :");

            for(int i =0; i<n; i++)
            {
                copy_arr[i] = arr[i];
                Console.WriteLine(copy_arr[i]);
            }
            
        }
    }
}
