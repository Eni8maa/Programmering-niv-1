namespace Djuret
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur Apa = new Djur();

            Apa.Djursort = "Djursort = Dvärgsilkesapa,";
            Apa.Namn = "Namn = Sven-Erik, Ålder =";
            Apa.Ålder = 7 ;
            Apa.Ras = ", Ras = Cebuella pygmaea/Callithrix pygmea,";
            Apa.Ljud = "Ljud = låter högt,";
            Apa.Hämta = "hämta = true"; 

            Djur Elefant;
            Elefant = Apa;

            Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                Elefant.Djursort,
                Elefant.Namn,
                Elefant.Ålder,
                Elefant.Ras,
                Elefant.Ljud,
                Elefant.Hämta);

            Elefant.Djursort = "Djursort = Elefant,";
            Elefant.Namn = "Namn = N/A, Ålder =";
            Elefant.Ålder = 10;
            Elefant.Ras = ", Ras = Afrikansk skogselefant,";
            Elefant.Ljud = "Ljud = ¨medium inte jättehögt,";
            Elefant.Hämta = "hämta = false";

            Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                Apa.Djursort,
                Apa.Namn,
                Apa.Ålder,
                Apa.Ras,
                Apa.Ljud,
                Apa.Hämta);

        private static void Second()
        {
            List<string> coolVektor = new List<string> { "Gråvarg", "Rödräv", "Lodjur", "Brunbjörn", "Vildsvin", "Älg", "Rådjur", "Hjort", "Mård", "Grävling", "Igelkott", "Ekorre", "Hare", "Vessla", "Utter", "Säl", "Mullvad", "Mus", "Råtta", "Fladdermus", "Björn", "Ren", "Get", "Får", "Ko", "Häst", "Hund", "Katt", "Kanin", "Marsvin", "Chinchilla", "Kamel", "Dromedar", "Elefant", "Tiger", "Lejon", "Gepard", "Panter", "Leopard", "Puma", "Zebra", "Giraff", "Flodhäst", "Noshörning", "Koala", "Känguru", "Vombat", "Panda", "Tvättbjörn", "Skunk", "Bison", "Jättepanda", "Isbjörn", "Sjölejon", "Delfin", "Val", "Späckhuggare", "Narval", "Sjöko", "Hamnäl", "Räv", "Järv", "Fjällämmel", "Bisamråtta", "Bäver", "Hermelin", "Rödmus", "Snöleopard", "Serval", "Ozelot", "Vildkatt", "Rävhund", "Manul", "Tvättbjörnsapa", "Dvärgsilkesapa", "Babian", "Gorilla", "Schimpans", "Orangutang", "Makak", "Tamarin", "Gibbon", "Lemur", "Nattapa", "Bältdjur", "Myreslukare", "Sengångare", "Gris", "Rådjursbock", "Gazell", "Antilop", "Vattenbuffel", "Yak", "Okapi", "Tapir", "Myskoxe", "Kapybara", "Piggsvin", "Mullvadssvin", "Jätteutter", "Koltrast", "Talgoxe", "Blåmes", "Skata", "Kråka", "Gråsparv", "Pilfink", "Sädesärla", "Bofink", "Grönfink", "Nötskrika", "Hackspett", "Stare", "Domherre", "Kaja", "Gärdsmyg", "Kattuggla", "Fiskmås", "Svan", "Trana", "Tjäder", "Orre", "Ripa", "Sparvhök", "Ormvråk", "Kungsörn", "Havsörn", "Glada", "Falk", "Uggla", "Tornfalk", "Lärkfalk", "Tjädertupp", "Knipa", "Ejder", "Gräsand", "Kricka", "Bläsand", "Storskrake", "Smådopping", "Sothöna", "Rördrom", "Sävsparv", "Lövsångare", "Trädkrypare", "Gök", "Törnskata", "Storspov", "Berguv", "Mås", "Häger", "Tärna", "Korp", "Skogssnäppa", "Sånglärka", "Näktergal", "Gulhämpling", "Svarthätta", "Rödhake", "Gråhäger", "Gås", "Änder", "Stork", "Pelikan", "Flamingo", "Pingvin", "Struts", "Emu", "Kiwi", "Kakadua", "Papegoja", "Ara", "Undulat", "Kanariefågel", "Zebrafink", "Kolvfink", "Fasan", "Påfågel", "Kalkon", "Höna", "Tupp", "Anka", "And", "Gås", "Rapphöna", "Vaktel", "Duva", "Turturduva", "Svala", "Måsunge", "Stenknäck", "Snösparv", "Fjällpipare", "Ejderhona", "Fjällvråk", "Tjäderhöna", "Rördromshane", "Sothöneunge", "Kråkunge", "Göktyta", "Snok", "Huggorm", "Kopparödla", "Sandödla", "Skogsödla", "Leguan", "Kameleont", "Geckoödla", "Boaorm", "Pytonorm", "Korallorm", "Anakonda", "Gartersnok", "Vattensnok", "Svart mamba", "Kungsboa", "Sköldpadda", "Havsorm", "Agama", "Varan", "Nilkrokodil", "Alligator", "Kajman", "Gavial", "Ökensnok", "Klapperschlange", "Husödla", "Leopardgecko", "Daggecko", "Bandvaran", "Savannvaran", "Blåleguan", "Ökenkameleont", "Smålandsödla", "Trädkameleont", "Fyrfläckig orm", "Kungspyton", "Tigerpyton", "Grön anakonda", "Röd snok", "Indisk kobra", "Kungskobra", "Sandboa", "Mamba", "Öronorm", "Bergsboa", "Skogsboa", "Basilisk", "Röd ödla", "Vattensköldpadda", "Greksköldpadda", "Rödörad vattensköldpadda", "Snapping turtle", "Havssköldpadda", "Landsköldpadda", "Träskkrokodil", "Mississippialligator", "Kustboa", "Tjocksvansödla", "Skogsleguan", "Sötvattensorm", "Svart huggorm", "Väggödla", "Kopparorm", "Trädsnok", "Rödsnok", "Kungsleguan", "Örnsnok", "Landsorm", "Ökensnabelorm", "Gräsödla", "Sandleguan", "Afrikansk pytonorm", "Väggorm", "Nattgecko", "Skogsgecko", "Kalködla", "Gul snok", "Blå snok", "Röd kobra", "Indisk kobra", "Kungspyton", "Tjockhalsödla", "Stäppkameleont", "Savannkameleont", "Grön leguan", "Blå gecko", "Svart ödla", "Fjällödla", "Jätteleguan", "Savannvaran", "Nilvaran", "Klippororm", "Väggorm", "Träskorm", "Korallröd orm", "Sandröd orm", "Bergkameleont", "Trädkameleont", "Regnskogsleguan", "Vanlig groda", "Åkergroda", "Paddan", "Lövgroda", "Klockgroda", "Gröngroda", "Bergsgroda", "Kantsalamander", "Storsalamander", "Liten vattensalamander", "Spetsnoshjärtsalamander", "Gulbukad padda", "Rödlistad groda", "Trädgroda", "Dammgroda", "Tjurpadda", "Regngroda", "Flodgroda", "Bergspadda", "Sjöpadda", "Källgroda", "Sumpsalamander", "Vattensalamander", "Markgroda", "Sjögroda", "Daggroda", "Storskogsgroda", "Minigroda", "Tropisk groda", "Kustgroda", "Mossgroda", "Dvärggroda", "Kantgroda", "Gräsplättgroda", "Flodpadda", "Sjöpadda", "Markpadda", "Trädpadda", "Vattenpadda", "Tropisk padda", "Stor groda", "Mini groda", "Vandringsgroda", "Nattgroda", "Vattengroda", "Brungroda", "Svart padda", "Blå groda", "Röd groda", "Grön padda", "Sjöfrossa", "Trollgroda", "Kustpadda", "Nordpadda", "Sydgroda", "Östgroda", "Västgroda", "Källpadda", "Träskpadda", "Våtmarksgroda", "Tundrapadda", "Bergsgroda", "Regnskogsgroda", "Källgroda", "Mosspadda", "Sjöpadda", "Sandpadda", "Ökensalamander", "Tropiksalamander", "Regnsalamander", "Flodsalamander", "Källsalamander", "Sumpsalamander", "Marksalamander", "Tundrasalamander", "Skogssalamander", "Dvärgsalamander", "Liten salamander", "Stor salamander", "Grodsalamander", "Kustsalamander", "Bergssalamander", "Mossalamander", "Vattensalamander", "Källgroda", "Trollpadda", "Skogsgrön groda", "Myrgroda", "Snögroda", "Träskgroda", "Trollpadda", "Röd padda", "Blå padda", "Grön groda", "Svart groda", "Vitt grodyngel", "Grodyngel", "Smågroda", "Stor groda", "Trädpadda", "Abborre", "Gädda", "Mört", "Braxen", "Sik", "Öring", "Lax", "Torsk", "Makrill", "Sill", "Röding", "Sarv", "Id", "Regnbåge", "Haj", "Tonfisk", "Svärdfisk", "Hälleflundra", "Räka", "Ål", "Torskfisk", "Pigghaj", "Laxöring", "Flundra", "Sjöborre", "Storspigg", "Småspigg", "Mörtfisk", "Siklöja", "Sillfisk", "Karpen", "Guldfisk", "Koi", "Plattfisk", "Stenbit", "Kummel", "Kolja", "Gös", "Ruda", "Elritsa", "Sandstubb", "Berggylta", "Tånglake", "Havsabborre", "Blåmussla", "Havsöring", "Spigg", "Rödfisk", "Gråsej", "Trollhaj", "Tropisk fisk", "Koralldoktor", "Clownfisk", "Palettkirurg", "Napoleonfisk", "Blåsfisk", "Piggvar", "Skrubbskädda", "Kummel", "Kolja", "Sillkung", "Tångsnälla", "Sjöhäst", "Rötsimpa", "Knaggrocka", "Rödräka", "Jättemakrill", "Klippskarp", "Korallfisk", "Revfisk", "Tångspigg", "Havskatt", "Tigerfisk", "Paddfisk", "Piraya", "Malar", "Ålsik", "Fjällruda", "Karpfisk", "Sandskädda", "Lodda", "Blåhaj", "Gråhaj", "Vithaj", "Silverskarp", "Rödsill", "Vitling", "Storsill", "Guldfisk", "Paddfisk", "Rödspätta", "Sjöål", "Stenbit", "Sillkung", "Gråsej", "Torskfisk", "Sillfisk", "Havsfisk", "Flundra", "Makrill" };
            string dittOrd = "";    // Variabel för att lagra användarens ord
            bool ValleyOfDeath = true;      // Variabel för att styra while-loopen

            while (ValleyOfDeath)
            {
                Console.WriteLine("Välkommen till menyn!");     // Min meny
                Console.WriteLine("[1] Spara ett djur");
                Console.WriteLine("[2] Skriv ut sparat ord");
                Console.WriteLine("[3] Nollställ ord");
                Console.WriteLine("[4] Skriv ett namn och se hur populärt det är");
                Console.WriteLine("Övriga val stänger programmet");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)     //Som tidigare sparar detta ett ord
                {
                    Console.WriteLine("Skriv ett djur:");
                    dittOrd = Console.ReadLine();
                }
                else if (input == 2)        //Som tidigare skriver detta ut ett sparat ord
                {
                    Console.WriteLine("Ditt ihågkommna ord är: " + dittOrd);
                }
                string sökord = Console.ReadLine();
                    bool hittat = false;
                    for (int i = 0; i < coolVektor.Count; i++)     //Avsöker hela vektorn
                    {
                    if (sökord.Equals (coolVektor[i], StringComparison.OrdinalIgnoreCase))        //Ska hitta namnet om det finns i vektorn, oavsett stora eller små bokstäver
                    {
                        hittat = true;
                    }
                    else (!hittat)       //Om namnet inte finns i listan
                    {
                        coolVektor.Add(dittOrd);
                    }
                    break;
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





    /* mittAndraDjur = null;

    Apa = null;

    Console.ReadLine(); 
}
}
class Djur
{
public string Djursort { get; set; }
public string Namn { get; set; }
public int Ålder { get; set; }
public string Ras { get; set; }
public string Ljud { get; set; }
public string Hämta { get; set; }

public Djur()
{
    Djursort = "Katt";
}
public Djur(string djursort, string namn, int ålder, string ras, string ljud, string hämta)
{
    Namn = namn;
}       
public static void myMethod()
{
    Console.WriteLine("Called the static myMethod");
}*/
}
}