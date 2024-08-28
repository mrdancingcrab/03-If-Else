
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome to the playground!"); // En välkomsthälsning i menyn till användaren
bool myBool = true; // Här initieras en bool till våran loop

while (myBool) // Här startar loopen
{
    Console.Clear(); // Rensar allting i konsolen
    Console.WriteLine("1. Even or Odd "); // Här följer 11 olika menyval
    Console.WriteLine("2. Age Bracket ");
    Console.WriteLine("3. Grade System");
    Console.WriteLine("4. Leap Year Checker");
    Console.WriteLine("5. Maximum of Three");
    Console.WriteLine("6. Positive, Negative or Zero");
    Console.WriteLine("7. Discount System");
    Console.WriteLine("8. Weekdays");
    Console.WriteLine("9. Password Checker");
    Console.WriteLine("10. Temperature Converter");
    Console.WriteLine("11. Quit");
    int.TryParse(Console.ReadLine(), out int val); // Här väljer användaren ett menyval genom input.

    switch (val) // Här triggas användarens val som senare leder till Case 1-11.
    {
        case 1: 
            Console.Clear(); // Rensar allting i konsolen
            Console.WriteLine("Give me a number:"); // Här ber vi användaren om ett nummer.
            double.TryParse(Console.ReadLine(), out double siffra); // Användarens input.

            if (siffra % 2 == 0 && siffra % 1 == 0) // En if-sats som räknar ut "resten" om vi delar på 2, är rest = 0 innebär detta att talet är jämnt.
            {
                Console.WriteLine("Your number is even"); // Detta printas om numret är jämnt.
                Console.ReadLine(); // Används för att inte återgå till menyloopen utan att användaren klicker på ENTER.
            }
            else
            {
                Console.WriteLine("Your number is odd"); // Detta printas om numret är ojämnt.
                Console.ReadLine();   // Används för att inte återgå till menyloopen utan att användaren klicker på ENTER.  
            }    
                break;

        case 2:
            Console.Clear();
            Console.WriteLine("Whats your age:"); // Vi ber användaren om dess ålder.
            int.TryParse(Console.ReadLine(), out int age); // Användarens input.

            if (age < 13) // Om användaren är under 13.
            {
                Console.WriteLine("You are a child");
                Console.ReadLine();
            }
            else if (age >=13 && age < 20) // Om användaren är mellan 13-19.
            {
                Console.WriteLine("You are a teenager.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are an adult."); // Om användaren är över 19.
                Console.ReadLine();
            }
                break;

        case 3:
            Console.Clear();
            Console.WriteLine("Fill in your score between 0-100:"); // Vi ber användaren om deras testpoäng.
            int.TryParse(Console.ReadLine(), out int score); // Användarens input.

            // Denna if-sats placerar in användarens poäng i en betygskala mellan A - F och printar sedan ut betyget.
            if (score >= 90) // Om poängen är lika med eller över 90.
            {
                Console.Clear();
                Console.WriteLine("A");
                Console.ReadLine();
            }
            else if (score < 90 && score >= 80) // Om poängen är lika med eller över 80 men mindre än 90.
            {
                Console.Clear();
                Console.WriteLine("B");
                Console.ReadLine();
            }
            else if (score < 80 && score >= 70) // Om poängen är lika med eller över 70 men mindre än 80.
            {
                Console.Clear();
                Console.WriteLine("C");
                Console.ReadLine();
            }
            else if (score < 70 && score >= 60) // Om poängen är lika med eller över 60 men mindre än 70.
            {
                Console.Clear();
                Console.WriteLine("D");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("F"); // Om poängen är under 60.
                Console.ReadLine();
            }
                break;

        case 4:
            Console.Clear();
            Console.WriteLine("Pls put in a year:"); // Vi ber användaren om valfritt år.
            int.TryParse(Console.ReadLine(), out int year); // användarens inuput.

            if ((year % 4 == 0 && year % 400 == 0) || (year % 4 == 0 && !(year % 100 == 0))) // Om året är delbart med 4 OCH 400, eller om året är delbart med 4 men INTE 100, är det ett skottår.
            {
                Console.WriteLine("This IS a leap year");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is NOT a leap year");
                Console.ReadLine();
            }
                break;

        case 5:
            Console.Clear();
            Console.WriteLine("Choose 3 numbers:"); // Här ber vi användaren mata in 3 valfria nummer.
            int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int.TryParse(Console.ReadLine(), out int num3);

            // Denna if-sats jämför användarens input och printar ut det största möjliga av dessa tre.
            if (num1 > num2 && num1 > num3) // Om det första numret är störst.
            {
                Console.WriteLine(num1); 
                Console.ReadLine();
            }
            else if (num2 > num1 && num2 > num3) // Om det andra numret är störst.
            {
                Console.WriteLine(num2);
                Console.ReadLine();
            }
            else if (num3 > num2 && num3 > num1) // Om det tredje numret är störst.
            {
                Console.WriteLine(num3);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No winner here"); // Om vi har flera lika stora tal i toppen printas detta ut.
                Console.ReadLine();
            }
                break;

        case 6:
            Console.Clear();
            Console.WriteLine("Choose one number:"); // Vi ber användaren om ett nummer.
            int.TryParse(Console.ReadLine(), out int num); // Användarens input.

            // Denna if-sats avgör om numret är positivt, negativt eller 0. 
            if (num > 0) // Om numret är större än 0.
            {
                Console.WriteLine("Your number is positive");
                Console.ReadLine();
            }

            else if (num < 0) // Om numret är mindre än 0.
            {
                Console.WriteLine("Your number is negative!");
                Console.ReadLine();
            }
            else // Om numret är lika med 0.
            {
                Console.WriteLine("Your number is zero");
                Console.ReadLine();
            }
                break;

        case 7:
            Console.Clear();
            Console.WriteLine("Total amount:"); // Vi ber användaren om totalsumman.
            double.TryParse(Console.ReadLine(), out double amount); // Användaren skriver in sin total.

            // Denna if-sats avgör ifall totalbeloppet är över 1000kr, isf ger vi kunden en rabatt på 10% och den nya totalen printas ut.
            if (amount > 1000) // Om summan är över 1000.
            {
                amount = amount * 0.9; // Här gör vi rabattavdraget genom att multiplicera summan med 0.9. 
                Console.WriteLine("Your price is: " + amount); // Printar ut nytt totalbelopp.
                Console.ReadLine();
            }
            else // Om totalsumman inte överstiger 1000kr printar vi ut det normala priset.
            {
                Console.WriteLine("Your price is: " + amount);
                Console.ReadLine();
            }
                break;

        case 8:
            Console.Clear();
            Console.WriteLine("Input a number between 1-7:"); // Vi ber användaren om ett nummer mellan 1-7.
            int.TryParse(Console.ReadLine(), out int day); // Användaren ger sitt input.

            // Denna if-sats tar användarens svar och fördelar det till en dag förknippat med numret som slogs in.
            if (day == 1) // Om användarens input = 1 printar vi ut måndag. Osv.
            {
                Console.WriteLine("Monday");
                Console.ReadLine();
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
                Console.ReadLine();
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
                Console.ReadLine();
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
                Console.ReadLine();
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");
                Console.ReadLine();
            }
            else if (day == 6)
            {
                Console.WriteLine("Saturday");
                Console.ReadLine();
            }
            else if (day == 7)
            {
                Console.WriteLine("Sunday");
                Console.ReadLine();
            }
            else // Detta är ifall användaren skulle skriva en siffra utanför spannet 1-7.
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
            }
                break;

        case 9:
            Console.Clear();
            string password = "HEJ123"; // Här sätter vi ett förbestämt lösenord.
            Console.WriteLine("Enter password:"); // Vi ber användaren att skriva in sitt lösenord.
            string input = Console.ReadLine(); // Användarens input.


            if (input == password) // Om användarens input är detsamma som vårat lösenord.
            {
                Console.WriteLine("Access granted"); // Access granted printas ut. 
                Console.ReadLine();
            }
            else // Om användarens input inte matcher vårat lösenord.
            {
                Console.WriteLine("Access denied"); // Access denied printas ut. 
                Console.ReadLine();
            } 
                break;

        case 10:

            bool myBool2 = true; // initierar en bool till våran miniloop

            while (myBool2) // loopen startas
            {
                Console.Clear();
                Console.WriteLine("1. Fahrenheit to Celsius:"); // Vi frågar användaren om han vill konvertera F till C.
                Console.WriteLine("2. Celsius to Fahrenheit:"); // Vi frågar användaren om han vill konvertera C till F.
                Console.WriteLine("3. Avsluta"); // Ett alternativ för användaren att återgå till lekstugan. 
                double.TryParse(Console.ReadLine(), out double val2); // Användarens input. 

                switch (val2) // Här triggas alternativen baserat på användarens input. 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("How many degrees F"); // Vi ber användaren om en specifik temperatur. 
                        double.TryParse(Console.ReadLine(), out double fahrenheit); // Användarens input
                        double celsius = (fahrenheit - 32) * 5 / 9; // Här sker omvandlingen från F till C.
                        Console.WriteLine("Temperature in C: " + celsius); // Här redovisar vi svaret efter omvandling.
                        Console.WriteLine("Press ENTER to return");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("How many degrees C");  // Vi ber användaren om en specifik temperatur. 
                        double.TryParse(Console.ReadLine(), out double celsius2);  // Användarens input
                        double fahrenheit2 = (celsius2 * 9) / 5 + 32; // Här sker omvandlingen från C till F.
                        Console.WriteLine("Temperature in F: " + fahrenheit2); // Här redovisar vi svaret efter omvandling.
                        Console.WriteLine("Press ENTER to return");
                        Console.ReadLine();
                        break;

                    case 3:
                        myBool2 = false; // Här avslutar vi miniloopen.
                        break;

                    default: // Detta är ifall användaren anger ett menyval utanför 1-3.
                        Console.Clear();
                        Console.WriteLine("You must put in a valid number"); // Vi ber användaren skriva in ett giltigt nummer. 
                        Console.WriteLine("Press ENTER to return");
                        Console.ReadLine();
                        break;

                }
            }
                        break;

        case 11:
            myBool = false;  // Här avslutar vi programmet.
            break;

        default: // Detta är ifall användaren anger ett menyval utanför 1-11.
            Console.WriteLine("You must choose between 1-11");
            Console.ReadLine();        
            break;
    }
}
