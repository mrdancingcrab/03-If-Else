// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input a number between 1-7:");
double.TryParse(Console.ReadLine(), out double num1);

if (num1 == 1)
{
    Console.WriteLine("Monday");
}
else if (num1 == 2)
{
    Console.WriteLine("Tuesday");
}
else if (num1 == 3)
{
    Console.WriteLine("Wednesday");
}
else if (num1 == 4)
{
    Console.WriteLine("Thursday");
}
else if (num1 == 5)
{
    Console.WriteLine("Friday");
}
else if (num1 == 6)
{
    Console.WriteLine("Saturday");
}
else if (num1 == 7)
{
    Console.WriteLine("Sunday");
}
else
    Console.WriteLine("ERROR");
