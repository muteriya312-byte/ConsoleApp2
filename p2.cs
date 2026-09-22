using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class p2
    {
        static void Main()
        {
            Console.WriteLine("Enter the number that you wnat to print : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // Print 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                // Print last odd number
                if (i == 1)
                    Console.Write(1);
                else
                    Console.Write(2 * i - 1);

                Console.WriteLine();
            }
        }
    }
}

