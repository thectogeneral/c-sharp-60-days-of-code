int num = 10;
if (num > 0)
    Console.WriteLine("Positive");
else if (num < 0)
    Console.WriteLine("Negative");
else
    Console.WriteLine("Zero");


int choice = 2;
switch (choice)
{
    case 1: Console.WriteLine("Option 1"); break;
    case 2: Console.WriteLine("Option 2"); break;
    default: Console.WriteLine("Invalid choice"); break;
}