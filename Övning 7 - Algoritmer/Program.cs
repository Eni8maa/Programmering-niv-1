using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Övning7
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool isRunning = true;
            List<int> sifferLista = new List<int>();
            bool intSortering = false;
            bool sortering = false;
            bool inlägg = false;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "\n\tVälkommen till Övning 7 - Algoritmer\n\t" +
                    "#########################\n\t\n\t" +
                    "[1]Generera siffror\n\t" +
                    "[2]Sortera siffror\n\t" +
                    "[3]Sök bland siffror\n\t" + //\n\t
                                                 //"[4][EXTRA]Generera bokstäver\n\t" +
                                                 //"[5][EXTRA]Sortera bokstäver\n\t" +
                                                 //"[6][EXTRA]Sök bland bokstäver\n\t\n\t" +
                    "["/*7*/ + 4 + "]Avsluta program"       //Fixat alla \n\t så att de fungerar
                );
                Int32.TryParse(Console.ReadLine(), out int meny);
                int siffror = 0;
                switch (meny)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\tVar god skriv in hur många siffror du vill generera.");
                        if (!Int32.TryParse(Console.ReadLine(), out siffror) || siffror < 1 || siffror > 100) // Tar emot antal siffror användaren vill generera samt felhanterar
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tFelaktig inmatning – du måste skriva ett tal. Tryck Enter.");
                            Console.ReadLine();
                            inlägg = false;
                            break;
                        }
                        Random rnd = new Random();
                        sifferLista.Clear();
                        for (int i = 0; i < siffror; i++)
                        {
                            sifferLista.Add(rnd.Next(1, 100));
                        }
                        Console.WriteLine("Ditt blogginlägg sparades i listan. \r\n \r\n");
                        SifferUtskrift(sifferLista);
                        inlägg = true;
                        MenyAvslut();
                        break;


                    case 2:
                        Console.Clear();
                        if (sifferLista.Count == 0)
                        {
                            Console.WriteLine("\n\tDet saknas inlägg i sifferlistan. Generera lite siffror först.");
                            sortering = false;
                            MenyAvslut();
                            break;
                        }
                        Console.WriteLine("\n\tSiffror sorterade. Se resultat;\n\t");

                        for (int i = 0; i < sifferLista.Count - 1; i++)
                        {
                            for (int b = 0; b < sifferLista.Count - 1 - i; b++)
                            {
                                if (sifferLista[b] > sifferLista[b + 1])
                                {
                                    int temp = sifferLista[b];
                                    sifferLista[b] = sifferLista[b + 1];
                                    sifferLista[b + 1] = temp;
                                }
                            }
                            Console.WriteLine("\n\tSiffror sorterade:\n");
                            SifferUtskrift(sifferLista);
                            sortering = true;
                            MenyAvslut();
                            break;
                        }
                        break;

                    case 3: // Här ska användaren kunna söka bland siffrorna med en binärsökning.
                        {
                            {

                                Console.WriteLine("\n\tVilken siffra vill du söka på?");
                                Console.ReadLine();if (int.TryParse(Console.ReadLine(), out int sökord))                                       
                                if (!inlägg)
                                {
                                    Console.WriteLine("\n\tDet saknas inlägg i sifferlistan. Generera lite siffror först."); // Användaren har inte genererat något värde till listan.
                                    MenyAvslut(); // Kallar på vår standardiserade menyavslutning.
                                    break;
                                }
                                if (!sortering)
                                {
                                    Console.WriteLine("\n\tSiffrorna i din lista behöver sorteras. Kör en sortering innan sökningen."); // Användaren behöver göra en sortering.
                                    sortering = false;
                                    MenyAvslut();
                                    break;
                                }
                                int[] sifferArray = sifferLista.ToArray();
                                int resultat = Array.BinarySearch(sifferArray, sökord);

                                if (resultat < 0)
                                {
                                    Console.WriteLine("Felaktig inmatning. Tryck Enter.");
                                    Console.ReadLine();
                                    break;
                                }
                                while (intSortering)
                                {

                                    Int32.TryParse(Console.ReadLine(), out int key);
                                    if (key < 0) key = 0;
                                    Int32.TryParse(Console.ReadLine(), out int keyLängd);
                                    if (keyLängd < 0) keyLängd = -1;
                                    if (keyLängd > key) keyLängd = -1;
                                    int mellan = key + keyLängd / 2;
                                    if (sökord > mellan)
                                    {
                                        mellan = sökord;
                                    }
                                    else if (sökord < mellan)
                                    {
                                        mellan = -1;
                                    }
                                    else if (key > keyLängd)
                                    {
                                        Console.WriteLine("Sökningen lyckades inte. Tryck enter.");
                                        MenyAvslut();
                                        break;
                                    }
                                    else
                                    {
                                        foreach (var match in sifferLista.Where(i => i == sökord))
                                        {
                                            Console.WriteLine("\r\n \r\n \r\n" + match);
                                            Console.WriteLine("Siffran du sökte på finns på element " + mellan + " i sifferlistan.");
                                            Console.ReadLine();
                                            break;
                                        }

                                    }
                                }
                            }
                        }
                        break;

                    case 4: // Programmet avslutas
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
        private static object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        private static void SifferUtskrift(List<int> sifferLista) // Tar emot en lista, skriver ut alla inlägg i listan på ett stiligt vis.
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int counter = 0; // Initierar en räknare
            foreach (int s in sifferLista) // FÖR VARJE siffra i sifferlistan
                if (counter == 0) // OM räknaren är noll
                {
                    if (s < 10)
                        Console.Write("\t" + s + "  "); // Skjut fram raden, skriv ut siffran, lägg till mer utrymme för läsbarhet
                    else
                        Console.Write("\t" + s + " "); // Skjut fram raden, skriv ut siffran
                    counter++; // Öka räknare med ett
                }
                else if (counter < 4) // ANNARS OM räknaren är mindre än fem
                {
                    if (s < 10)
                        Console.Write(s + "  "); // Skjut fram raden, skriv ut siffran, lägg till mer utrymme för läsbarhet
                    else
                        Console.Write(s + " "); // Skjut fram raden, skriv ut siffran
                    counter++; // Öka räknare med 1
                }
                else // ANNARS
                {
                    Console.WriteLine(s + " "); // Skriv ut siffra på ny rad
                    counter = 0; // Nollställ räknare
                }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void BokstavUtskrift(List<string> ordLista) // Tar emot en lista, skriver ut alla inlägg i listan på ett stiligt vis.
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string b in ordLista)
            {
                Console.WriteLine("\t " + b);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void MenyAvslut() // För att undvika upprepande kod
        {
            Console.WriteLine("\n\tTryck ENTER för att återvända till menyn.");
            Console.ReadLine();
        }
    }
}