using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bloggen
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> alexVektor = new List<string>          //Lista med personliga blogginlägg av Ambika Rajyagor (Den är menad att läsas nedifrån och upp så nyast är först). Jag vill varna för att det här är väldigt personliga inlägg som handlar om utseendefixering, självkänslor och canser. Läs på egen risk. Jag har också hittat en lösning för att få bold och för att få enter funktionen och mellanrum mellan rader. Såg nu att det stod "Varje strängvektor (inlägg) ska innehålla minst två element; ett för titel, en för text" och jag tolkar detta som att du vill att jag gör två separata strings i min lista så det är varför jag gjort på det här viset och lägger titel och blogginlägg separata. 
            {
                "[RETRACTED FOR POTESIAL COPYRIGHTS ISSUE]"
            };
            
            bool Alex = true;            // Variabel för att styra while-loopen
            int input;                   // Variabel för att lagra användarens menyval
            while (Alex)                 // While-loopen som håller menyn igång tills användaren väljer att avsluta
            {
                Console.WriteLine("\x1b[1mExamination: Bloggen\x1b[0m \r\n \r\n");     // Min meny. Den här meningen är i bold med 2 enter efter sig och resterande rader har en enter emellan sig för att det ska vara lättare att läsa
                Console.WriteLine("Välkommen till menyn!\r\n");
                Console.WriteLine("Det är rekommenderat att ge inläggen datum innan du använder sökkfunktionen och det är också då lättast att hitta. \r\n");
                Console.WriteLine("[1] Spara en anteckning till bloggen \r\n");
                Console.WriteLine("[2] Visa bloggen \r\n");
                Console.WriteLine("[3] Sök i bloggen (rekommenderas att observera val 2 för inläggsnummer innan) \r\n");
                Console.WriteLine("[4] Avsluta programmet \r\n");
                Console.WriteLine("[5] Redigera ett inlägg i bloggen och ge ett datum \r\n");

                if (!int.TryParse(Console.ReadLine(), out input))       // Felhantering för ogiltig inmatning, förhindrar krash och för dig tillbaka till menyn
                {
                    Console.WriteLine("Felaktig inmatning, försök igen.");
                    continue;
                }

                switch (input)
                {
                    case 1:         //Val 1 låter dig skriva titel och sedan ett blogginlägg sträng med variabel "titel", "datumInput" och "blogginlägg" som sedan sparas i listan "alexVektor"
                        Console.WriteLine("Skriv en titel till ditt blogginlägg:");
                        string titel = Console.ReadLine() ?? "";
                        Console.WriteLine("Skriv ett blogginlägg:");
                        string blogginlägg = Console.ReadLine() ?? "";

                        if (string.IsNullOrWhiteSpace(titel) || string.IsNullOrWhiteSpace(blogginlägg))     // Felhantering för att undvika inmatningar som kan orsaka fel eller crasher
                        {
                            Console.WriteLine("Du måste skriva en titel och blogginlägg. Försök igen.");    
                            break;
                        }

                        Console.WriteLine("Ange datum för inlägget:");
                        string datumInput = Console.ReadLine() ?? "";
                        DateTime datum;
                        while (!DateTime.TryParse(datumInput, out datum))
                        {
                            Console.WriteLine("Felaktigt datumformat. Försök igen (t.ex. 2025-10-06):");     // Felhantering 
                            datumInput = Console.ReadLine() ?? "";
                        }

                        alexVektor.Add("\u001b[1m" + titel + "\u001b[0m" + ", " + datumInput + "\r\n" + blogginlägg + "\r\n \r\n \r\n \r\n \r\n");            //Skriver ut allting, notera att jag velat ha titel med mellanrum innan datumet och , tecken för att sedan börja med bogginlägget på en ny rad. Avsluas med mellanrum innan nästa inlägg
                        Console.WriteLine("Ditt blogginlägg sparades i listan. \r\n \r\n");
                        break;

                    case 2:  // Visa alla blogginlägg
                        for (int i = 0; i < alexVektor.Count; i++)  // Lista alla inlägg
                        {
                            Console.WriteLine($"{i + 1}.{alexVektor[i]}");
                        }
                        Console.WriteLine("\u001b[1mSLUT PÅ LISTAN\u001b[0m \r\n \r\n \r\n \r\n \r\n");        //I bold med 2 enter efter sig för att det ska se bättre ut
                        break;

                    case 3:
                        
                        Console.WriteLine("Skriv ett ord att söka efter:");
                        string sökord = Console.ReadLine() ?? "";
                        bool hitta = false;        // Vi använder variabeln "hitta" för att kontrollera om något hittades
                         
    
                        foreach (var resultat in alexVektor.Where(s => s.IndexOf(sökord, StringComparison.InvariantCultureIgnoreCase) != -1))
                        {
                            Console.WriteLine("\r\n \r\n \r\n" + resultat);
                            hitta = true;
                        }
                        if (!hitta)
                            Console.WriteLine("Inget blogginlägg matchade din sökning.\r\n \r\n");
                            hitta = false;
                        break;

                    case 4:
                        Console.WriteLine("Avslutar programmet. Tryck Enter.");
                        Alex = false;
                        break;

                    case 5:
                        Console.WriteLine("Vilket inlägg vill du ändra datum på? Ange numret:");
                        if (int.TryParse(Console.ReadLine(), out int datumÄndring) && datumÄndring > 0 && datumÄndring <= alexVektor.Count)
                        {
                            Console.WriteLine(alexVektor[datumÄndring - 1]);
                            string original = alexVektor[datumÄndring - 1];
                            Console.WriteLine(original);

                            Console.WriteLine("Ange nytt datum (t.ex. 2025-10-05):");
                            string nyttDatum = Console.ReadLine() ?? "";

                            if (string.IsNullOrWhiteSpace(nyttDatum))
                            {
                                Console.WriteLine("Ingen ändring gjordes.\r\n");
                                break;
                            }

                            if (!DateTime.TryParse(nyttDatum, out DateTime Datum))
                            {
                                Console.WriteLine("Felaktigt datumformat. Använd formatet ÅÅÅÅ-MM-DD.\r\n");
                                break;
                            }

                            string nyttFormat = "{nyttDatum:yyyy-MM-dd}";
                            string uppdateradPost = System.Text.RegularExpressions.Regex.Replace
                            (
                                original,
                                @"\d{4}-\d{2}-\d{2}",
                                nyttFormat
                            );

                            if (uppdateradPost == original)
                                uppdateradPost = $"\u001b[1m{nyttFormat}\u001b[0m - {original}";

                            alexVektor[datumÄndring - 1] = uppdateradPost;
                            Console.WriteLine("Datumet har uppdaterats!\r\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen. \r\n \r\n");
                        break;

                }        
            }
        }
    }
}
