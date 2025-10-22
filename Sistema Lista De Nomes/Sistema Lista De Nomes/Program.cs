using System;
class Program
{
    static void Main()
    {
        string[] nomes = { "Alice", "Bruno", "Carla", "Diego", "Elisa", "Welton", "Xelton", "Melton", "Rafael", "Sophia", "Sofia", "Tayla", "Ytalo", "Luis","William", "Pedro", "Luiz", "Sarah", "Sarah" };
        Console.Write("Digite um nome para pesquisar: ");
        string nomeBusca = Console.ReadLine();
        bool encontrado = false;
        foreach (string nome in nomes)
        {
            if (nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine($"O nome {nomeBusca} foi encontrado no vetor.");
        }
        else
        {
            Console.WriteLine($"O nome {nomeBusca} não está no vetor.");
        }
    }
}