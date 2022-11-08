//declare a Person class
public class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine("Hello {0}, my name is {1}", to, Name);
    }

    // static method
    public static Person Parse(string name)
    {
        var person = new Person();
        person.Name = name;
        return person;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create an object from Person class
        var person = new Person();
        // set value for the Name field
        person.Name = "Thuy";
        // call Introduce method
        person.Introduce("Jens");

        // create a Person object from a tring using Parse method
        var myPerson = Person.Parse("Thuy");
        myPerson.Introduce("Anders");
    }
}