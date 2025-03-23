using CSharpPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //System.Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
//Numeric datatypes
/*namespace DataTypes
{
    *//*
       Integral types = byte, sbyte, short, ushort, int, uint, long, ulong
        String type = string, char
        Boolean type =(true, false) bool*//*
        Decimal Type = float, double, decimal
    public class Program
    {
        static void Main(string[] args)
        {
            *//*
            int x = 10;
            int y = 10;
            int z = 10;*//*

            int x = 10, y = 20, z = 30;

            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 9000000004L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -50.55D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = -8.0000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.9999M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
        }
    }
}*/
//Text based data types
/*namespace String_Chars
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "maha";
            char letter = 'A';

            string emptyString = "";
            char emptyletter = '\0';

            Console.WriteLine(emptyletter);
            Console.WriteLine(emptyString);

            Console.Write("My name is ");
            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.ReadLine();

        }
    }
}*/
//Converting string to numbers
/*namespace Convertions
{
    public class Program
    {
        static void Main(string[] args)
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textbigNumber = "-90000000000";
            long bigNumber = Convert.ToInt64(textbigNumber);
            Console.WriteLine(bigNumber);

            string textnegative = "-50.55";
            double negative = Convert.ToDouble(textnegative);
            Console.WriteLine(negative);
            
            string textprecision = "-8.0000001";
            float precision = Convert.ToSingle(textprecision);
            Console.WriteLine(precision);
         
            string textmoney = "14.9999";
            decimal money = Convert.ToDecimal(textmoney);
            Console.WriteLine(money);
         
        }
    }
}*/
//Boolean Data type
/*namespace Booleantype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Gender:");
            string MaleorFemale = Console.ReadLine();
            bool isMale = false;
            if (MaleorFemale == "Male")
            {
                isMale = true;
                Console.WriteLine(isMale);
            }
            else
            {
                Console.WriteLine(isMale);
            }
        }
    }
}*/
//Variables
/*namespace Variables
{
    *//* local variable
    Instance variables or Non-static variables
    static variables or class variables
    constant variables
    readonly variables*//*
    public class program
    {
        int a = 10;
        static int b = 20;
        string name = "maha";
        static void Main(string[] args)
        {
            int num = 100;
            num = 200;
            const int max = 100;
            //max = 12; cannot reinitialize
            Console.WriteLine(max);
            Console.WriteLine(num);
            program p = new program();
            Console.WriteLine(p.a);
            Console.WriteLine(b);
            Console.Read();
        }
    }
}*/
//Strings
/*namespace Strings
{
    //we use String to invoke some inbuilt methods and string for declaring the variables
    //strings are immutable because they are reference types. if we reassign the string it will creates another memory address to store the string
    //if we assign the same existing string value it will checks if that string is present or not if its present it wont create another memory address
    public class program
    {
        static void Main(string[] args) {
            string s = "Welcome to c#";
            Console.WriteLine(s);
            string m = String.Concat("Hi "+s);
            Console.WriteLine(m);
        }
    }
}*/
//Operators
/*namespace Operators
{
    public class program
    {
        *//*ArithmeticException Operators
         Relational Operators
        Logical Operators
        Bitwise Operators
        Assignment Operators
        Misc Operators*//*
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            Console.WriteLine("Addition is: {0}", a + b);
            Console.WriteLine("Substraction is: {0}", a - b);
            Console.WriteLine("Multiplicaiton is: {0}", a * b);
            Console.WriteLine("Div is: {0}", b/a);
            Console.WriteLine("reminder is: {0}", a%b);//if a is smaller than b then ans is a. if a is bigger than b then it will give reminder 
            Console.WriteLine("Increment of a is :{0}", a++);
            Console.WriteLine("Decrement of a is :{0}", a--);
            Console.WriteLine("Increment of a is :{0}", ++a);
            Console.WriteLine("Decrement of a is :{0}", --a);

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

            Console.WriteLine(a > b && a != b);
            Console.WriteLine(a > b || a != b);
            Console.WriteLine(!(a > b && a != b));

            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~(a ^ b));
            Console.WriteLine(~a);
            Console.WriteLine(a<<3);
            Console.WriteLine(b>>2);

            *//**=,+=,-=,/=,%=,<<=,>>=,&=,^=,!=     are Assignment operators its meaning is 
             c*=d(c=c*d)*//*

            *//* sizeof(),typeof(),&,*,?:,is,as
             is- determines whether an object is of a certain type
            if(food is Car)// check if food is an object of the Car class

             as- cast without raising an exception if the cast fails
            Object obj = new StringReader("Helllo");
            StringReader r = obj as StringReader
            the above ones are Miscellaneous Operators*//*

            //revise precedence and associations of operators
        }
    }
}*/
//TypeCasting
/*namespace _TypeCasting
{
    *//*Implicit type casting/Automatic type conversion
     Implicit conversion can be done like we can assign small size datatype to large size datatype
    we cannot assign value of large datatype to smaller datatype*/

/*In Explict Conversion we can covert large size datatype to small size and we can assign to smaller size datatype*//*
class Program
{
static void Main(string[] args)
{
    //implict Conversion
    int a = 10;
    float f = a;
    double d = a;
    Console.WriteLine(a);
    Console.WriteLine(f);
    Console.WriteLine(d);
    //Explicit Conversion
    double a1 = 10000;
    float f1 = (float)a1;
    int d1 = (int)a1;//Convert.ToInt32(a1)
    Console.WriteLine(a1);
    Console.WriteLine(f1);
    Console.WriteLine(d1);
}
}
}*/
//Control Statements
/*If..else
 if..else..if..else
switch
goto*/
/*goto label;
 
 label:
    statement1
    statement2
*/
/*namespace Switchcase
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1: Console.WriteLine("Welcome to C#"); break;
                case 2: Console.WriteLine("Welcome to ASP.NET"); break;
                case 3: Console.WriteLine("Welcome to ASP.NET MVC"); break;
                default: Console.WriteLine("Not Found"); break;
            }
        }
    }
}*/

//Loops
/*Entry controlled Loops:
 while
for, infinite loop will comes when we dont give initialize, condition, increment for(;;)
Exit controlled Loop:
do..while;

 continue - is used in loops to skip some statements
break -  is used in loops to break loop at some conditions*/

//Arrays
/*An array is a group of like-typed variables that are referred to by a common name
 Syntax: <Data Type> [] <Name_Array>
Example:
int[] x - can store int values
string[] s - can store string values
double[] d - can store double values
Student[] stud1 - can store instances of Student class which is custom class*/
/*namespace Arrays
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] a = new int[5] {10, 20, 30, 40, 50 };
            int[] b = {1,2, 3, 4, 5};
            int[] arr;
            arr = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr1 = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            Console.Write(arr[4]);
            for(int i = 0; i < 5; i++)
            {
                Console.Write(a[i]+" ");
            }
            int[,] arr3 = new int[2, 2];
            arr3[0, 0] = 10;
            arr3[0,1] = 20;
            arr3[1,0] = 30;
            arr3[1,1] = 50;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr3[i, j]);
                }
            }
        }
    }
}*/
//Jagged Arrays
/*An array whose elements are arrays is known as Jagged arrays it means "array of arrays."
 The jagged array elements may be of different dimensions and sizes.
*/
/*namespace jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 10, 20, 30, 40, 50 };
            arr[1] = new int[3] { 10, 20, 30, };
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
        }
    }
}*/
//ForEach loop
//we use foreach loop when working with arrays and collections to iterate through the items of arrays/collections.
//here iterable-item can be an array or a class of collections.
/*namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/
//Static Keyword
/*Classes, Variables, Methods, Constructor
 It is also applicable to properties, event, and operators
Static Class:
A static class is declared with the help of static keyword.
A static class can only contain static data members, static methods, and a static constructor.
It is not allowed to create objects of the static class.
Static classes are sealed. means one cannot inherit a static class from another class.*/
/*namespace StaticClasses
{
    static class Demo1
    {
        public static int a = 100;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Demo1.a);
        }
    }
}*/
/*namespace StaticVariables
{
    class Demo1
    {
        public static int a = 100;
        public int b = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo1 d = new Demo1();// we can create object for class here as its not a static class
            d.b = 20;
            Console.WriteLine(Demo1.a);
        }
    }
}*/

