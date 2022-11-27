Car.myMethod();
class Car
{
    string model;
    string color;
    int year;
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
    public static void myMethod()
    {
        Car myObj1 = new Car("Mustang", "Red", 1969);
        Car myObj2 = new Car("Astra", "White", 2005);
        Console.WriteLine(myObj1.model);
        Console.WriteLine(myObj2.model);
    }
}