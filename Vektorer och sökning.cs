using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
        int[] coolVektor = new[] {  dittOrd1 + dittOrd2 + dittOrd3 + dittOrd4 + dittOrd5 }; 
        string dittOrd1 = "";    // Variabel för att lagra användarens ord
        string dittOrd2 = "";
        string dittOrd3 = "";
        string dittOrd4 = "";
        string dittOrd5 = "";
        bool knapp = true;      // Variabel för att styra while-loopen

        while (knapp)
		{
			Console.WriteLine("Välkommen till menyn!");     // Min meny
            Console.WriteLine("[1] Skriv 5 namn");
			Console.WriteLine("[2] Skriv ut sparat ord");
			Console.WriteLine("");
			Console.WriteLine("Övriga val stänger programmet");

			int input = Convert.ToInt32(Console.ReadLine());

			if (input == 1)		//Som tidigare sparar detta ett ord
			{
				Console.WriteLine("Skriv ett namn:");
				dittOrd1 = Console.ReadLine();
                Console.WriteLine("Skriv namn 2:");
                dittOrd2 = Console.ReadLine();
                Console.WriteLine("Skriv namn 3:");
                dittOrd3 = Console.ReadLine();
                Console.WriteLine("Skriv namn 4:");
                dittOrd4 = Console.ReadLine();
                Console.WriteLine("Skriv namn 5:");
                dittOrd5 = Console.ReadLine();
                Console.WriteLine("Du skrev: " + dittOrd1 + dittOrd2 + dittOrd3 + dittOrd4 + dittOrd5 );
                {
                    Console.WriteLine("Skriv ett namn och se om det är ett av sveriges 1000 mest populära namn samt hur populärt det är:");
                    string sökord = Console.ReadLine();
                    bool hittat = false;
                    for (int i = 0; i < coolVektor.Length; i++)     //Avsöker hela vektorn
                    {
                        if (sökord.ToUpper() == coolVektor[i].ToUpper())        //Ska hitta namnet om det finns i vektorn, oavsett stora eller små bokstäver
                        {
                            knapp = true;
                            Console.WriteLine("Namn " + i);     //Talar om namnet finns och på vilken plats i listan namnet isåfall finns
                            hittat = true;
                            break;
                        }
                    }
                }
            }
			else if (input == 2)        //Som tidigare skriver detta ut ett sparat ord
            {
				Console.WriteLine("Ditt ihågkommna ord är: " + dittOrd);
			}
			else if (input == 3)        //Som återställer detta sparat ord
            {
				dittOrd1 = "";
                dittOrd2 = "";
                dittOrd3 = "";
                dittOrd4 = "";
                dittOrd5 = "";
                Console.WriteLine("Dinna namn har nollställts.");
			}
            else
			{
				Console.WriteLine("Ogiltigt val. Programmet kommer nu att avslutas. Vänligen försök igen.");        //Talar om att programmet avslutas vid ogiltigt val
                Console.ReadLine();
				knapp = false;
			}
		}
	}
}