/*namespace StaticMethods
{
    class Demo1
    {
        public static int a = 100;
        public string Name = "Mahalakshmi";
        public static void GetData()
        {
            Console.WriteLine(a);
            Demo1 d = new Demo1();
            Console.WriteLine(d.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo1.GetData();            
            Console.WriteLine(Demo1.a);
        }
    }
}*/
/*namespace StaticConstructors
{
    class Demo1
    {
        public static int a = 100;
        //static const
        static Demo1()
        {
            Console.WriteLine("This is Static Constructor");
        }
        //Instance const
        public Demo1()
        {
            Console.WriteLine("This is Instance Constructor");
        }
        //Method
        public void getData()
        {
            Console.WriteLine("Given Static Member Value is:" + a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo1 d1 = new Demo1();
            d1.getData();
            Console.WriteLine("--------------");
            Demo1 d2 = new Demo1();
            d2.getData();

        }
    }
}*/
//Properties
/*In C# by default data members are private.
 to access members in another class we use properties
we use the properties as they are the public data members of a class, but they are actually special methods called accessors.
Accessors:
The accessors are nothing but special methods which are used to set and get the values from the underlying data member. Assessors are of two types such as
set accessor
get accessor*

Different types of properties:
read-only
write-only
read-write
Auto-implemented

Syntax:
{set{DataFieldName = value;}}
{get{return DataFieldName;}}*/
/*namespace Properties
{
    class Emp
    {
        private int _EmpId;
        private string _EmpName;
        //Access_modifiers datatype propertyName {set;get;}
        public int EmpId
        {
            set { _EmpId = value; }
            get { return _EmpId; }
        }
        public string EmpName
        {
            set { _EmpName = value; }
            get { return _EmpName; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.EmpId=1;
            emp.EmpName = "Mahalakshmi";
            Console.WriteLine(emp.EmpName);
            Console.WriteLine(emp.EmpId);
        }
    }
}*/
/*namespace WriteonlyReadonlyProperties
{
    class Emp
    {
        private int Num1, Num2, result;
        public int setNum1
        {
            set { Num1 = value; }
        }
        public int setNum2
        {
            set { Num2 = value; }
        }
        public int getResult
        {
            get { return result; }
        }
        public void add()
        {
            result = Num1 + Num2;
        }
        public void sub()
        {
            result = Num1 - Num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp em = new Emp();
            Console.WriteLine("Enter Values");
            em.setNum1 = int.Parse(Console.ReadLine());
            em.setNum2 = int.Parse(Console.ReadLine());
            em.add();
            Console.WriteLine("Addition is:" + em.getResult);
            em.sub();
            Console.WriteLine("Substraction is:" + em.getResult);
        }
    }
}*/
/*namespace AutoImplementedProperties
{
    class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.EmpId = 2;
            emp.EmpName = "Mahalakshmi";
            Console.WriteLine(emp.EmpId + " " + emp.EmpName);
        }
    }
}*/
/*why do we need properties in real-time appications?
 Declaring the class fields as public and exposing those fields to the outside class is bad as we do not have any control over what gets assigned and returned.
*/
/*namespace propertyDemo
{
    public class Student
    {
        public int ID;
        public string Name;
        public int PassMark;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ID = 100;
            s.Name = null;
            s.PassMark = 0;
            Console.WriteLine("ID = {0} && Name ={1} $$ Passmark = {2}", s.ID,s.Name,s.PassMark);
        }
    }
}*/
/*Problems with properties oe public fields :
 An value should always be a non-negative number.
The name cannot be set to NULL.
If a student name is missing then we should return "No Name.
The PassMark vaue should always be read-only.

Programming languages that do not have properties use getter and setter methods to encapsulate and protect fields."*/

//Tostring()
/*If we want to give ToString directly to object then we have to override ToString() and provide functionality whatever we want in that.*/
/*namespace ToString
{
    class Emp
    {
        public string FName;
        public string LName;
        public override string ToString()
        {
            return FName + " " + LName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.FName = "Mahalakshmi";
            emp.LName = "Musanalli";
            Console.WriteLine(emp.ToString());
        }
    }
}*/
//classes and Objects
/*namespace Example
{
    class Aadhar
    {
        public string AadharNo { get; set; }
        public string Name {  get; set; }
        public string DOB { get; set; }
        public string Address { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aadhar aadhar = new Aadhar();
            aadhar.AadharNo = "12345677";
            aadhar.Name = "name";
            aadhar.DOB = "18-09-2001";
            aadhar.Address= "address";
            Console.WriteLine(aadhar.AadharNo + " " + aadhar.Name + " " + aadhar.DOB + " " + aadhar.Address);
            Aadhar aadhar1 = new Aadhar();
            aadhar1.AadharNo = "098754321";
            aadhar1.Name = "name1";
            aadhar1.DOB = "18-09-2002";
            aadhar1.Address = "address1";
            Console.WriteLine(aadhar1.AadharNo + " " + aadhar1.Name + " " + aadhar1.DOB + " " + aadhar1.Address);
        }
    }
}*/
//Constructors
//System Default constructor
/*namespace DefaultConstructors
{
    class Student
    {
        public int SNo;
    }
    class Program
    {
        static void Main(String[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.SNo);
        }
    }
}*/
//user-defined default constructors
/*namespace DeafultConstructors
{
    class Student
    {
        public int Sno;
        public Student()
        {
            this.Sno = 20;
            Console.WriteLine(this.Sno);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Student student = new Student();
            Student student1 = new Student();
        }
    }
}*/
//parameterized-constructors
/*namespace Parameterizedonstructors
{
    class Student
    {
        public int Sno;
        public Student(int Sno)
        {
            this.Sno = Sno;
            Console.WriteLine(this.Sno);
        }
        public Student(double Sno)
        {
            //this.Sno = Sno;
            Console.WriteLine(Sno);
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Student student = new Student(20);
            Student student1 = new Student(10.10);
        }
    }
}*/
//passing object of one class as parameter to another constructor called Copy Constructor
/*namespace copyConstructor
{
    class Student
    {
        public int Sno;
        public Student()
        {
            Console.WriteLine("Enter Value:");
            this.Sno=int.Parse(Console.ReadLine());
        }

        public Student(Student aa)
        {
            this.Sno=aa.Sno;
        }
        public void Display()
        {
            Console.WriteLine("Value is:" +this.Sno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Display();
            student.Sno = 10;
            Student s = new Student(student);
            student.Display();
            s.Display();
        }
    }
}*/
//static constructor
/*static constructors 
 rules: only one static constructor is allowed
parameters should not be passed
static constructors can access only static members
access modifiers should not be defined.
if we make class as static it will not allow to create object
static constructor will be executed only once even if we create multiple objects*/
/*namespace staticConstructor
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("This is Default Constructors");
        }
        static Student()
        {
            Console.WriteLine("This is Static Constructors");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("--------------------------------------");
            Student student2 = new Student();
            Console.WriteLine("--------------------------------------");
            Student student1 = new Student();
            Console.WriteLine("--------------------------------------");

        }
    }
}*/
//Private COnstructor
/*namespace privateConstructor
{
    class Student
    {
        private Student()
        {
            Console.WriteLine("This is Private Constructor");
        }
        Student s = new Student();//private constructors can be accessed within class
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Student s = new Student(); we can not access private constructor outside the class 
            Console.WriteLine("--------------------");
        }
    }
}*/
//Destructors
/*Destructors in c# are methods inside the class used to destroy instances of that class when they are no longer needed.
 The Destructor is called implicitly by the .NET Framework's Garbage collector and therefore programmer has no control as when to invoke the destructor*/
/*namespace destructor
{
    class Student
    {
        public int sno, age;
        public Student()
        {
            sno = 101;
            age = 25;
        }
        public void Display()
        {
            Console.WriteLine("Sno:"+sno);
            Console.WriteLine("Age:" + age);
        }
        ~Student()
        {
            Console.WriteLine("Destructor is Executed");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Student s=new Student();
            s.Display();
        }
    }
}*/
//Access Specifiers
/*public
 private
protected
internal
protected internal
types are like class, struct, enum, interface, delegate
type members are called variables, properties, constructors, methods
type members cn have 5 types
types can have only 2(internal, public)*/
/*namespace publicprivateaccessSpecifiers
{
    class Customer
    {
        //variable declaration
        private int _ID;
        private int _Age;
        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        public int Age
        {
            set { _Age = value; }
            get { return _Age; }
        }
        public void Display()
        {
            Console.WriteLine("Id is:" + ID);
            Console.WriteLine("Age is:" + Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.ID = 1;
            c.Age = 23;
            
            c.Display();
        }
    }
}*/
/*namespace protectedaccessSpecifiers
{
    class Parent
    {
        protected int ID = 20;
    }
    class child : Parent
    {
        public void Display()
        {
            child c=new child();
            c.ID = 30;
            Console.WriteLine(c.ID);
            Console.WriteLine(this.ID);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.Display();
        }
    }
}*/
//internal access specifier hides its member variables and methods from other classes and objects, that is resides in other namespace.
//In c#, the protected internal modifier is used to specify that access is limited to the current assembly or types derived from the containing class.
//The type or member can be accessed by any code in the same assembly or any derived class in another assembly.

