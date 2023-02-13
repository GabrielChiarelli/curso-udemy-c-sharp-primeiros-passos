using System;

public class Desafio22
{
    public static void Main(string[] args)
    {
        string nomeDoUsuario;
        
        Console.Write("Digite seu nome: ");
        nomeDoUsuario = Console.ReadLine();
        
        Console.WriteLine(nomeDoUsuario + ", seu nome em letras maiusculas e: " + DeixarNomeEmMaiusculas(nomeDoUsuario));
        
        Console.ReadLine();
    }
    
    private static string DeixarNomeEmMaiusculas(string nome)
    {
        return nome.ToUpper();
    }
}