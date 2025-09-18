using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Write("Skriv ett nummer: ");
            int start = int.Parse(Console.ReadLine());

            if (start > 100)
            {
                return false;
            }
            else
            {
                for (int i = start; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
                return true;
            }
        }
    }
}