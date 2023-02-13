using System;

public class Variaveis
{
    public static void Main(string[] args)
    {
        string nomeDoUsuario = "Jessica";
        string cidade = "Rio de Janeiro";
        string profissao;
        string numero = "123";
        
        Console.WriteLine(nomeDoUsuario);
        Console.WriteLine(cidade);
        Console.WriteLine("O usuario: " + nomeDoUsuario + " mora no " + cidade);
        
        profissao = "Programadora";
        Console.WriteLine(profissao);
        
        Console.WriteLine("Oi! Me chamo Gabriel.");
        Console.WriteLine("Tenho 23 anos e estou estudando c#.");
        
        Console.WriteLine("Oi! Me chamo Gabriel.\nTenho\n23 anos\ne estou estudando c#.");
        
        Console.WriteLine(nomeDoUsuario[0]);
        
        Console.WriteLine(nomeDoUsuario.Length);
        Console.WriteLine(nomeDoUsuario.ToUpper());
        Console.WriteLine(nomeDoUsuario.ToLower());

        Console.ReadLine();
    }
}