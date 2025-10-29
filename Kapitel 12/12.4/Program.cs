using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<decimal> temperaturer = new List<decimal>();
        bool körProgram = true;

        while (körProgram)
        {
            Console.Clear();
            Console.WriteLine("             Temperaturhantering");
            Console.WriteLine("");
            Console.WriteLine("[1] Lägg till temperaturmätning");
            Console.WriteLine("[2] Skriv ut temperaturer och medeltemperatur");
            Console.WriteLine("[3] Ta bort temperaturmätning");
            Console.WriteLine("[4] Avsluta");
            Console.Write("Ditt val: ");

            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.Write("Ange temperatur:");
                    string input = Console.ReadLine();
                    if (decimal.TryParse(input.Replace(',', '.'), out decimal temp))
                    {
                        temperaturer.Add(temp);
                        Console.WriteLine("Temperatur tillagd.");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning. Endast decimaltal tillåts.");
                    }
                    break;

                case "2":
                    if (temperaturer.Count == 0)
                    {
                        Console.WriteLine("Inga temperaturer registrerade ännu.");
                    }
                    else
                    {
                        Console.WriteLine("\nRegistrerade temperaturer:");
                        foreach (var t in temperaturer)
                        {
                            Console.WriteLine($"{t} °C");
                        }

                        decimal medel = temperaturer.Average();
                        Console.WriteLine($"\nMedeltemperatur: {medel:F2} °C");
                    }
                    break;

                case "3":
                    if (temperaturer.Count == 0)
                    {
                        Console.WriteLine("Det finns inga temperaturer att ta bort.");
                    }
                    else
                    {
                        Console.WriteLine("\nTemperaturer:");
                        for (int i = 0; i < temperaturer.Count; i++)
                        {
                            Console.WriteLine($"[{i}] {temperaturer[i]} °C");
                        }

                        Console.Write("Ange index på temperaturen du vill ta bort: ");
                        string indexInput = Console.ReadLine();

                        if (int.TryParse(indexInput, out int index) && index >= 0 && index < temperaturer.Count)
                        {
                            temperaturer.RemoveAt(index);
                            Console.WriteLine("Temperatur borttagen.");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt index.");
                        }
                    }
                    break;

                case "4":
                    körProgram = false;
                    Console.WriteLine("Avslutar programmet...");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Välj 1–4.");
                    break;
            }

            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
