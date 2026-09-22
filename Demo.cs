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
        private int age; //data member
        public string Dept {  get; set; }
        protected double Salary;

        public void setSalary(double salary)
        {
            this.Salary= salary;
        }
        public double getSalary(double salary)
        {
            return this.Salary;
        }

        //It does not have any return type explicitly
        //class name same as constuctor name
        //
       
       
        public int Age //property -- is looklike veriable and works like method
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
        public  virtual void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Dept : " + Dept);
            Console.WriteLine("Salary : " + Salary);
        }
        public void check()
        {
            Console.WriteLine("Check method from RegularEmployee ");
        }

    }
    class RegularEmployee : Employee //level 1
    {
        //data members : from this class  : 5
        //data members : from parent class (Employee) : 3

        //Properties : from this class  : 0
        //Properties : from parent class (Employee) : 1

        //Methods : from this class  : 0
        //Methods : from parent class (Employee) : 3

        private double Basic ;
        private double DA;
        private double HRA;
        private double PF;
        private double PT;
     
        public override void Display()
        {
            base.Display();
            //-----------------
            Console.WriteLine("Basic :" + Basic);
            Console.WriteLine("DA :" + DA);
            Console.WriteLine("HRA :" + HRA);
            Console.WriteLine("PF :" + PF);
            Console.WriteLine("PT : " + PT);
        }
        public new void check()
        {
            Console.WriteLine("Check method from RegularEmployee ");
        }
        public void Test()
        {
            Console.WriteLine("Test method from RegularEmployee ");
        }

    }
    
    class Demo
    {
        static void Main(string[] args)
        {
            //object
            //Employee e1 = new Employee();
            //e1.Name = "Mital";
            //e1.Age = 20;
            //e1.Dept = "CSE";
            //e1.setSalary(50000);
            //e1.Display();

            //Employee e2 = new Employee();
            //e2.Name = "Hiral";
            //e2.Age = 20;
            //e2.Dept = "CSE";
            //e2.setSalary(40000);
            //e2.Display();

            Employee e3 =new Employee();
            e3.Display(); //employee
            e3.check(); //employee
            //e3.Test(); //error
            Console.WriteLine("-------------------------------");

            RegularEmployee e4 =new RegularEmployee();
            e4.Display(); //regular employee
            e4.check(); //regular employee
            e4.Test();
            Console.WriteLine("-------------------------------");


            Employee e5 = new RegularEmployee();
            e5.Display(); //regular employee
            e5.check(); //employee
           // e5.Test();//error
            Console.WriteLine("-------------------------------");

            Console.ReadLine();
           
        }
    }
}
