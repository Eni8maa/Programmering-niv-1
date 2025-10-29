using System;
using System.Collections.Generic;
using System.Linq;

namespace Listorochmetoder2
{
    class Program
    {
        static void Main(string[] args)         //Metoden main
        {
            Random slumpat = new Random();      //Skapar ett random objekt
            bool Lucius = true;     //Hela programmet körs så länge programmet Lucius är true
            int tal = 0;        //Håller koll på det sparade talet
            List<int> kastHistorik = new List<int>(); // Sparar alla tärningskast
            int maxVärde = 6; // Standard maxvärde för tärningen


            while (Lucius)
            {
                Console.WriteLine("Välkommen till menyn!"); //Meny för användaren
                Console.WriteLine("[1] Rulla tärning");
                Console.WriteLine("[2] Skriv ut sparat tal");
                Console.WriteLine("[3] Stäng programmet");
                Console.WriteLine("[4] Sortera och visa tärningskast");
                Console.WriteLine("[5] Ändra maxvärde för tärningen (nuvarande: " + maxVärde + ")");
                Console.WriteLine("");
                Console.WriteLine("Övriga tal stänger programmet");

                int input;
                if (!int.TryParse(Console.ReadLine(), out input))
                    break;

                switch (input)
                {
                    case 1:
                        tal = slumpat.Next(1, maxVärde + 1);       // Kasta tärningen
                        kastHistorik.Add(tal); // Spara kastet i listan
                        Console.WriteLine("\tDitt tal är: " + tal + ". Tryck enter.");
                        Console.ReadLine();

                        if (tal == maxVärde)       //Om talet är 6 får användaren kasta igen
                        {
                            Console.WriteLine("\tGrattis! Du slog en 6:a och får kasta igen!");
                        }
                        else
                        {
                            Lucius = false;
                        }
                        break; // <-- Added break here to prevent fall-through

                    case 2:     //Skriver ut det sparade talet
                        Console.WriteLine("Ditt ihågkommna tal är: " + tal);
                        break;
                    case 3:         //Avslutar programmet
                        tal = 0;
                        Console.WriteLine("Programmet avslutas. Tryck enter.");
                        Console.ReadLine();
                        Lucius = false;
                        break;
                    case 4:
                        if (kastHistorik.Count == 0)
                        {
                            Console.WriteLine("Inga tärningskast att visa ännu.");
                        }
                        else
                        {
                            var sorteradeKast = kastHistorik.OrderBy(x => x).ToList();
                            Console.WriteLine("Sorterade tärningskast:");
                            foreach (var kast in sorteradeKast)
                            {
                                Console.Write(kast + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.Write("Ange nytt maxvärde för tärningen: ");
                        string maxInput = Console.ReadLine();
                        if (int.TryParse(maxInput, out int nyttMax))
                        {
                            maxVärde = nyttMax;
                            Console.WriteLine("Maxvärdet har uppdaterats till: " + maxVärde);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt värde.");
                        }
                        break;

                    default:         //Avslutar programmet
                        Console.WriteLine("Programmet avslutas. Tryck enter.");
                        Console.ReadLine();
                        Lucius = false;
                        break;
                }
            }
        }
    }
}
