using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string Yes = "Ja";
        string No = "Nej";
        bool knapp = true;      // Variabel för att styra while-loopen

        while (knapp)
        {
            Console.WriteLine("Välkommen till menyn!");     // Min meny
            Console.WriteLine("Är du myndig? (Ja/Nej)");

            string input = Console.ReadLine();

            if (input == Yes)     // Jämför nu sträng med sträng
            {
                Console.WriteLine("Okej då vet jag. Tryck enter.");
                Console.ReadLine();
                knapp = false;
            }
            else if (input == No) // Jämför nu sträng med sträng
            {
                Console.WriteLine("Ah okej, detta är noterat. Tryck enter.");
                Console.ReadLine();
                knapp = false;
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Programmet kommer nu att avslutas. Vänligen försök igen.");        //Talar om att programmet avslutas vid ogiltigt val
                Console.ReadLine();
                knapp = false;
            }
        }
    }
}