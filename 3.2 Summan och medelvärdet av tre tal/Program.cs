var list = new List<double>();

while (true)
{
    Console.Write("What is your next number? (Type -1 to exit) : ");
    double input = 0;
    while (!double.TryParse(Console.ReadLine(), out input))
        Console.WriteLine();

    if (input == -1)
        break;

    list.Add(input);
}

Console.WriteLine("The average of your numbers is: {0}", list.Average());
Console.WriteLine("First number: {0}", list.Max());
Console.WriteLine("Second number: {0}", list.Min());
Console.WriteLine("Third number: {0}", list.Count);