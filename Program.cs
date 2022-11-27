Car.blankField();
class Car
{
    string? color; //blank field
    int maxSpeed; //blank field
    public static void blankField()
    {
        Car myObj = new Car();
        myObj.color = "red"; //assign value to blank field
        myObj.maxSpeed = 200; //assign value to blank field
        Console.WriteLine(myObj.color + " " + myObj.maxSpeed);
    }
}