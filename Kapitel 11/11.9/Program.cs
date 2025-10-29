namespace elva.nio
{
    class Program
    {
        private static void FahrenheitToCelsius(object fahrenheit)
        {
            float farenheit = 212.56f;
            int MyTemperature = (int)((farenheit));
            float celsius = MyTemperature;
            FahrenheitToCelsius(fahrenheit);
        }
        static void Main(string[] args)
        {
            int celsius = Convert.ToInt32(args[0]);

            Console.WriteLine("Vattnet är " + celsius + 2 + "grader");

            if (MyTemperature.IsBoiling(celsius))
            {
                Console.WriteLine("Det kokar");
            }
            else
            {
                Console.WriteLine("Det kokar inte än!");
            }
        }
    }
}