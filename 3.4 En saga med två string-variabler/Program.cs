namespace Varibles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who is your first person?");
            Console.Write("Type your first person:");
            string MyFirstName;
            MyFirstName = Console.ReadLine();

            Console.Write("Type your second person:");
            string MyLastName = Console.ReadLine();

            Console.WriteLine(MyFirstName + " is a dirty filthy pervert and you probably shouldn't be alone with this dude. ");
            Console.WriteLine(MyLastName + " is a goddamn angel. The dude has been giving to charity and doing straight up angel shit. ");
            Console.ReadLine();
        }
    }
}