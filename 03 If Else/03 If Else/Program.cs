// See https://aka.ms/new-console-template for more information

Console.WriteLine("Choose 3 numbers:");
int.TryParse(Console.ReadLine(), out int num1);
int.TryParse(Console.ReadLine(), out int num2);
int.TryParse(Console.ReadLine(), out int num3);

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine(num2);
}
else if (num3 > num2 && num3 > num1)
{
    Console.WriteLine(num3);
}
else
    Console.WriteLine("No winner here");



