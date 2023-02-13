using System;

public class MetodosComRetornos
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(Somar());
        Console.WriteLine(RetornarNome());
        
        Console.ReadLine();
    }
    
    private static int Somar()
    {
        int soma = 1 + 5;
        return soma;
    }
    
    private static string RetornarNome()
    {
        string nomeParaRetornar = "Mario";
        return nomeParaRetornar;
    }
}