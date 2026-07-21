using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class second_largest
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
           
            int largest = 0;
            int secondlarge = 0;

            for(int i = 0; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            for (int i = 0;i < n; i++)
            {
                if (arr[i]>secondlarge && arr[i] < largest)
                {
                    secondlarge = arr[i];
                }
                    
            }
            Console.WriteLine("Second Largest number is : " + secondlarge);
        }
    }
}
