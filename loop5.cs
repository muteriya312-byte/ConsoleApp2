using System;

namespace ConsoleApp2
{
    internal class loop5
    {
        public static void Main()
        {
            int num = 1;
            Console.WriteLine("Enter the number that you wnat to print : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int start = num + i - 1;

                for (int j = start; j >= num; j--)
                {
                    Console.Write(j +" ");
                }

                num += i;
                Console.WriteLine();
            }
        }
    }
}