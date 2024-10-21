public class Person
{
    private static int _personCount = 0;

    public string Name { get; private set; }
    public int Age { get; private set; }

    public static int PersonCount => _personCount;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        _personCount++;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, {Name}!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("John", 30);
        Person person2 = new Person("Alice", 25);
        Console.WriteLine($"Number of people created: {Person.PersonCount}");
    }
}