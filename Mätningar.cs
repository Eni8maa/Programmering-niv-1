using System;
using System.Collections.Generic;

List<string> namn = new List<string>();
int input;
int tal = 0; // Initialize 'tal' to avoid CS0165
bool knapp = true;

while (knapp)
{
    Console.Clear();
    Console.WriteLine("Välkommen, hur många mätningar har gjorts idag:");
    string talInput = Console.ReadLine();
    if (int.TryParse(talInput, out tal))
    {
        Console.WriteLine(tal + " har gjorts idag.");
    }
    else
    {
        Console.WriteLine("Ogiltigt antal mätningar.");
        continue;
    }

    // Skapar en lista för att spara input
    List<string> namnLista = new List<string>();

    // Loopar 5 gånger
    for (int i = 0; i < 5; i++)
    {
        Console.Write("Skriv in en temperatur: ");
        // Läser användarens input
        namnLista.Add(Console.ReadLine()); // Sparar input i listan
    }

    // Skriver ut alla sparade namn
    Console.WriteLine("\nDu skrev in följande namn:");
    for (int i = 0; i < namnLista.Count; i++)
    {
        Console.WriteLine(namnLista[i]);
    }
    if (e.KeyCode == Keys.Escape) // If the Escape key is pressed
    {
        GoToMenu();
    }
Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
Console.ReadKey();
