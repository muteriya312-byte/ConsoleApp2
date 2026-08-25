using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class merge_array
    {
        static void Main(string[] args)
        {
            int n, n1, n2;
            Console.WriteLine("Enter size of first array :");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter size of second array :");
            n2 = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n1];
            int[] arr2 = new int[n2];

            Console.WriteLine("Enter element of first array :");
            for (int i=0; i < n1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter element of second array :");
            for (int i = 0; i < n2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = n1 + n2;
            int[] arr = new int[n];
            Console.WriteLine("Merge two array is :");
            for(int i=0; i<n1; i++)
            {
                arr[i] = arr1[i];
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < n2; i++)
            {
                arr[i] = arr2[i];
                Console.WriteLine(arr[i]);

            }
        }
            
    }
}
