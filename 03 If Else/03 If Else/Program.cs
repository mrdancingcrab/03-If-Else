// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fill in your score between 0-100:");
int.TryParse(Console.ReadLine(), out int score);

if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score < 90 && score >= 80)
{
    Console.WriteLine("B");
}
else if (score < 80 && score >= 70)
{
    Console.WriteLine("C");
}
else if (score < 70 && score >= 60)
{
    Console.WriteLine("D");
}
else
    Console.WriteLine("F");
   

