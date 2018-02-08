using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
          /*  Salesperson fred = new Salesperson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            Console.ReadLine();*/

            Manager chucky = new Manager("Chucky", 50, 92, 10000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();

            OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();

            OuterClass.PublicInnerClass inner2;
            inner2 = new OuterClass.PublicInnerClass();
            Console.ReadLine();
        }
    }
}
