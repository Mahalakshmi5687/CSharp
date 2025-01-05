using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    partial class partialClass
    {
        /* public void FullName()
         {
             Console.WriteLine(_firstName + " " + _lastName);
         }
         public void Display()
         {
             Console.WriteLine("Employee Details:");
             Console.WriteLine("FirstName:{0}", _firstName);
             Console.WriteLine("LastName:{0}", _lastName);
             Console.WriteLine("Salary:{0}", _salary);
         }*/
        partial void show()
        {
            Console.WriteLine("I am From Partial Method");
        }
    }
}
