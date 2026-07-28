using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String  : ");
            string str = Console.ReadLine();

            string rev = "";
            //str.Length use built in function
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            //Console.WriteLine("Reversed String is :" + rev);
            if (rev == str)
            {
                Console.WriteLine(str + " is palindrom ");
            }
            else
            {
                Console.WriteLine(str + " is NOT palindrom");
            }

        }
    }
}