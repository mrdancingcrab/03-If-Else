// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ange en siffra:");
int.TryParse(Console.ReadLine(), out int siffra);

if (siffra % 2 == 0)
{
    Console.WriteLine("Din siffra är jämn");
}
else
    Console.WriteLine("Din siffra är ojämn");


