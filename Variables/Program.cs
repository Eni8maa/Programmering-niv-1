namespace Varibles
    {
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x= 7;
            y=x+3;

            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("What is your first name?");
            Console.Write("Type your first name:");
            string MyFirstName;
            MyFirstName = Console.ReadLine();

            //string MyLastName;
            //Console.Write("Type your last name:");
            //MyLastName = Console.ReadLine();

            Console.Write("Type your last name:");
            string MyLastName = Console.ReadLine();

            Console.WriteLine("Hello," + MyFirstName + " " + MyLastName);
            Console.ReadLine();
        }
    }
}