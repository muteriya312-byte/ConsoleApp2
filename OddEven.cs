using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            int n , even=0,odd=0;
            Console.WriteLine("Enter size of Array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i < n; i++)
            {
                Console.Write("Enter the element of index " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0; i<n; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
                    
            }
            Console.WriteLine("Even number : " + even);
            Console.WriteLine("Odd number : " + odd);
        }
    }
}
