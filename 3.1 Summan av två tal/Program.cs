var list = new List<double>();

while (true)
{
    Console.Write("What is your next number? (Type -1 to exit) : ");
    double input = 0;
    while (!double.TryParse(Console.ReadLine(), out input))
        Console.WriteLine("You had one job. What is your next number? (Type -1 to exit) ");

    if (input == -1)
        break;

    list.Add(input);
}

Console.WriteLine("First number: {0}", list.Max());
Console.WriteLine("Second number: {0}", list.Min());
Console.WriteLine("Total: {0}", list.Sum());