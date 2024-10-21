public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person { Name = "John", Age = 30 };
        person.PrintDetails();
    }
}