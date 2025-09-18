using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Skriv in ett decimaltal:");

        
        string input = Console.ReadLine();

        
        if (decimal.TryParse(input, out decimal DecimalTal))
        {            
            int Heltal = (int)DecimalTal;
            Console.WriteLine("Avrunda till heltal: " + Heltal);
        }
        else
        {
            Console.WriteLine("Ogiltigt tal. Försök igen.");
        }
    }
}