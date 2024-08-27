// See https://aka.ms/new-console-template for more information

string password = "HEJ123";
Console.WriteLine("Enter password:");
string input = Console.ReadLine();


if (input == password)
{
    Console.WriteLine("Access granted");
}
else
    Console.WriteLine("Access denied");

