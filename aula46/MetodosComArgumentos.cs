using System;

public class MetodosComArgumentos
{
    public static void Main(string[] args)
    {
        string nome = "Mario";
        //EscreverNome(nome);
        //EscreverNome("Luigi");
        
        Somar(1, 4);
        Somar(10, 55);
        
        Console.ReadLine();
    }
    
    private static void EscreverNome(string nomeParaEscrever)
    {
        Console.WriteLine(nomeParaEscrever);
    }
    
    private static void Somar(int numero1, int numero2)
    {
        Console.WriteLine((numero1 + numero2));
    }
}