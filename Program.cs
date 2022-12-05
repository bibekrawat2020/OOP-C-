TestStruct.MyFormula();
public struct Rectangle
{
    public int Width, Height;
}
public class TestStruct
{
    public static void MyFormula()
    {
        Rectangle r = new Rectangle();
        r.Width = 10;
        r.Height = 20;
        Console.WriteLine("Width = {0}, Height = {1}", r.Width, r.Height);
        Console.WriteLine("Area = {0}", r.Width * r.Height);
    }
}