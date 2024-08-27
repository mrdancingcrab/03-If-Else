// See https://aka.ms/new-console-template for more information




bool myBool = true;


while (myBool)
{
    Console.Clear();
    Console.WriteLine("1. Fahrenheit to Celsius:");
    Console.WriteLine("2. Celsius to Fahrenheit:");
    double.TryParse(Console.ReadLine(), out double val);

    switch (val)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("How many degrees F");
            double.TryParse(Console.ReadLine(), out double fahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in C: " + celsius);
            Console.WriteLine("Press ENTER to return");
            Console.ReadLine();
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("How many degrees C");
            double.TryParse(Console.ReadLine(), out double celsius2);
            double fahrenheit2 = (celsius2 * 9) / 5 + 32;
            Console.WriteLine("Temperture in F: " + fahrenheit2);
            Console.WriteLine("Press ENTER to return");
            Console.ReadLine();
            break;

        default:
            Console.Clear();
            Console.WriteLine("You must put in a valid number");
            Console.WriteLine("Press ENTER to return");
            Console.ReadLine();
            break;

    }
}
