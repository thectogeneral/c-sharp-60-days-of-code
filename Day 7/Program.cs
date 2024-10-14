Console.WriteLine("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter operation (+, -, *, /): ");
char op = Convert.ToChar(Console.ReadLine());

double result;
switch (op)
{
    case '+': result = num1 + num2; break;
    case '-': result = num1 - num2; break;
    case '*': result = num1 * num2; break;
    case '/': result = num1 / num2; break;
    default: Console.WriteLine("Invalid operator"); return;
}

Console.WriteLine("Result: " + result);