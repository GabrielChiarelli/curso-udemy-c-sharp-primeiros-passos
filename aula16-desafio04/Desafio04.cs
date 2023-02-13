using System;

public class Desafio04
{
    public static void Main(string[] args)
    {
        string nomeDoUsuario;
        
        Console.Write("Digite seu nome: ");
        nomeDoUsuario = Console.ReadLine();
        
        Console.WriteLine(nomeDoUsuario.ToUpper());
        Console.WriteLine(nomeDoUsuario.ToLower());
        
        Console.ReadLine();
    }
}