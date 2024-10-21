public class Student
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Grade { get; private set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[5];

        students[0] = new Student("John", 20, "A");
        students[1] = new Student("Alice", 22, "B");
        students[2] = new Student("Bob", 19, "A");
        students[3] = new Student("Charlie", 21, "C");
        students[4] = new Student("Eve", 23, "B");

        foreach (var student in students)
        {
            student.PrintStudentInfo();
        }
    }
}