//Encapsulation
/*used to hide data of one class from another class*/
/*namespace encapsulation
{
    class Employee
    {
        private int sno;
        public int StudNo
        {
            get { return sno; }
            set
            {
                if (value > 0) { sno = value; }
                else Console.WriteLine("Only non-negative numbers");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.StudNo = 101;
            Console.WriteLine(e.StudNo);
        }
    }
}*/
//Inheritance
/*Single inheritence
 Multilevel inheritence
Hierarchical inheritence
Hybrid inheritence
Multiple inheritence*/
/*namespace singleInheritence
{
    class Parent
    {
        public void Parent_Display()
        {
            Console.WriteLine("I am from Parent Class");
        }
    }
    class Child:Parent
    { 
        public void Child_Display()
        {
            Console.WriteLine("I am form Child Class");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Parent_Display();
            child.Child_Display();
        }
    }
}*/
/*namespace multilevelInheritence
{
    class GrandParent
    {
        public void GrandParent_Display()
        {
            Console.WriteLine("I am from GrandParent Class");
        }
    }
    class Parent:GrandParent
    {
        public void Parent_Display() 
        {
            Console.WriteLine("I am from Parent Class");
        }
    }
    class Child : Parent
    {
        public void Child_Display()
        {
            Console.WriteLine("I am form Child Class");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("-----------child-----------");
            child.GrandParent_Display();
            child.Parent_Display();
            child.Child_Display();
            Parent parent = new Parent();
            Console.WriteLine("------------Parent-----------");
            parent.GrandParent_Display();
            parent.Parent_Display();
            Console.WriteLine("-----------grandParent-----------");
            GrandParent grandParent = new GrandParent();
            grandParent.GrandParent_Display();
        }
    }
}*/
/*namespace hierarchicalInheritence
{
    class Parent
    {
        public void Parent_Display()
        {
            Console.WriteLine("I am from Parent Class");
        }
    }
    class Child1 : Parent
    {
        public void Child1_Display()
        {
            Console.WriteLine("I am from Child1 Class");
        }
    }
    class Child2 : Parent
    {
        public void Child2_Display()
        {
            Console.WriteLine("I am form Child2 Class");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Child1 child1 = new Child1();
            Console.WriteLine("-----------child1-----------");
            child1.Parent_Display();
            child1.Child1_Display();
            Parent parent = new Parent();
            Console.WriteLine("------------Parent-----------");
            parent.Parent_Display();
            Console.WriteLine("-----------Child2-----------");
            Child2 child2 = new Child2();
            child2.Parent_Display();
            child2.Child2_Display();
        }
    }
}*/
/*Hybrid Inheritance and Multiple inheritence are not supported through class but are supported through interfaces*/
/*namespace hybridInheritence
{
    interface GrandParent
    {
        void Method1();
    }
    interface Parent1:GrandParent
    {
        void Method2();
    }
    interface Parent2:GrandParent
    {
        void Method3();
    }
    class Child : Parent1, Parent2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }
}*/
/*namespace multipleInheritence
{
    interface Parent1
    {
        void Method1();
    }
    interface Parent2
    {
        void Method2();
    }
    class Child : Parent1, Parent2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method1();
            child.Method2();
        }
    }
}*/
//interfaces
/*namespace interfaces
{
    interface Father
    {
        void show();
        void display();
    }
    interface Mother
    {
        void show();
        void display();
    }
    abstract class Child:Father,Mother
    {
        public void show()
        {
            Console.WriteLine("show");
        }
        public abstract void display();
    }
    class GrandSon : Child
    {
        public override void display()
        {
            Console.WriteLine("display");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Father father = new GrandSon();
            father.show();
            father.display();
            Mother mother = new GrandSon();
            mother.show();
            mother.display();
            Child child = new GrandSon();
            child.show();
            child.display();
        }
    }
}*/
//Abstract classes
/*namespace abstractClasses
{
    abstract class AbClass
    {
        public abstract void Calc(double d);
    }
    class Square : AbClass
    {
        public override void Calc(double d)
        {
            Console.WriteLine("Square:{0}", d * d);
        }
    }
    class Cube : AbClass
    {
        public override void Calc(double d)
        {
            Console.WriteLine("Cube:{0}", d*d*d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Calc(100);
            Cube cube = new Cube();
            cube.Calc(100);
        }
    }
}*/
/*namespace AbstractDemo
{
    abstract class Student
    {
        protected int Sno;
        protected string SName;
        public abstract void GetDetails();
        public virtual void display()
        {
            Console.WriteLine("SNO:{0}", this.Sno);
            Console.WriteLine("SName: {0}", this.SName);
        }
        *//* public abstract void display();*//*
    }
    class PStudent : Student
    {
        public string Address;
        public override void GetDetails()
        {
            Console.WriteLine("Enter SNo:");
            Sno=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SName:");
            SName=Console.ReadLine();
            Console.WriteLine("Enter SAddress:");
            Address = Console.ReadLine();
        }
        public override void display()
        {
            Console.WriteLine("SNo:{0}", Sno);
            Console.WriteLine("SName:{0}", SName);
            Console.WriteLine("Address:{0}", Address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PStudent s = new PStudent();
            s.GetDetails();
            s.display();
        }
    }
}*/
//Polymorphism:
/*Types of Polymorphism:
 There are two types of polymorphism in c#
1.Static Polymorphism/compile-time polymorphism/Early binding(Function overloading, Operator Overloading,constructor overloading)
2.Dynamic Polymorphism/Run-time Polymorphism/late Binding(MethodAccessException Overloading)
Polymorphism in c# can be implemented using the following three ways:
1.Function Overloading
2.Function Overriding
3.Function Hiding*/
//Method Overloading
/*namespace methodoverloading
{
    class Example
    {
        public Example()
        {
            Console.WriteLine("I am Constructor");
        }
        public Example(string Name)
        {
            Console.WriteLine(Name);
        }
        public void sum(int a)
        {
            Console.WriteLine(a);
        }
        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void sum(float a)
        {
            Console.WriteLine(a);
        }
    }
    class Example2 : Example
    {
        public void sum(string Fn, string Sn)
        {
            Console.WriteLine(Fn + " " + Sn);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Example exampke = new Example("Maha");
            Example2 example2 = new Example2();
            example2.sum(10);
            example2.sum(10.5f);
            example2.sum(10, 4);
            example2.sum(6, 4, 9);
            example2.sum("Maha", "lakshmi");

        }
    }
}
*/
//methodOverriding
/*namespace methodOverriding
{
    class Parent
    {
        //implement
        //giving permission to reimplement or replacement
        public virtual void display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Child : Parent
    {
        //reimplement
        //override method
        public override void display()
        {
            //base.display();
            Console.WriteLine("Child Class");
            base.display();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.display();

            Parent parent = new Parent();
            parent.display();

            Parent child1 = new Child();
            child1.display();
        }
    }
}*/
//method hiding
/*namespace methodHiding
{
    class Parent
    {
        public void display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Child : Parent
    {
        public new void display()// here new keyword hides the data from Parent class
        {
            //base.display();
            Console.WriteLine("Child Class");
           // base.display();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           *//* Child child = new Child();
            child.display();

            Parent parent = new Parent();
            parent.display();
*//*          
           //creating child object using parent reference
            Parent child1 = new Child();//even we are creating object for child beacuse of new keyword it hides the parent class display method
            child1.display();
        }
    }
}
*/
//Partial Classes and Partial Methods

/*Partial Classes: main things are when working on large projects, splitting a class over separate files allowa multiple programers to work on it simultaneously.
 When working with automatically generated source code, the code can be added to the class without having to recreate
the source file. Visual studio uses this approach when creating windows form, web service wrapper code
Rules: for classes which are partial must contain partial keyword for all class with same class name.
for classes which are partial must have same access modifier*/

/*Partial Methods: partialMethod() has partial keyword 
 declaration consists of two parts in c#:
1. The definition (only the method signature ending with a semi-colon, without mehtod body)
2. The implementation.
Partial methods in c# are private by default and it is a compile time error to include any access modifiers,
including private.
partial methods must implement only onces
partial methods can be methods without definition(implementation)
partial methods return type should be only void other than void may raise compile time error
partial methods must be declared within a partial class or partial struct.
signature of the partial methods declaration must match with the signation of the implementation*/
/*namespace partialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            partialClass employee = new partialClass();
            *//* employee.FirstName = "Maha";
             employee.LastName = "Lakshmi";
             employee.Salary = 10000;
             employee.FullName();
             employee.Display();*//*
            employee.display();
        }
    }
}*/

