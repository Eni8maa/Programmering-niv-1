using System;
using System.Globalization;

namespace elva.sex
{
    public class Programs
    {
        static public void Main(string[] args)
        {
            Console.Write("Skriv in ett decimaltal mellan 0 och 1: ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal decimaltal))
            {
                int heltal = (int)(decimaltal * 100);
                Console.WriteLine($"Resultat: {heltal}. Tryck enter.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Felaktig inmatning. Tryck enter.");
                Console.ReadLine();
            }

            Console.WriteLine("Tryck enter för att avsluta");
            Console.ReadKey();
        }
    }
}