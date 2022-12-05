Person.MyMethod();
public class Person
{
    private string _firstName;
    private string _lastName;

    public Person(string first, string last)
    {
        _firstName = first;
        _lastName = last;
    }

    public string Name => $"{_firstName} {_lastName}";

    public static void MyMethod()
{
    Person person = new Person("Bibek", "Rawat");
    Console.WriteLine(person.Name);
}
}


