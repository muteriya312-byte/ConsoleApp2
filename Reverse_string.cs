using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Reverse_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to reverse : ");
            string str= Console.ReadLine();

            string rev = "";
            //str.Length use built in function
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine("Reversed String is :" + rev);

            //without use built in function
            //int length = 0;

            //foreach (char c in str)
            //{
            //    //length++;
            //    rev = c + rev;
            //}
            //Console.WriteLine(rev);


        }
    }
}
