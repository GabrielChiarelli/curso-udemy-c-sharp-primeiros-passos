using System;

public class Desafio18
{
    public static void Main(string[] args)
    {
        ContarLetras();
        Console.WriteLine("Terminou o primeiro metodo");
        ContarLetras();
        ContarLetras();
        
        Console.ReadLine();
    }
    
    private static void ContarLetras()
    {
        string nomeDoUsuario;
        
        Console.Write("Digite seu nome: ");
        nomeDoUsuario = Console.ReadLine();
        
        Console.WriteLine("Seu nome tem " + nomeDoUsuario.Length + " letras.");
    }
}