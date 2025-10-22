using System;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=== TABUADA COMPLETA DO DIEGO ===");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Digite o número inicial (start): ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Digite o número final (end): ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine(); 

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine($"Tabuada do {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine(); 
        }
        Console.WriteLine("Fim da tabuada do Diego!");
    }
}