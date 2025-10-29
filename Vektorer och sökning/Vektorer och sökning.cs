using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
        string[] coolVektor = new string[] { "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes", "Anna", "Maria", "Eva", "Karin", "Sara", "Kristina", "Lena", "Elisabeth", "Emma", "Ingrid", "Karl", "Erik", "Lars", "Anders", "Per", "Mikael", "Johan", "Olof", "Nils", "Gustav", "Oscar", "Liam", "William", "Lucas", "Hugo", "Ella", "Alice", "Maja", "Astrid", "Wilma", "Emil", "Albin", "Viktor", "Anton", "Filip", "Johanna", "Matilda", "Sofia", "Lovisa", "Agnes" };    //En massa namn för ökad coolhet
		string dittOrd = "";    // Variabel för att lagra användarens ord
        bool knapp = true;      // Variabel för att styra while-loopen

        while (knapp)
		{
			Console.WriteLine("Välkommen till menyn!");     // Min meny
            Console.WriteLine("[1] Spara ett ord");
			Console.WriteLine("[2] Skriv ut sparat ord");
			Console.WriteLine("[3] Nollställ ord");
			Console.WriteLine("[4] Skriv ett namn och se hur populärt det är");
			Console.WriteLine("Övriga val stänger programmet");

			int input = Convert.ToInt32(Console.ReadLine());

			if (input == 1)		//Som tidigare sparar detta ett ord
			{
				Console.WriteLine("Skriv ett ord:");
				dittOrd = Console.ReadLine();
				Console.WriteLine("Du skrev: " + dittOrd);
			}
			else if (input == 2)        //Som tidigare skriver detta ut ett sparat ord
            {
				Console.WriteLine("Ditt ihågkommna ord är: " + dittOrd);
			}
			else if (input == 3)        //Som återställer detta sparat ord
            {
				dittOrd = "";
				Console.WriteLine("Ditt ihågkommna ord har nollställts.");
			}
			else if (input == 4)		//Ny funktion som söker igenom en vektor med namn och talar om ifall namnet finns där och i så fall på vilken plats i listan
            {
                Console.WriteLine("Skriv ett namn och se om det är ett av sveriges 1000 mest populära namn samt hur populärt det är:");
                string sökord = Console.ReadLine();
                bool hittat = false;
                for (int i = 0; i < coolVektor.Length; i++)		//Avsöker hela vektorn
                {
                    if (sökord.ToUpper() == coolVektor[i].ToUpper())		//Ska hitta namnet om det finns i vektorn, oavsett stora eller små bokstäver
                    {
                        knapp = true;
                        Console.WriteLine("Namnet finns i listan på plats " + i + "!");		//Talar om namnet finns och på vilken plats i listan namnet isåfall finns
                        hittat = true;
                        break;
                    }
                }
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