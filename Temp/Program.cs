using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Siffran är 10");
        Console.ReadLine();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}