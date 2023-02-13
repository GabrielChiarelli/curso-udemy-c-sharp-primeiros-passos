using System;

public class Desafio01
{
    public static void Main(string[] args)
    {
        string nome;
        string cidade;
        int idade;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite sua cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Oi, " + nome + ". Voce tem " + idade + " anos e mora na cidade: " + cidade + ".");
        
        Console.ReadLine();
    }
}