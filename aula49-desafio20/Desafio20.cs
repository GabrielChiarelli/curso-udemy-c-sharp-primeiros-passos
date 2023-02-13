using System;

public class Desafio20
{
    public static void Main(string[] args)
    {
        string nomeDigitado;
        
        Console.Write("Digite seu nome: ");
        nomeDigitado = Console.ReadLine();
        
        Console.WriteLine(ContarLetras(nomeDigitado));
        
        Console.ReadLine();
    }
    
    private static string ContarLetras(string nomeParaContar)
    {
        //string frase = "Seu nome tem " + nomeParaContar.Length + " letras.";
        //return frase;
        
        return "Seu nome tem " + nomeParaContar.Length + " letras.";
    }
}