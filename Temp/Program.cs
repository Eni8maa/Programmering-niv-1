Console.WriteLine("Är det fint väder?"); //Text del för användaren
Console.Write("Välj ja eller nej: "); //Text del för användaren
string UserValue = Console.ReadLine(); //Skapar en variabel för att kunna använda användarens inmatning

if (UserValue == "ja") //Om användarens inmatning är "ja"
{
    Console.WriteLine("Då går vi på picknick!"); //Skrivs ut om användarens inmatning är "ja"
}
else if (UserValue == "nej") //Om användarens inmatning är "nej"
{
    Console.WriteLine("Då stannnar vi inne."); //Skrivs ut om användarens inmatning är "nej"
}
else //Om användarens inmatning inte är "ja" eller "nej"
{
    Console.WriteLine("Du måste svara ja eller nej!"); //Skrivs ut om användarens inmatning inte är "ja" eller "nej"
}

Console.ReadLine(); 