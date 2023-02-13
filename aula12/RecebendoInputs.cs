using System;

public class RecebendoInputs
{
    public static void Main(string[] args)
    {
        string nomeDoUsuario;
        int idadeDoUsuario;
        
        Console.Write("Digite seu nome: ");
        nomeDoUsuario = Console.ReadLine();
        Console.WriteLine(nomeDoUsuario);
        
        Console.Write("Digite sua idade: ");
        //idadeDoUsuario = Console.ReadLine();
        idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(idadeDoUsuario);
        
        Console.ReadLine();
    }
}