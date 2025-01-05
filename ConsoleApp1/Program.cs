namespace Example
{
    public class Class1
    {
        internal int a = 100;
    }
    public class Class2 
    {
        public void method1()
        {
        Class1 c = new Class1();
        Console.WriteLine(c.a);
        }
    }
}