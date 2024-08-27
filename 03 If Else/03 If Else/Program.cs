// See https://aka.ms/new-console-template for more information

Console.WriteLine("Total amount:");
double.TryParse(Console.ReadLine(), out double amount);


if (amount > 1000 )
{
    amount = amount * 0.9;
    Console.WriteLine("Your price is: " + amount);    
}
else
    Console.WriteLine("Your price is: " + amount);