//Sealed Classes:
/*A class from which it is not possible to create/derive a new class is known as a sealed class.
 In simple words, we can also define the class that is declared using the sealed modifier is known as the sealed class and a 
sealed class cannot be inherited by any other class.
To make any class a sealed class we need to use the keyword sealed
Points to Remember while working with sealed class:
1. A sealed class is completely opposite to an abstract class.
2. This sealed class cannot contain abstract methods.
3. It should be the bottom-most class with the inheritence hierachy.
4. A sealed class can never be used as a base class.
5. The sealed class it specially used to avoid further inheritance.
6. The keyword sealed can be used with classes, instance methods, and properties.
Note: Even if a sealed class cannot be inherited we can still consume the class members from any other class by creating the
object of the class.
Sealed Methods:
The method that is defined in a parent class, if that method cannot be overriden under
a child class, we call it a sealed method.
By default, every method is a sealed method because overriding is not possible unless the method is not declared
as virtual in the parent class. If a method is declared as virtual in a class, any child class of it
can have the right to override that method.*/
/*namespace sealedClasses
{
    class Employee
    {
        public int Eid;
        public string EName;
        public string EAddress;
        public virtual void GetDetails()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.WriteLine("Enter Eid:");
            Eid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EName:");
            EName =Console.ReadLine();
            Console.WriteLine("Enter EAddress:");
            EAddress = Console.ReadLine();

        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Eid:{0}", Eid);
            Console.WriteLine("EName:{0}", EName);
            Console.WriteLine("EAddress:{0}", EAddress);
        }
    }
    sealed class Manager : Employee
    {
        public double ESalary;
        public override void GetDetails()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.WriteLine("Enter Eid:");
            Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EName:");
            EName = Console.ReadLine();
            Console.WriteLine("Enter EAddress:");
            EAddress = Console.ReadLine();
            Console.WriteLine("Enter ESalary:");
            ESalary = double.Parse(Console.ReadLine());
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Eid:{0}", Eid);
            Console.WriteLine("EName:{0}", EName);
            Console.WriteLine("EAddress:{0}", EAddress);
        }
    }
   *//* class Director: Manager
    {
   Cannot derived from sealed classes
    }*//*
    class Program
    {
        static void Main(string[] args)
        {
            Manager m= new Manager();
            m.GetDetails();
            m.DisplayDetails();
        }
    }
}*/
/*Sealed Classes are used when we dont want to allow subclasses to override the superclass method
 and to ensure that all sub-classes use the same superclass method logic then that method should be declared as sealed.

 Sealed method cannot be overriden in sub-classes violation lead to a compile-time error

 The private method is not inherited whereas the sealed method is inherited but cannot be overriden in C#.
So, a private method cannot be called from sub-classes whereas a sealed method can be called from sub-classes

 we declared classes as sealed when
if we dont want to override all the methods of our class in sub-classes
And if we dont want to extend our class functionality*/

//Exception Handling
/*There are two types of errors:
Compilation errors
Runtime errors
Exception:
A runtime error is known as an exception in C#.
The exception will cause the abnormal termination of the program execution.
So these errors (exceptions) are very dangerous because whenever the exception occurs in the programs,
the program gets terminated abnormaly on the same line where the error gets occurred without executing
the next line of code.

Objects of exception classes are responsible for abnormal termination of the program whenever runtime errors (exceptions) occur.
These exception classes are predefined under BCL(Base Class Libraries) where a separate class is provided for each and every different
type of exception like
1.IndexOutOfRangeException
2.FormatException
3.NullReferenceException
4.DivideByZeroException
5.FileNotFoundException
6.SQLException
7.OverFlowException, etc*/
/*namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a value:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Div is {0}", a / b);

        }
    }
}*/
/*Exception Handling:
 The process of catching the exception for converting the CLR given exception message to an 
end-user understandable message and for stopping the abnormal termination of the program whenever runtime errors
are occurring is called Exception Handling in c#
uses:
To stop the abnormal termination of the program
to provide users understandable messages when an exception is raised. So that users can make a decision without the 
developers help

 Basically by implementing Exception handling we are providing life to a program to talk to the user on 
behalf of a developer.
*/
/*try-catch-finally
 try-catch
try-finally*/
/*namespace ExceptionHnadling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //con.open();
                int a, b;
                Console.WriteLine("Enter a value:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Div is {0}", a / b);
                //con.close();
            } 
            catch(DivideByZeroException) 
            {
                Console.WriteLine("b must be non zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("must be integers");
            }
            finally
            {
                Console.WriteLine("This is final block");
                //con.close();
            }
        }
    }
}*/
//Custom Exception:
/*In C#, the exceptions are divided into two types such as 
 1.System exception:
AN exception that is raised implicitly under a program by the exception manager because of some logical mistakes
(some predefined conditions) is known as a system exception. For example:
DividedByZeroException
IndexOutOfRangeException
FormatException
2.Application exception:
AN exception that is raised explicitly under a program based on our own condition(i.e. user-defined condition)
is known as an application exception. As a programmer, we can raise application exception
at any given point of time.
*/
/*namespace applicationException
{
    public class MYException : Exception
    {
        public override string Message
        {
            get
            {
                return "I am from myException class";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter a,b values");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new MYException();
                }
                Console.WriteLine(a / b);
            }
            catch (MYException e)
            {
                Console.WriteLine (e.Message);
            }
        }
    }
}*/
//Delegates and Events
/*namespace Delegate
{
    public delegate void AddDelegate(int a, int b);//declare
    class Program
    {
        //Delegate -> type safe function pointer
        public void add(int a, int b)
        {
            Console.WriteLine(a + ", " + b);
        }
        static void Main(string[] args) 
        {
            Program p= new Program();
            AddDelegate AD=new AddDelegate(p.add);//instance
            AD(10, 20);//invoke
        }
    }
}*/
//MultiCast Delegate
/*namespace Delegates
{
    public delegate void AddDelegate();//declare
    class Program
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }
        public void Show2()
        {
            Console.WriteLine("Show2");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate AD1 = new AddDelegate(p.Display);
            AddDelegate AD2 = new AddDelegate(p.Show);
            AddDelegate AD3 = new AddDelegate(p.Show2);

            AddDelegate AD4=AD1+AD2+AD3;
            //AD4 -= AD3;
            AD4();
        }
    }
}
*/
//Generic Delegates
/*namespace genericDelegates
{
    //Generic Delegates
    //func=> return =True
            //i/p param=>accept => 16 parameters   diff/same
            //last param=> return type

    //Action=> return =False
            //i/p param=>accept => 16 parameters   diff/same
            //last param=> return type

    //Predicate return =>bool
                //single
            
    //public delegate void SumDelegate(int m, int n);
    class Program
    {
        public double Sum(int a, double b)
        {
            return a + b;
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Sub:{0}", a + b);
        }
        public bool checkLength(string Name)
        {
            if (Name.Length > 5)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Func<int, double, double> obj1 = new Func<int, double, double>(p.Sum);
            double res1= obj1.Invoke(100, 145.54);
            Console.WriteLine(res1);

            Action<int, int> obj2 = new Action<int, int>(p.Sub);
            obj2.Invoke(100, 50);

            Predicate<string> obj3= new Predicate<string>(p.checkLength);
            bool res2 = obj3.Invoke("Hello");
            Console.WriteLine(res2);
        }
    }
}*/
//Anonymous Method
/*namespace anonymousMethod
{
    public delegate void TestDelegate(string Name);
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            TestDelegate td = delegate (string Name) //no metion of return type|access modifier// we cannot use ref,out keywords
            {
                //we cant use goto, break and continue statements
                Console.WriteLine("Name is:" , Name,age);// we can access variable which are declared outside of anonymous method but cannot be ref or out
            };
            td.Invoke("Hello");
        }
    }
}*/
//lambda expressions
/*are used to shorten the Anonymous method*/
/*namespace anonymousMethod
{
    public delegate void TestDelegate(string Name);
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 20;
            TestDelegate td = (Name) =>
            {
                Console.WriteLine("Name is:" + Name);
            };
            td("Hello");
            td.Invoke("Hello");
        }
    }
}*/
//collections
/*limitations of arrays:
 size is fixed
cant insert in middle of an array
can delete from middle of an array*/
/*collections in c# are a set of predefined classes that are present in the System.Collections namespace.
we can say a Collection in C# is a dynamic array
size can be increased dynamically
we can insert an element into the middle of a collection
It also provides the facility to remove or delete elements from the middle of a collection

 The collections in c# are classes that represent a group of objects. With the help of c# collections. we can perform 
different types of operations on objects such as Store, Update, Delete, Retrieve, Search, and Sort objects. etc*/

