using System;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)         //Metoden main
        {
            Random slumpat = new Random();      //Skapar ett random objekt
            bool Lucius = true;     //Hela programmet körs så länge programmet Lucius är true
            int tal = 0;        //Håller koll på det sparade talet

            while (Lucius)
            {
                Console.WriteLine("Välkommen till menyn!"); //Meny för användaren
                Console.WriteLine("[1] Rulla tärning");
                Console.WriteLine("[2] Skriv ut sparat tal");
                Console.WriteLine("[3] Stäng programmet");
                Console.WriteLine("");
                Console.WriteLine("Övriga tal stänger programmet");

                int input;
                if (!int.TryParse(Console.ReadLine(), out input))

                switch (input)
                {
                    case 1:
                        tal = slumpat.Next(1, 7);       // Kasta tärningen
                        Console.WriteLine("\tDitt tal är: " + tal );
                        break;
                    case 2:     //Skriver ut det sparade talet
                            Console.WriteLine("Ditt ihågkommna tal är: " + tal);
                        break;
                    case 3:         //Avslutar programmet
                            tal = 0;
                        Console.WriteLine("Programmet avslutas. Tryck enter.");
                        Console.ReadLine();
                        Lucius = false;
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
