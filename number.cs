using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class number
    {
        static void Main(string[] args)
        {
            int n, positive = 0, negative = 0 , zero = 0;
            Console.WriteLine("Enter size of Array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the element of index " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    positive++;
                else if (arr[i] < 0)
                    negative++;
                else
                    zero++;

            }
            Console.WriteLine("Positive number : " + positive);
            Console.WriteLine("Negative number : " + negative);
            Console.WriteLine("Zero number : " + zero);
        }
    }
}
