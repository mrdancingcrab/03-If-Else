// See https://aka.ms/new-console-template for more information

Console.WriteLine("Pls put in a year:");
int.TryParse(Console.ReadLine(), out int year);

if ((year % 4 == 0 && year % 400 == 0) || (year % 4 == 0 && !(year % 100 == 0)))
{
        Console.WriteLine("This IS a leap year");
}
else
    Console.WriteLine("This is NOT a leap year");

   
