using System;

public class Desafio03
{
    public static void Main(string[] args)
    {
        string nome;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("Primeira: " + nome[0]);
        Console.WriteLine("Ultima: " + nome[nome.Length - 1]);
        
        Console.ReadLine();
    }
}