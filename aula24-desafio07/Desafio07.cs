using System;

public class Desafio07
{
    public static void Main(string[] args)
    {
        string nome;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        
        if(nome == "Gabriel" || nome == "Peach")
        {
            Console.WriteLine("Seu nome e muito bonito");
        }
        else
        {
            Console.WriteLine("Seu nome e legal");
        }
        
        Console.ReadLine();
    }
}