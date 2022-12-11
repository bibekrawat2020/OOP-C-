ThisRef.MyMethod();
public class ThisRef
{
    public class A
    {
        public string whatstring = "Default value";
        public void WhatMethod()
        {
            Console.WriteLine($"Coming from class A, what string: {whatstring}!");
        }
    }
    public class B:A
    {
        public void setstring (string newvalue)
        {
            whatstring = newvalue;
        }
    }
    public static void MyMethod()
    {
        B c = new B();
        Console.WriteLine($"Default value of whatstring: {c.whatstring} coming from class A!");
        c.setstring("New value");
        Console.WriteLine($"Calling inherited method of WhatMethod: c.setstring() with result of: {c.whatstring}");
        Console.Read();
    }
}