/*Collections:
Index- Arrays, List
Key Value Pair- Hash Table, Sorted List
Prioritized- Stack, Queue
Specialized- String, Hybrid Dictionaries*/

/*Collection:
 Collections are of three types:
**Non-Generic:(System.Collections)
Array List
Hash Table
Stack
Queue
Sorted List

**Generic:(System.Collections.Generics)
List<T>
Stack<T>
Queue<T>
Hashset<T>
Dictionary<TKey, TValue>
SortedList<TKey, TValue>
SortedSet<T>
Sorted Dictionary<TKey, TValue>
LinkedList<T>

**Concurrent:(System.Generics.Concurrent)
BlockCollection<T>
ConcurrentBag<T>
ConcurrentStack<T>
ConcurrentQueue<T>
ConcurrentDictionary<TKey, TValue*/
/*using System.Collections;
namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Arr1 = new ArrayList();
            Arr1.Add("Maths");
            Arr1.Add("Science");
            Arr1.Add("English");
            Arr1.Add("Telugu");
            Arr1.Add("Hindi");
            Arr1.Add("Social");
            Arr1.Add(100);
            Console.WriteLine(Arr1[0]);
            Arr1[0] = 10;
            Arr1.Insert(3, 200);
            ArrayList Arr2 = new ArrayList();
            Arr1.InsertRange(3, Arr2);
            Arr1.Remove("Hindi");
            Arr1.RemoveRange(0, 2);
            bool result = Arr1.Contains("Telugu");
            Console.WriteLine(result);
            //Arr1.Clear();
            ArrayList Arr3= new ArrayList();
            Arr3.Add(900);
            Arr1 = (ArrayList) Arr3.Clone();
            Arr1.Sort();
            Console.WriteLine(Arr1.Capacity);//<8=8,<4=4 
            foreach(var a in Arr1)//foreach is used when lenght of array not known, for is used when leanght is known
            {
                Console.WriteLine(a);
            }
        }
    }
}*/
//Hashtable:
/*The Hashtable Collection Class in c# stores the elements in the form of key-value pairs.
 Hashtable Class belongs to System.Collection namespace i.e. it is a Non-Generic Collection class.
It implements the IDictionary interface.
ArrayList is faster than Hashtable because extra work is performed in Hashtables*/
/*using System.Collections;
namespace hashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1= new Hashtable();
            h1.Add("EID", 100);
            h1.Add("EName", "Narendra");
            h1.Add("Salary", 10000);
            h1.Add("Address", "Hyd");
            h1.Add(1, 100);

            var result = h1.ContainsValue("Narendra");
            Console.WriteLine(result);

            var result3 = h1.Contains("Hyd");
            Console.WriteLine(result3);


            var result4 = h1.Contains("EID");
            Console.WriteLine(result4);

            var result1 = h1.ContainsKey("EID");
            Console.WriteLine(result1);

            h1.Remove("EID");
            Hashtable h2=(Hashtable)h1.Clone();

            foreach (var a in h2.Keys) 
            {
                Console.WriteLine("Key:{0},Value:{1}", a, h1[a]);
            }
        }
    }
}*/
//stack:
/*The Stack in c# is a non-generic collection class that works in the 
 LIFO(last in first out) principle. so, we need to use the stack collection class in c#.
when we want lifo access to the items of a collection.
That means the item which is added last to the collection will be the first 
item to be removed from the collection.*/
/*using System.Collections;
namespace stack
{
    class Program
    {
        static void Main(string[] args) 
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push("Narendra");
            s1.Push(120000);
            s1.Push("Hyd");
            s1.Pop();
            bool result = s1.Contains("Narendra");
            Console.WriteLine("Top item:{0}:",s1.Peek());
            Stack s2 = (Stack) s1.Clone();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/
//Queue:
/*The non-generic queue collection class in c# works in the FIFO principle. so, we need to use the 
 * non-generic queue collection class in c#, when we need fifo access to the items of a collection. That means the 
 item which is added first will be removed first from the collection. When we add an item to the queue, then it is called enqueuing an item. Similarly, when
we remove an item from the queue then it is called dequeuing an item.*/
/*using System.Collections;
namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue("Hello");
            q1.Enqueue("Hi");
            q1.Enqueue(100);
            q1.Enqueue(100.35);
            q1.Dequeue();
            bool result = q1.Contains("Hi");
            Console.WriteLine(result);
            Console.WriteLine("First element:{0}",q1.Peek());
            Queue q2 = (Queue)q1.Clone();
            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/
//SortedList:
/*non-generic sortedlist collection class in c# represents a collection of key/value pairs that aew sorted by 
 the keys and are accessible by key and by index. By default, it sorts the key/value pairs in ascending order.

 properties:
implements the IEnumerable, ICollection, IDictionary, and ICloneable interfaces.
we can access the element by its key or by its index in sortedlist
internally maintains two arrays to store the elements of the list. i.e, one array for the keys and 
another array for the associated values. Here, the key cannot be null, but the values can be null. And one more, it does not allow duplicate keys*/

/*using System.Collections;
namespace sortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList ss=new SortedList();
            ss.Add(1, "Hello");
            ss.Add(2, "Hi");
            ss.Add(3, 100);
            ss.Add(4, 100.45);
           // ss.Add("EID", 100);//key cant be string
            ss.Remove(1);
            ss.RemoveAt(0);
            bool result = ss.Contains(1);
            Console.WriteLine(result);
            SortedList ss2=(SortedList)ss.Clone();
            foreach (var item in ss.Keys)
            {
                Console.WriteLine("Key:{0}, values:{1}", item, ss[item]);
            }
        }
    }
}*/
//Why need of Constructors & order of Execution:
/*namespace orderOfExecution
{
    class Student
    {
        public string Name
        {
            get; set;
        }
        public int ID { get; set; }
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }
        static Student()//static constructors must not contain parameters, used for initializing static members
        {
            Console.WriteLine("Static Constructor");
        }
        public Student(Student std)
        {
            Console.WriteLine("Copy COnstructor");
        }
        public Student(int i)
        {
            Console.WriteLine("Param Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(10);
            Student s3 = new Student(s2);
        }
    }
}*/

/*Output:
Static Constructor
Default Constructor
Param Constructor
Copy COnstructor*/
//Call by value and Call by reference
/*call by value with value type
 call by value with reference type
call by reference with value type
call by reference with reference type*/
/*OriginalValue -> modified?Call by reference:callByReferenceWithReference by value*/
/*namespace callByValueWithValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a+"\t"+  b);
        }
    }
}*/
/*namespace callByValueWithReference
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ID = 101;
            emp1.Name = "Test";
            Employee emp2 = emp1;
            emp1.Name = "Maha";
        }
    }
}*/
/*namespace callByReferenceWithValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Display(ref a);
        }
        public static void Display(ref int b)
        {
            b = 30;
        }
    }
}*/
/*namespace callByReferenceWithReference
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ID = 101;
            emp1.Name = "Test";
            Display(ref emp1);
        }
        public static void Display(ref  Employee emp2)
        {
            emp2 = null;
        }
    }
}*/
/*Readyonly can be initialize in constructor only and can be initialized multiple time for each object creation in constructor only*/
/*namespace ConstAndReadOnly
{
    class Employee
    {
        public const string name = "Maha";
        public readonly int id;
        public static int fee;
        public Employee()
        {
            id = 2012;
        }
        public Employee(int a)
        {
            id = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee.fee = 3000;
            Employee emp= new Employee(300);
            Employee emp2 = new Employee(400);
            Employee emp3 = new Employee();
        }
    }
}*/
//Convert.Tostring() vs Tostring()
/*namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = null;
            Console.WriteLine("hi"+Convert.ToString(Name));//Convert.Tostring can handles null values

            Console.WriteLine(Name.ToString());//ToString cannot handle null values
        }
    }
}*/
/*Advantages and disadvantages of non-generic collections:
 Array: Type-safe but have fixed Lenght
Collection: Auto resizing but not type-safe
Generic Collection: Type-safe and Auto-Resizing but not Thread safety*/

