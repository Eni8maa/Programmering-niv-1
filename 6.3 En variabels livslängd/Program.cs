int temp; //not in orginal code
do
{
    Console.WriteLine("Mät vattnet. Hur många grader är det nu?");
    string str = Console.ReadLine();
    /* int */ temp = Convert.ToInt32(str); //what outputs error
} while(temp < 100);

Console.WriteLine("Nu kokar det!");

//Felet uppkommer för att du inte kan deklarera variabeln temp inuti loopen och sedan försöka använda den utanför loopen.
