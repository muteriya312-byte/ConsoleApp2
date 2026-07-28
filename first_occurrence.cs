using System;

namespace ConsoleApp2
{
    internal class first_occurrence
    {
        static void Main(string[] args)
        {
            int i, n, search;
            bool found = false;

            Console.Write("Enter the size of Array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            search = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine(search +" First occurrence found at index: " + i);
                    found = true;
                    break;   
                }
            }

            if (!found)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