//Generics:
/*Are not specific to particular data type. And that particular data type will be decided by compiler at compilation time. */
/*namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEqual = Calc.AreEqual(10.2, 20.9);

        }
    }
    public class Calc
    {
        public static bool AreEqual(int a, int b)
        {
            return a == b;
        }
        public static bool AreEqual(double a, double b)
        {
            return a == b;
        }
        public static bool AreEqual(object a, object b)
        {
            return a == b;
        }
    }
}*/
/*namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEqual = Calc.AreEqual<double>(10.2, 20.9);
            bool isEqual1 = Calc.AreEqual<string>("Hi", "Hello");
        }
    }
    public class Calc
    {
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}*/
//Generic Constraints
/*where T: struct: The type argument must be non-nullable value type such as primitive data types 
 int, double, char, bool, float, etc. The struct constraints can't be combined with the unmanaged constraints.

 where T: class: The type argument must be a reference type. This constraints can be applied to any class
(non-nullable), interface, delegates, or array type in c#

 where T: new() => The type argument must be a reference type that has a public parameterless (default) constructor.

 where T: <base class name> => The type of argument must be or derive from the specified base class.

 where T: <interface name> => The type argument must be or implement the specified interface. Also, multiple interface
constraints can be specified.

 where T: U => The type argument supplied for must be or derive from the argument supplied for U.
In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type. If U is a 
nullable reference type, T may be either nullable or non-nullable.*/
/*namespace genericConstraintsFORclass { 
    public class ConstraintsClass<T> where T : class
    {
        public T value { get; set; }
        public void Method(T a, T b)
        {
            Console.WriteLine("Value "+value);
            Console.WriteLine("a "+a);
            Console.WriteLine("b "+b);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstraintsClass<Employee> emp = new ConstraintsClass<Employee>();
            Employee emp1 = new Employee() { Name = "Maha", Gender = "Female" };
            Employee emp2 = new Employee() { Name = "Swathi", Gender = "Female" };
            Employee emp3 = new Employee() { Name = "Nitesh", Gender = "Male" };
            emp.value = emp1;
            emp.Method(emp2, emp3);
            ConstraintsClass<string> constraintsClass = new ConstraintsClass<string>();
            constraintsClass.value = "Hello";
            constraintsClass.Method("Hi", "Hello");
        }
    }
}*/
/*namespace genericConstraintsFORstruct
{
    public class ConstraintsClass<T> where T : struct
    {
        public T value { get; set; }
        public void Method(T a, T b)
        {
            Console.WriteLine("Value " + value);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*ConstraintsClass<Employee> emp = new ConstraintsClass<Employee>();
            Employee emp1 = new Employee() { Name = "Maha", Gender = "Female" };
            Employee emp2 = new Employee() { Name = "Swathi", Gender = "Female" };
            Employee emp3 = new Employee() { Name = "Nitesh", Gender = "Male" };
            emp.value = emp1;
            emp.Method(emp2, emp3);
            ConstraintsClass<string> constraintsClass = new ConstraintsClass<string>();
            constraintsClass.value = "Hello";
            constraintsClass.Method("Hi", "Hello");*//*
            ConstraintsClass<int> constraintsClass = new ConstraintsClass<int>();
            constraintsClass.value = 10;
            constraintsClass.Method(20, 30);
        }
    }
}*/
/*namespace genericConstraintsFORNew
{
    public class ConstraintsClass<T> where T : new()
    {
        public T value { get; set; }
        public void Method(T a, T b)
        {
            Console.WriteLine("Value " + value);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public Customer(string CustName, string CustGender)
        {
            Name = CustName;
            Gender = CustGender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*ConstraintsClass<Employee> emp = new ConstraintsClass<Employee>();
            Employee emp1 = new Employee() { Name = "Maha", Gender = "Female" };
            Employee emp2 = new Employee() { Name = "Swathi", Gender = "Female" };
            Employee emp3 = new Employee() { Name = "Nitesh", Gender = "Male" };
            emp.value = emp1;
            emp.Method(emp2, emp3);
            ConstraintsClass<string> constraintsClass = new ConstraintsClass<string>();
            constraintsClass.value = "Hello";
            constraintsClass.Method("Hi", "Hello");*//*
            ConstraintsClass<int> constraintsClass = new ConstraintsClass<int>();
            constraintsClass.value = 10;
            constraintsClass.Method(20, 30);
            //ConstraintsClass<Customer> constraintsClass1 = new ConstraintsClass<Customer>();//cannot create object for Customer class because it has parameterized constructor
        }
    }
}*/
/*namespace genericConstraintsFORbaseClass
{
    public class ConstraintsClass<T> where T : Parent
    {
        public T value { get; set; }
        public void Method(T a, T b)
        {
            Console.WriteLine("Value " + value);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
        }
    }
    public class Parent
    {
        public string Name1 { get; set; }
    }
    public class Employee:Parent
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           ConstraintsClass<Employee> emp = new ConstraintsClass<Employee>();
            Employee emp1 = new Employee() { Name ="Maha", Gender = "Female" , Name1 = "Lakshmi"};
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Name1);
            Console.WriteLine(emp1.Gender);
            emp.value = emp1;
            emp.Method(emp1, emp1);
            //ConstraintsClass<Customer> constraintsClass = new ConstraintsClass<Customer>();//cannot create object for Customer class because t has not inherited from Parent class
        }
    }
}*/
/*namespace genericConstraintsFORinterface
{
    public class ConstraintsClass<T> where T : IParent
    {
        public T value { get; set; }
        public void Method(T a, T b)
        {
            Console.WriteLine("Value " + value);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
        }
    }
    public class IParent
    {
        public string Name1 { get; set; }
    }
    public class Employee : IParent
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstraintsClass<Employee> emp = new ConstraintsClass<Employee>();
            Employee emp1 = new Employee() { Name = "Maha", Gender = "Female", Name1 = "Lakshmi" };
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Name1);
            Console.WriteLine(emp1.Gender);
            emp.value = emp1;
            emp.Method(emp1, emp1);
            //ConstraintsClass<Customer> constraintsClass = new ConstraintsClass<Customer>();//cannot create object for Customer class because t has not inherited from Parent class
        }
    }
}*/
/*namespace genericConstraintsFORU
{
    public class ConstraintsClass<T,U> where T : U
    {
        public T value { get; set; }
        public void Method(T a, T b)
        {
            Console.WriteLine("Value " + value);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
        }
    }
    public class IParent
    {
        public string Name1 { get; set; }
    }
    public class Employee : IParent
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Customer:IParent
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstraintsClass<Employee,IParent> emp = new ConstraintsClass<Employee, IParent>();
            ConstraintsClass<Customer, IParent> emp2 = new ConstraintsClass<Customer, IParent>();
            Employee emp1 = new Employee() { Name = "Maha", Gender = "Female", Name1 = "Lakshmi" };
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Name1);
            Console.WriteLine(emp1.Gender);
            emp.value = emp1;
            emp.Method(emp1, emp1);
            //ConstraintsClass<Customer> constraintsClass = new ConstraintsClass<Customer>();//cannot create object for Customer class because t has not inherited from Parent class
        }
    }
}*/
/*namespace genericConstraintsFORU
{
    public class ConstraintsClass<T, X> where T : class where X:struct
    {
        public T value { get; set; }
        public void Method(X a, T b)
        {
            Console.WriteLine("Value " + value);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
        }
    }
    public class IParent
    {
        public string Name1 { get; set; }
    }
    public class Employee : IParent
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Customer : IParent
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstraintsClass<string, int> emp = new ConstraintsClass<string, int>();
            ConstraintsClass<Employee, int> emp2 = new ConstraintsClass<Employee, int>();
            Employee emp1 = new Employee() { Name = "Maha", Gender = "Female", Name1 = "Lakshmi" };
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Name1);
            Console.WriteLine(emp1.Gender);
            emp.value = "Hi";
            emp.Method(100, "Hello");
        }
    }
}*/
//Generic Lists
/*namespace genericLists
{
    public class Student
    {
        public string Name { get; set; }    
        public int ID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            List<int> list2 = new List<int>() { 60, 70, 80, 90, 100 };
            List<int> list3 = new List<int>() { 300, 400 };
            int[] arry = new int[] { 500, 290, 900, 800 };
            List<int> list4 = new List<int>(arry);
            list.AddRange(list2);
            list.Insert(1, 200);
            list.InsertRange(2, list3);
            Console.WriteLine(list.Contains(60));
            Console.WriteLine("find:"+list.Find(x => x % 2 == 0));//returns first element which satisfies the condition
            Console.WriteLine("findAll:"+list.Find(x => x % 2 == 0));
            IEnumerable<int> result = list.FindAll(x => x % 2 == 0);
            Console.WriteLine(list.FindIndex(x=>x%2==0));
            list.Sort();
            list.Reverse();
            list.Remove(60);
            list.RemoveRange(1, 3);
            list.RemoveAt(2);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.RemoveAll(x => x % 2 == 0);
            list.Exists(x => x % 2 == 0);
            list.Clear();
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }  
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 101, Name = "Maha" });
            students.Add(new Student() { ID = 102, Name = "Swathi" });
            List<Student> students2 = new List<Student>() { new Student() { ID = 103, Name = "Nitesh" } };
            students.AddRange(students2);
            foreach (Student student in students)
            {
                Console.WriteLine(student.ID + ":" + student.Name);
            }
            Console.WriteLine(students[0].ID);
        }
    }
}*/
//Generic Dictionary
/*namespace genericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Maha");
            dict.Add(2, "Swathi");
            dict.Add(3, "Nitesh");
            dict.Add(4, "Lakshmi");
            dict.Add(5, "Karthik");
            dict.Add(6, "Sai");
            bool result = dict.ContainsKey(4);
            bool result1 = dict.ContainsValue("Nitesh");
            dict.Remove(5);
            //dict.Clear();
            dict.AsParallel().ForAll(x => Console.WriteLine(x.Key+"\t"+x.Value));
            Console.WriteLine(result);
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
    }
}*/
//Generic Stack
/*namespace genericstack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);
            stk.Push(50);
            stk.Pop();
            Console.WriteLine(stk.Peek());
            Console.WriteLine(stk.Contains(40));
            //stk.Clear();
            int[] s = new int[5] { 60, 70, 80, 90, 100 };
            stk.CopyTo(s, 0);
            foreach (int i in stk)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/
//Generic Queue
/*namespace genericqueue
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Student> students = new Queue<Student>();
            Student s1 = new Student() { ID = 101, Name = "Maha" };
            Student s2 = new Student() { ID = 102, Name = "Swathi" };
            Student s3 = new Student() { ID = 103, Name = "Nitesh" };
            students.Enqueue(s1);
            students.Enqueue(s2);
            students.Enqueue(s3);
            foreach (Student student in students)
            {
                Console.WriteLine(student.ID + ":" + student.Name);
            }
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(10);
            ints.Enqueue(20);
            ints.Enqueue(30);
            ints.Enqueue(40);
            ints.Enqueue(50);
            ints.Dequeue();
            //ints.Clear();
            ints.Peek();
            Console.WriteLine(ints.Contains(40));
            int[] s = new int[5] { 60, 70, 80, 90, 100 };
            ints.CopyTo(s, 0);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/
//Generic hashset
/*namespace generichashset
{
    class Program
    {
        //unionwith
        //Interset
        //Exceptwith
        //SymmetricExceptWith
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Maha");
            hs.Add("Swathi");
            hs.Add("Nitesh");
            hs.Add("Lakshmi");
            hs.Add("Karthik");
            hs.Add("Sai");
            HashSet<string> hs1 = new HashSet<string>();
            hs1.Add("Hi");
            hs1.Add("Hello");

            *//*hs.Remove("Sai");
            hs.RemoveWhere(x => x.Length >5); 
            Console.WriteLine(hs.Contains("Maha"));*//*
            hs1.Intersect(hs);
            hs1.UnionWith(hs);
            hs1.ExceptWith(hs);
            hs1.SymmetricExceptWith(hs);
        }
    }
    
}*/
//Generic SortedList
/*namespace genericsortedList
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,Student> keyValuePairs = new SortedList<int, Student>();
            Student s1 = new Student() { ID = 101, Name = "AAA" };
            Student s2 = new Student() { ID = 102, Name = "BBB" };
            Student s3 = new Student() { ID = 103, Name = "CCC" };
            keyValuePairs.Add(1, s1);
            keyValuePairs.Add(2, s2);
            keyValuePairs.Add(3, s3);
            foreach (KeyValuePair<int, Student> kvp in keyValuePairs)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value.ID + ":" + kvp.Value.Name);
            }
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Maha");
            sl.Add(2, "Swathi");
            sl.Add(3, "Nitesh");
            sl.Add(1, "Maha");
            sl.Add(4, "Lakshmi");
            sl.Add(5, "Karthik");
            sl.RemoveAt(2);
            //sl.Clear();
            Console.WriteLine(sl.ContainsKey(4));
            Console.WriteLine(sl.ContainsValue("Nitesh"));
            foreach (KeyValuePair<int, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

        }
    }
}*/ 
//Generic sortedset
/*namespace genericsortedlist
{
    class program
    {
        static void Main(string[] args)
        {
            SortedSet<int> ss = new SortedSet<int>();
            ss.Add(10);
            ss.Add(20);
            ss.Add(30);
            ss.Add(40);
            ss.Add(50);
            SortedSet<int> ss1 = new SortedSet<int>() { 60, 70, 80, 90, 100 };
            int[] list = new int[] { 200, 300, 400, 500 };
            SortedSet<int> ss2 = new SortedSet<int>(list);
            ss.CopyTo(list, 0);
            ss.UnionWith(ss1);
            ss.IntersectWith(ss1);
            ss.ExceptWith(ss1);
            ss.SymmetricExceptWith(ss1);
            ss.Remove(40);
            ss.RemoveWhere(x => x%2 == 0);
            //ss.clear();
            Console.WriteLine(ss.Contains(30));
            foreach (int i in ss)
            {
                Console.WriteLine(i);
            }
            SortedSet<int>.Enumerator en = ss.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
        }
    }
}*/
//Generic SortedDictionary
/*namespace genericsorteddictionary
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, Student> keyValuePairs = new SortedDictionary<int, Student>();
            Student s1 = new Student() { ID = 101, Name = "AAA" };
            Student s2 = new Student() { ID = 102, Name = "BBB" };
            Student s3 = new Student() { ID = 103, Name = "CCC" };
            keyValuePairs.Add(1, s1);
            keyValuePairs.Add(2, s2);
            keyValuePairs.Add(3, s3);
            foreach (KeyValuePair<int, Student> kvp in keyValuePairs)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value.ID + ":" + kvp.Value.Name);
            }
            SortedDictionary<int, string> sl = new SortedDictionary<int, string>();
            sl.Add(1, "Maha");
            sl.Add(2, "Swathi");
            sl.Add(3, "Nitesh");
            sl.Add(6, "Maha");
            sl.Add(4, "Lakshmi");
            sl.Add(5, "Karthik");
            //sl.Clear();
            Console.WriteLine(sl.ContainsKey(4));
            Console.WriteLine(sl.ContainsValue("Nitesh"));
            foreach (KeyValuePair<int, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

        }
    }
} */
//Concurrency Collection
/*namespace concurrencycollection
{
    class  Program
    {
        static ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Add1);
            Thread t2 = new Thread(Add2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

        }
        public static void Add1()
        {
            for(int i=0;i<10;i++)
            {
                dict.TryAdd(i, "Maha"+i);
                Thread.Sleep(100);
            }
        }
        public static void Add2()
        {
            for (int i = 10; i < 20; i++)
            {
                dict.TryAdd(i, "Swathi" + i);
                Thread.Sleep(100);
            }
        }
    }
}*/
//Concurrency Collection
//Generic Dictionary with thread safety Problem
/*namespace threadSafety
{
    class Program
    {
        static Dictionary<int, string> dict = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Add1);
            Thread t2 = new Thread(Add2);
            t1.Start();
            t2.Start();
        }   
        public static void Add1()
        {
            for (int i = 0; i < 10; i++)
            {
                dict.Add(i, "Maha" + i);
                Thread.Sleep(100);
            }
        }
        public static void Add2()
        {
            for (int i = 0; i < 10; i++)
            {
                dict.Add(i, "Swathi" + i);
                Thread.Sleep(100);
            }
        }
    }
}
//Gives error like Key already exists*/
/*namespace concurrencycollection
{
    class Program
    {
        static ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Add1);
            Thread t2 = new Thread(Add2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }

        }
        public static void Add1()
        {
            for (int i = 0; i < 10; i++)
            {
                dict.TryAdd(i, "Maha" + i);
                Thread.Sleep(100);
            }
        }
        public static void Add2()
        {
            for (int i = 0; i < 10; i++)
            {
                dict.TryAdd(i, "Swathi" + i);
                Thread.Sleep(100);
            }
        }
    }
}*/
//Concurrent Dictionary
/*namespace concurrenctdictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<int, string> Countries = new ConcurrentDictionary<int, string>();

            Countries.TryAdd(1, "India");
            Countries.TryAdd(2, "USA");
            Countries.TryAdd(3, "UK");
            Countries.TryAdd(4, "Australia");
            Countries.TryAdd(5, "Canada");

            //tryUpdate
            //AddorUpdate
            //getorAdd
            //trygetValue
            
            Countries.TryUpdate(1, "Japan", "India");
            Countries.AddOrUpdate(1, "Japan", (k, v) => "India");
            Countries.AddOrUpdate(6, "Japan", (k, v) => "India");

            Console.WriteLine(Countries.GetOrAdd(7, "China"));
            Countries.TryGetValue(5, out string res1);
            Console.WriteLine(res1);

            Console.WriteLine("Total Countries: " + Countries.Count);
            Console.WriteLine(Countries.ContainsKey(3));

            foreach (KeyValuePair<int, string> kvp in Countries)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
    }
}*/
//concurrentstack
/*namespace nonconcurrentstack
{
    class Program
    {
        static object lockobj = new object();
        static void Main(string[] args)
        {
            TestStack();
        }
        public static void TestStack()
        {
            Stack<string> Borders = new Stack<string>();
            *//*GetOrders("AAA", Borders);
            GetOrders("BBB", Borders);*//*
            Task t1 = Task.Run(()=>GetOrders("AAA", Borders));
            Task t2 = Task.Run(()=>GetOrders("BBB", Borders));
            Task.WaitAll(t1, t2);
            foreach (var item in Borders)
            {
                Console.WriteLine(item);
            }

        }
        public static void GetOrders(string CustName, Stack<string> Borders)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                string order = CustName + "Needs" + (i + 3) + "Items";
                lock (lockobj)
                {
                    Borders.Push(order);
                }
                
            }
        }
    }
}*/
/*namespace concurrentstack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<string> stack = new ConcurrentStack<string>();
            stack.Push("Maha");
            stack.Push("Swathi");
            stack.Push("Nitesh");
            stack.Push("Lakshmi");
            stack.Push("Karthik");

            stack.TryPop(out string result);
            Console.WriteLine(result);
            stack.TryPeek(out string result1);
            Console.WriteLine(result1);

            string[] strings = new string[5];
            stack.CopyTo(strings, 0);

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/
/*namespace concurrentqueue
{
    class Program
    {
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            ConcurrentQueue<Student> queue = new ConcurrentQueue<Student>();
            *//*queue.Enqueue("Maha");
            queue.Enqueue("Swathi");
            queue.Enqueue("Nitesh");
            queue.Enqueue("Lakshmi");
            queue.Enqueue("Karthik");
            queue.TryPeek(out string result1);
            Console.WriteLine(result1);
            queue.TryDequeue(out string result);
            Console.WriteLine(result);
            Console.WriteLine("-------------------");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            string[] strings = new string[5];
            queue.CopyTo(strings, 0);
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }*//*
            Student s1 = new Student();
            s1.ID = 1;
            s1.Name = "Maha";

            Student s2 = new Student();
            s2.ID = 2;
            s2.Name = "Swathi";

            Student s3 = new Student();
            s3.ID = 3;
            s3.Name = "Nitesh";

            queue.Enqueue(s1);
            queue.Enqueue(s2);
            queue.Enqueue(s3);

            foreach (var item in queue)
            {
                Console.WriteLine(item.ID + ":" + item.Name);
            }
        }
    }
}*/
//ConcurrentBag
/*concurrent bag is same as like generic list but generic list is not thread safety 
 concurrent bag stored unordered and can store duplicate values*/
