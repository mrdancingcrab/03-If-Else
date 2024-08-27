// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ange din ålder:");
int.TryParse(Console.ReadLine(), out int age);

if (age < 13)
{
    Console.WriteLine("You are a child");
}
else if (age > 12 && age < 20)
{
    Console.WriteLine("You are a teenager.");
}
else 
    Console.WriteLine("You are an adult.");

