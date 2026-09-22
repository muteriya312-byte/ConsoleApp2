using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class loop2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number that you wnat to print : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