/*namespace genericlistwiththreads
{
    class Program
    {
        static object lockobj = new object();
        static void Main(string[] args)
        {
            TestBag();
        }
        public static void TestBag()
        {
            List<string> bag = new List<string>();
           *//* GetOrders("AAA", bag);
            GetOrders("BBB", bag);*//*
           Task t1 = Task.Run(() => GetOrders("AAA", bag));
            Task t2 = Task.Run(() => GetOrders("BBB", bag));
            Task.WaitAll(t1, t2);
            foreach (var item in bag)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetOrders(string CustName,List<string> orders)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                string order = CustName + "Needs" + (i + 3) + "Items";
                lock (lockobj)
                {
                    orders.Add(order);
                }
                
            }
        }   
    }
}*/
/*namespace concurrentbag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("Maha");
            bag.Add("Swathi");
            bag.Add("Nitesh");
            bag.Add("Lakshmi");
            bag.Add("Karthik");
            bag.TryTake(out string result);
            bag.TryPeek(out string result1);
            Console.WriteLine(result1);
            Console.WriteLine(result);
            Console.WriteLine("-------------------");
            foreach (var item in bag)
            {
                Console.WriteLine(item);
            }
            string[] array = bag.ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/
//Optional Parameters
/*namespace optionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);
            Add(10, 20, 30);
            Add(10, 20, 30, 40);
            function(10, 20, 30, 40, 50);
            Add(10, 20,d: 1);
            function(10, 20);
            function(10, 20, new int[] { 30, 40, 50 });
        }
        public static void Add(int a, int b, int c = 0, int d = 0)
        {
            Console.WriteLine(a + b + c + d);
        }
        *//*public static void function(int a,int b, params int[] nums)
        {
            int result = a + b;
            foreach(int i in nums)
            {
                result += i;
            }
            Console.WriteLine(result);
        }*//*
        public static void function(int a, [Optional] int b, params int[] nums)
        {
            int result = a + b;
            foreach (int i in nums)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
        public static void function(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}*/
