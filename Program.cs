Car.ford();
class Car
{
    string? model;
    public Car()
    {
        model = "Mustang";
    }
    public static void ford()
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}