int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter number:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}