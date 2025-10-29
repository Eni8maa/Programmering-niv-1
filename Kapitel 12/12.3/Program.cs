using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool knapp = true;

        while (knapp)
        {
            Console.Clear();
            Console.WriteLine("Välkommen, hur många mätningar har gjorts idag:");
            string talInput = Console.ReadLine();
            int tal;

            if (int.TryParse(talInput, out tal))
            {
                Console.WriteLine($"{tal} mätningar har gjorts idag.");
            }
            else
            {
                Console.WriteLine("Ogiltigt antal mätningar. Tryck valfri tangent för att försöka igen...");
                Console.ReadKey();
                continue;
            }

            // Skapar en lista för att spara temperaturer
            List<decimal> temperaturLista = new List<decimal>();

            for (int i = 0; i < tal; i++)
            {
                decimal temperatur;
                Console.Write($"Skriv in temperatur {i + 1}: ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input.Replace(',', '.'), out temperatur))
                {
                    temperaturLista.Add(temperatur);
                }
                else
                {
                    Console.WriteLine("Ogiltig temperatur. Försök igen.");
                    i--; // Upprepa samma index
                }
            }

            Console.WriteLine("\nDu skrev in följande temperaturer:");
            foreach (var temp in temperaturLista)
            {
                Console.WriteLine($"{temp} °C");
            }

            Console.WriteLine("\nTryck ESC för att avsluta eller annan tangent för att fortsätta...");
            var key = Console.ReadKey(true);
            knapp = false;
        }
    }
}