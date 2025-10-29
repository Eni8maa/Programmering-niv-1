using System;

namespace Ryggsäcken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool minBool = true;
            string dittOrd = "";  // String istället för int

            while (minBool)
            {
                Console.WriteLine("Välkommen till menyn!");
                Console.WriteLine("[1] Spara ett ord");
                Console.WriteLine("[2] Skriv ut sparat ord");
                Console.WriteLine("[3] Nollställ ord");
                Console.WriteLine("Övriga tal stänger programmet");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Skriv ett ord:");
                    dittOrd = Console.ReadLine();  // Spara ord till variabeln
                    Console.WriteLine("Du skrev: " + dittOrd);  // Visar det sparade ordet
                }
                else if (input == 2)
                {
                    Console.WriteLine("Ditt ihågkommna ord är: " + dittOrd);  // Visar det sparade ordet
                }
                else if (input == 3)
                {
                    dittOrd = "";  // Nollställ ordet
                    Console.WriteLine("Ditt ihågkommna ord har nollställts.");
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                    minBool = false;  // Avsluta loopen om användaren bryter mot instruktioner
                }
            }
        }
    }
}
