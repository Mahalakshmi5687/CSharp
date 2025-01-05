using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    partial class partialClass
    {
        /*private string _firstName;
        private string _lastName;
        private double _salary;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public double Salary { get { return _salary; } set { _salary = value; } }*/

        partial void show();
        public void display()
        {
            Console.WriteLine("Partial class one method");
            show();
        }
    }
}
