using System;

public class Desafio02
{
    public static void Main(string[] args)
    {
        string nome;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine(nome + ", seu nome tem " + nome.Length + " letras.");
        Console.ReadLine();
    }
}