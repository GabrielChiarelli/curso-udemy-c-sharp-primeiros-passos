using System;

public class Desafio09
{
    public static void Main(string[] args)
    {
        string nomeDoUsuario;
        
        Console.Write("Digite um nome: ");
        nomeDoUsuario = Console.ReadLine();
        
        switch(nomeDoUsuario)
        {
            case "Gabriel":
                Console.WriteLine("Seu nome e muito bonito.");
                break;
            case "Peach":
                Console.WriteLine("Seu nome e muito bonito.");
                break;
            default:
                Console.WriteLine("Seu nome e legal.");
                break;
        }
        
        Console.ReadLine();
    }
}