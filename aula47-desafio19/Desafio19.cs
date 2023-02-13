using System;

public class Desafio19
{
    public static void Main(string[] args)
    {
        string nomeDoUsuario;
        
        Console.Write("Digite seu nome: ");
        nomeDoUsuario = Console.ReadLine();
        
        ContarLetras(nomeDoUsuario);
        
        Console.ReadLine();
    }
    
    private static void ContarLetras(string nomeParaContar)
    {
        Console.WriteLine("Seu nome tem " + nomeParaContar.Length + " letras.");
    }
}