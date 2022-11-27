Car.PrintColor();
class Car
{
    string color1="red";
    string color2="blue";
    public static void PrintColor()
    {
        Car c1 = new Car();
        Console.WriteLine(c1.color1);
        Car c2 = new Car();
        Console.WriteLine(c2.color2);
    }
}