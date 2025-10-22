using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());
        Console.Write("Digite o peso da primeira nota: ");
        double peso1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o peso da segunda nota: ");
        double peso2 = double.Parse(Console.ReadLine());
        Console.Write("Digite o peso da terceira nota: ");
        double peso3 = double.Parse(Console.ReadLine());
        double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

        Console.WriteLine($"\nMédia Ponderada: {media:F2}");
        if (media >= 7.0)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else if (media >= 5.0)
        {
            Console.WriteLine("Situação: Recuperação");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}
