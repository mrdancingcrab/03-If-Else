// See https://aka.ms/new-console-template for more information

Console.WriteLine("Choose one number:");
int.TryParse(Console.ReadLine(), out int num1);


if (num1 > 0)
{
    Console.WriteLine("Your number is positive");
}

else if (num1 < 0)
{
    Console.WriteLine("Your number is negative!");
}
else
    Console.WriteLine("Your number is zero");