//Indexers
/*The indexers in c# is a property of a class that allows us to access a member variable of a class using the features of an array.
 That means the indexers in c# are the members of a class and if we define indexers in a class then the class behaves like a virtual array.
So, the indexers in c# allow instances of a class to be indexed just like arrays.
The indexed value can be set or retrieved without explicitly specifying a type or instance member.*/
/*namespace indexers
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Employee(int id, string name, string  gender, double salary, string department)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;
            this.Department = department;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Gender;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Department;
                return null;
            }
            set
            {
                if (index == 0)
                    ID = (int)value;
                else if (index == 1)
                    Name = (string)value;
                else if (index == 2)
                    Gender = (string)value;
                else if (index == 3)
                    Salary = (double)value;
                else if (index == 4)
                    Department = (string)value;
            }
        }
        public object this[string index]
        {
            get
            {
                if (index == "ID")
                    return ID;
                else if (index == "Name")
                    return Name;
                else if (index == "Gender")
                    return Gender;
                else if (index == "Salary")
                    return Salary;
                else if (index == "Department")
                    return Department;
                return null;
            }
            set
            {
                if (index == "ID")
                    ID = (int)value;
                else if (index == "Name")
                    Name = (string)value;
                else if (index == "Gender")
                    Gender = (string)value;
                else if (index == "Salary")
                    Salary = (double)value;
                else if (index == "Department")
                    Department = (string)value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Ravi","Male",12000,"IT");
            Console.WriteLine("ID=" + emp[0]);
            Console.WriteLine("Name=" + emp[1]);
            Console.WriteLine("Gender=" + emp[2]);
            Console.WriteLine("Salary=" + emp[3]);
            Console.WriteLine("Department=" + emp[4]);
            emp["ID"] = 2;
            emp["Salary"] = 70000.0;
            Console.WriteLine("ID=" + emp["ID"]);
            Console.WriteLine("Name=" + emp["Name"]);
            Console.WriteLine("Gender=" + emp["Gender"]);
            Console.WriteLine("Salary=" + emp["Salary"]);
            Console.WriteLine("Department=" + emp["Department"]);
        }
    }
}*/
//File Handling
/*A file is a collection of data stored on a disk with a specific name, extension, and directory path. When you open file using c# for reading and writing purposes it becomes Stream.
 What is Stream?
A stream is a sequence of bytes travelling from a source to a destination over a communication path.
There are two main streams: the Input Stream and the Output Stream.
The input stream is used for reading data from a file(read operation) and the output stream is used for writing into the file(write operation).
Input Stream: This Stream is used to read from a file, which is known as a read operation.
Output Stream: This Stream is used to write data into file, which is known as a write operation.
File Handling in C#:
Generally, we use the file to store data.
Reading: This operation is the basic read operation where the data is going to be read from a file.
Writing: This operation is the basic write operation where the data is going to be written to a file. By default, all existing contents are removed from the file, and new content is written in the file.
Appending: With Append, the new data is going to be added at the end of the file.
The file becomes a stream when we open the file either for writing or for reading.
namespace System.IO
{
    public enum FileMode
    {
        CreateNew = 1,
        Create = 2,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
        Append = 6
    }
}
namespace System.IO
{
    public enum FileAccess
    {
        Read = 1,
        Write = 2,
        ReadWrite = 3
    }
}
namespace System.IO
{
    public enum FileShare
    {
        None = 0,
        Read = 1,
        Write = 2,
        ReadWrite = 3,
        Delete = 4,
        Inheritable = 16
    }
}*/
namespace fileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Text.txt";
            //FileStream fs = new FileStream(path, FileMode.Create);
            FileStream fs = new FileStream(path, FileMode.Append);
            byte[] bytedata = Encoding.Default.GetBytes("Hello World");
            fs.Write(bytedata, 0, bytedata.Length);                
            fs.Close();
            Console.WriteLine("File Created Successfully");
        }
    }
}
