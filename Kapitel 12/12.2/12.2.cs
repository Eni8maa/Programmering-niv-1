using System;
using System.Collections.Generic;   

class Program
{
    static void Main()
    {
        List<string> namn = new List<string>();
        int input;
        bool knapp = true;

        while (knapp)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till menyn!");
            Console.WriteLine("[1] Skriv 5 namn");
            Console.WriteLine("[2] Skriv ut sparade namn");
            Console.WriteLine("Övriga val stänger programmet");

            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out input))
            {
                Console.WriteLine("Ogiltigt val. Programmet kommer nu att avslutas.");
                knapp = false;
                continue;
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine("Skriv ett namn :");
                    int namnCount = 0;
                    while (namnCount < 5)
                    {
                        string? nyttNamn = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(nyttNamn))
                        {
                            Console.WriteLine("⚠️ Du skrev inget namn, försök igen.");
                            Console.WriteLine("('q' för att återgå.)");
                            continue;
                        }

                        if (nyttNamn.Trim().ToLower() == "q")
                        {
                            // användaren vill tillbaka till menyn
                            break;
                        }

                        namn.Add(nyttNamn);
                        namnCount++;
                        Console.WriteLine($"✅ '{nyttNamn}' sparat! ({namnCount}/5)");
                        if (namnCount < 5)
                            Console.WriteLine("('q' för att återgå.)");
                    }
                    break;

                case 2:
                    if (namn.Count == 0)
                        Console.WriteLine("❗ Du har ännu inte sparat några namn.");
                    else
                    {
                        Console.WriteLine("📋 Dina sparade namn:");
                        for (int i = 0; i < namn.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {namn[i]}");
                        }
                    }
                    Console.WriteLine("\nVill du lägga till ett namn direkt? (j/n)");
                    string? svar = Console.ReadLine();
                    if (svar != null && svar.Trim().ToLower() == "j")
                    {
                        Console.WriteLine("Skriv ett namn att lägga till:");
                        string? nyttNamn = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nyttNamn))
                        {
                            namn.Add(nyttNamn);
                            Console.WriteLine($"✅ '{nyttNamn}' sparat!");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Du skrev inget namn.");
                        }
                    }
                    Vänta();
                    break;

                case 3:
                    Console.WriteLine("Avslutar programmet...");
                    knapp = false;
                    break;

                default:
                    Console.WriteLine("❌ Ogiltigt menyval, försök igen.");
                    Vänta();
                    break;
            }
        }
    }

    static void Vänta()
    {
        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
        Console.ReadKey();
    }
}