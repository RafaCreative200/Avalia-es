using System;
class Program
{
    static void Main()
    {
        int voto;
        int Bolsomito = 0, Lula = 0, Felca = 0, votosNulos = 0;
        Console.WriteLine("Sistema de Votação");
        Console.WriteLine("Digite o número do candidato ou 9 para voto nulo:");
        Console.WriteLine("1 - Bolsomito A");
        Console.WriteLine("2 - Lule B");
        Console.WriteLine("3 - Felca C");
        Console.WriteLine("9 - Voto Nulo");
        Console.WriteLine("0 - Encerrar votação");
        do
        {
            Console.Write("Digite seu voto: ");
            voto = int.Parse(Console.ReadLine());
            switch (voto)
            {
                case 1:
                    Bolsomito++;
                    break;
                case 2:
                    Lula++;
                    break;
                case 3:
                    Felca++;
                    break;
                case 9:
                    votosNulos++;
                    break;
                case 0:
                    Console.WriteLine("Encerrando votação...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        } while (voto != 0);
        Console.WriteLine("\nResultado da votação:");
        Console.WriteLine($"Candidato A: {candidatoA} votos");
        Console.WriteLine($"Candidato B: {candidatoB} votos");
        Console.WriteLine($"Candidato C: {candidatoC} votos");
        Console.WriteLine($"Votos Nulos: {votosNulos}");
    }
}