Car.PrintColor();
class Car
{
    string color="red";
    public static void PrintColor()
    {
        Car c = new Car();
        Console.WriteLine(c.color);
    }
}