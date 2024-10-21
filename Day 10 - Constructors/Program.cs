public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
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
        Person person = new Person("John", 30);
        person.Greet();
    }
}