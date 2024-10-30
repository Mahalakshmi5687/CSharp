using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace HelloWorld
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
}*/
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
