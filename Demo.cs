using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee  //blue print or template for creating an object
    {
        //data member
        public string Name {  get; set; }
        private int age;
        public string Dept {  get; set; }

        public int Age //property
        {
            get //read
            { 
                return age;
            }
            set //write
            {
                age = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Dept : " + Dept);
        }

    }
    class Demo
    {
        static void Main(string[] args)
        {
            //object
            Employee e1 = new Employee();
            e1.Name = "Mital";
            e1.Age = 20;
            e1.Dept = "CSE";
            e1.Display();

            Employee e2 = new Employee();
            e2.Name = "Hiral";
            e2.Age = 20;
            e2.Dept = "CSE";
            e2.Display();

           
        }
    }
}
