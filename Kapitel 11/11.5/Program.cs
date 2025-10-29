using System;

namespace elva.fem
{
    public class Program
    {
        static public void Main()
        {
            Console.WriteLine("Vänligen ange hur mycket momsen är till summan i siffror:");
            int input = Convert.ToInt32(Console.ReadLine());
        
            int Summa = 100;
            int Moms = input;
            int sum = Summa + Moms;
            Console.WriteLine("Summa inklusive moms: " + sum + ". Tryck enter.");
            Console.ReadLine();

            Console.WriteLine("Tryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}
