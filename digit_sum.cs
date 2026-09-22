using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class digit_sum
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int[] number = new int[3];
            Console.WriteLine("Enter the number that you want to sum of that digit : ");
            
            for(int i=0; i<3; i++)
            {
                sum = sum + number[i];
            }
            Console.WriteLine("sum is :" + sum);
        }
    }
}
