using System;

public class Desafio11
{
    public static void Main(string[] args)
    {
        string[] nomes = new string[5];
        
        Console.Write("Nome 1: ");
        nomes[0] = Console.ReadLine();
        Console.Write("Nome 2: ");
        nomes[1] = Console.ReadLine();
        Console.Write("Nome 3: ");
        nomes[2] = Console.ReadLine();
        Console.Write("Nome 4: ");
        nomes[3] = Console.ReadLine();
        Console.Write("Nome 5: ");
        nomes[4] = Console.ReadLine();
        
        Console.WriteLine("Lista dos 5 nomes: ");
        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes[1]);
        Console.WriteLine(nomes[2]);
        Console.WriteLine(nomes[3]);
        Console.WriteLine(nomes[4]);
        
        Console.ReadLine();
    }
}