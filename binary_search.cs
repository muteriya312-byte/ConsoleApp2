using System;

namespace ConsoleApp2
{
    internal class binary_search
    {
        static void Main(string[] args)
        {
            int i, n, search;
            bool found = false;

            Console.Write("Enter the size of Array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter elements in sorted order:");

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            search = Convert.ToInt32(Console.ReadLine());

            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == search)
                {
                    Console.WriteLine("Element found at index: " + mid);
                    found = true;
                    break;
                }
                else if (search < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (!found)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}