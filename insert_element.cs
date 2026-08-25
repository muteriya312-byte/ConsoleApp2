using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class insert_element
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter size of an array :");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n+1];
            Console.WriteLine("Enter element of an array :");
            for(int i=0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int element, position;
            Console.WriteLine("Enter the element that you want insert in array :");
            element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the position that you want insert an element :");
            position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("New Array is :");
            for(int i = n; i>=position; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[position-1] = element;
            
            
            for (int i=0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
