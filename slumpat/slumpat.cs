using System; //bytte ut system till korrekta System

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1, 21); // skrev till ett spann mellan 1 och 20

            bool spela = true; 

            while (/* ! */ spela) // tog bort ! för att loopen ska fortsätta så länge spela är true
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                int tal;
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    if (tal < speltal)
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                    }
                    else if (tal > speltal)
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                    }
                    else
                    {
                        Console.WriteLine("\tGrattis, du gissade rätt!");
                        spela = false;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Skriv ett heltal.");
                }
            }
        }
    }
}
