using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class loop3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number that you wnat to print : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
