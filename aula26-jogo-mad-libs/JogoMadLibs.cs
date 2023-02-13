using System;

public class JogoMadLibs
{
    public static void Main(string[] args)
    {
        string nome;
        int idade;
        string adjetivo;
        string verbo;
        
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Adjetivo: ");
        adjetivo = Console.ReadLine();
        Console.Write("Verbo: ");
        verbo = Console.ReadLine();
        
        Console.WriteLine(nome + " tinha " + idade + " anos.");
        Console.WriteLine("E era uma pessoa muito legal!");
        Console.WriteLine("Era muito " + adjetivo + ", tipo, muito mesmo.");
        Console.WriteLine("E amava " + verbo + " bolas nas redes!");
        
        Console.ReadLine();
    }
}